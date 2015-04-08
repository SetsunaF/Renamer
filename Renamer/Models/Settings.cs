using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32; 
using Newtonsoft.Json;

namespace Renamer.Models
{
    public static class Settings
    {
        public static string ApplicationDataPath = Application.StartupPath;
        private static string SettingsFile = ApplicationDataPath + "\\Settings.json";

        public static bool SaveLastProfile;
        //public static bool SavePreviousFileNames;
        public static bool WarnBeforeRecursiveRename;

        public static bool Load()
        {
            string data;
            try { data=File.ReadAllText(SettingsFile); }
            catch { return false; }            

            var definition = new
            {
                SaveLastProfile = Settings.SaveLastProfile,
                //SavePreviousFileNames = Settings.SavePreviousFileNames,
                WarnBeforeRecursiveRename = Settings.WarnBeforeRecursiveRename
            };

            try
            {
                var obj = JsonConvert.DeserializeAnonymousType(data, definition);

                SaveLastProfile = obj.SaveLastProfile;
                //SavePreviousFileNames = obj.SavePreviousFileNames;
                WarnBeforeRecursiveRename = obj.WarnBeforeRecursiveRename;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            
            return true;
        }

        public static bool Save()
        {
            try { File.Delete(SettingsFile); }
            catch { }

            var data = JsonConvert.SerializeObject(new
            {
                SaveLastProfile = Settings.SaveLastProfile,
                //SavePreviousFileNames = Settings.SavePreviousFileNames,
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

        private static string shellKey = @"Folder\shell";
        private static string keyName = shellKey + @"\renamer";
        private static string subKeyName = keyName + @"\command";

        public static bool IsContextMenuEnabled()
        {
            using (var key = Registry.ClassesRoot.OpenSubKey(keyName))
            {
                return key != null;
            }
        }

        public static bool EnableContextMenu()
        {
            var exe = System.Reflection.Assembly.GetEntryAssembly().Location;

            try
            {
                using (var key = Registry.ClassesRoot.CreateSubKey(keyName))
                {
                    key.SetValue(null, "&Renamer");
                    key.SetValue("Icon", exe);
                    key.SetValue("Extended", "");

                    using (var subKey = Registry.ClassesRoot.CreateSubKey(subKeyName))
                    {
                        subKey.SetValue(null, "\"" + exe + "\" \"%1\"");
                    }
                }

                return true;
            }
            catch { return false; }            
        }

        public static bool DisableContextMenu()
        {
            if (!IsContextMenuEnabled()) return false;

            try
            {
                using (var key = Registry.ClassesRoot.OpenSubKey(shellKey, true))
                {
                    key.DeleteSubKeyTree("renamer");
                }
                return true;
            }
            catch { return false; }
        }

        

       





    }
}
