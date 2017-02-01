using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DymoMaster3000
{
    class Settings
    {
        private string filePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private string fileName = "settings.config";
        private string file = "";

        private Dictionary<String, String> settings;

        public Settings()
        {
            file = filePath + "/" + fileName;
        }

        private void readSettings(string file)
        {
            foreach (string row in File.ReadAllLines(file))
            {
                string[] splitted = Regex.Split(row, @"\-\?\|\?\-");
                this.updateSetting(splitted[0], splitted[1], false);
            }

            this.saveSettings();
        }

        private void createDefaultSettings(string file)
        {
            /**
             * Add every default setting
             */

            // TextParser
            this.updateSetting("trimWhiteSpace","true",false);
            this.updateSetting("delimiter", ";", false);

            this.saveSettings();
        }

        public void updateSetting(string settingKey, string settingValue, bool saveAfter)
        {
            if (settings == null)
            {
                settings = new Dictionary<string, string>();
            }

            if (this.settings.ContainsKey(settingKey))
            {
                this.settings.Remove(settingKey);
            }

            this.settings.Add(settingKey, settingValue);

            saveSettings();
        }
        public void updateSetting(string settingKey, string settingValue)
        {
            updateSetting(settingKey,settingValue,true);
        }

        public void saveSettings()
        {
            StreamWriter file = new StreamWriter(this.file);

            foreach (string key in settings.Keys)
            {
                file.WriteLine(key.Trim() + "-?|?-" + settings[key].Trim());
            }

            file.Close();
        }
    }
}
