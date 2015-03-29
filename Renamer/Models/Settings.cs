using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Renamer.Models
{
    public class Settings
    {
        public static string ApplicationDataPath = Application.StartupPath;
        private static string SettingsFile = ApplicationDataPath + "\\Settings.json";

        public static bool SaveLastProfile;
        public static bool SavePreviousFileNames;
        public static bool WarnBeforeRecursiveRename;

        public static bool Load()
        {
            string data;
            try { data=File.ReadAllText(SettingsFile); }
            catch { return false; }

            var obj = JsonConvert.DeserializeObject<Settings>(data);
            return true;
        }

        public static bool Save()
        {
            try { File.Delete(SettingsFile); }
            catch { return false; }

            var data = JsonConvert.SerializeObject(new
            {
                SaveLastProfile = Settings.SaveLastProfile,
                SavePreviousFileNames = Settings.SavePreviousFileNames,
                WarnBeforeRecursiveRename = Settings.WarnBeforeRecursiveRename
            });

            try
            {
                var writer = new StreamWriter(SettingsFile);
                writer.Write(data);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

       




    }
}
