using System;

namespace DymoMaster3000
{
    public class DymoSticker
    {
        public string firstLine = "";
        public string secondLine = "";

        public DymoSticker(string firstLine)
        {
            this.firstLine = firstLine;
        }

        public DymoSticker(string firstLine, string secondLine)
        {
            this.firstLine = firstLine;
            this.secondLine = secondLine;
        }

        public override string ToString()
        {
            if (secondLine.Length > 0)
            {
                return firstLine + " ; " + secondLine;
            }

            return firstLine;
        }

        public bool isEmpty()
        {
            return this.firstLine.Trim() == "" && this.secondLine.Trim() == "";
        }

        public string toDymo()
        {
            if (secondLine.Length > 0)
            {
                return firstLine + ";" + secondLine;
            }

            return firstLine;
        }
    }
}