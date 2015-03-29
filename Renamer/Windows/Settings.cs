using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer.Windows
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkBoxEnableContextMenu.Checked) Models.Settings.EnableContextMenu();
            else Models.Settings.DisableContextMenu();

            Models.Settings.SaveLastProfile=checkBoxSaveLastProfile.Checked;
            Models.Settings.SavePreviousFileNames=checkBoxSavePreviousFileNames.Checked;
            Models.Settings.WarnBeforeRecursiveRename = checkBoxWarnBeforeRecursive.Checked;

            Models.Settings.Save();

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Models.Settings.Load();
            
            checkBoxSaveLastProfile.Checked = Models.Settings.SaveLastProfile;
            checkBoxSavePreviousFileNames.Checked = Models.Settings.SavePreviousFileNames;
            checkBoxWarnBeforeRecursive.Checked = Models.Settings.WarnBeforeRecursiveRename;

            checkBoxEnableContextMenu.Checked = Models.Settings.IsContextMenuEnabled();
        }
    }
}
