using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Renamer.Models;

namespace Renamer.Common
{
    public class ProfileManager
    {
        public List<Profile> ProfileList = new List<Profile>();
        private string profileDirectory;
        private ComboBox comboBox;

        public ProfileManager(ComboBox combo)
        {
            string appDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            profileDirectory = appDirectory + "\\Profiles";

            comboBox = combo;

            CreateProfileFolder();
            ReloadProfiles();
        }

        //stackoverflow.com/questions/600869/how-to-bind-a-list-to-a-combobox-winforms
        public void PopulateProfiles()
        {
            comboBox.Items.Clear();
            comboBox.Text = "";

            foreach (var profile in ProfileList)
                comboBox.Items.Add(profile.Name);

            //comboBox.DataSource = null;
            //comboBox.DataSource = ProfileList;
            //comboBox.DisplayMember = "Name";

            comboBox.Refresh();
        }

        private void ReloadProfiles()
        {
            ProfileList.Clear();
            string[] files = Directory.GetFiles(profileDirectory, "*.json");

            foreach (var file in files)
            {
                try
                {
                    ProfileList.Add(new Profile(file));
                }
                catch
                {
                    MessageBox.Show("Error loading profile: \"" + Path.GetFileNameWithoutExtension(file) +
                        "\". The profile might have been ceated by an older version of the application or the profile file may be damaged.", 
                        "Renamer", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    System.Diagnostics.Process.Start(profileDirectory);

                    break;
                }
            }

            ProfileList = new List<Profile>(ProfileList.OrderBy(o => o.Name));
        }

        private void CreateProfileFolder()
        {
            if (!Directory.Exists(profileDirectory))
                Directory.CreateDirectory(profileDirectory);
        }

        //Save profile of index...
        private bool SaveProfile(int index, bool overwrite = true)
        {
            //int index = comboBox.SelectedIndex;
            string message;

            if (!ProfileList[index].Save(overwrite, out message))
            {
                MessageBox.Show(message, "Save Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void Update(List<Filter> filters)
        {
            int index = comboBox.SelectedIndex;

            ProfileList[index].Filters.Clear();
            ProfileList[index].Filters = new List<Filter>(filters);

            SaveProfile(index, true);
        }

        public bool AddProfile(Profile profile, bool populate = true)
        {
            ProfileList.Add(profile);
            int index = ProfileList.Count - 1;

            if (!SaveProfile(index, false))
            {
                ProfileList.RemoveAt(index);
                return false;
            }

            if (populate)
            {
                PopulateProfiles();
                comboBox.SelectedIndex = comboBox.Items.Count - 1;
            }

            return true;
        }

        public void DeleteSelected()
        {
            int index = comboBox.SelectedIndex;
            string message;

            if (!ProfileList[index].Delete(out message))
                MessageBox.Show(message, "Delete Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ProfileList.RemoveAt(index);
                PopulateProfiles();
            }
        }

        private int FindProfile(string name)
        {
            for (int i = 0; i < ProfileList.Count; i++)
            {
                if (name == ProfileList[i].Name) return i;
            }
            return -1;
        }

        public void SaveLastProfile(List<Filter> filters)
        {
            if (filters.Count == 0) return;

            var name = "Last Profile";
            var index = FindProfile(name);

            if (index == -1)
            {
                AddProfile(new Profile(name, filters), false);
                return;
            }

            ProfileList[index].Filters.Clear();
            ProfileList[index].Filters = new List<Filter>(filters);

            string message;
            ProfileList[index].Save(true, out message);
        }

        public void AssignProfile(out List<Filter> filterList)
        {
            if (comboBox.SelectedIndex == -1) filterList = new List<Filter>();
            else filterList=new List<Filter>(ProfileList[comboBox.SelectedIndex].Filters);
        }



    }
}
