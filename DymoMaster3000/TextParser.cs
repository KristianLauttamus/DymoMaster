using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DymoMaster3000
{
    class TextParser : SettingsInitializable
    {
        private string delimiter;
        private bool trimWhitespace;

        public TextParser(string delimiter)
        {
            this.delimiter = delimiter;
            this.trimWhitespace = true;
        }

        public void setDelimiter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public void setTrimWhitespace(bool trimWhitespace)
        {
            this.trimWhitespace = trimWhitespace;
        }

        public List<DymoSticker> parseText(string text)
        {
            List<DymoSticker> stickers = new List<DymoSticker>();

            foreach (var row in text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)) {
                string[] splittedRow = new string[] { row };

                if (delimiter.Length > 0)
                {
                    splittedRow = row.Split(new string[] { this.delimiter }, StringSplitOptions.RemoveEmptyEntries);
                }

                foreach (string splitted in splittedRow)
                {
                    if (this.trimWhitespace)
                    {
                        stickers.Add(new DymoSticker(splitted.Trim()));
                    }
                    else
                    {
                        stickers.Add(new DymoSticker(splitted));
                    }
                }
            }

            return stickers;
        }

        public void loadFromSettings()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> getForSettings()
        {
            throw new NotImplementedException();
        }
    }
}
