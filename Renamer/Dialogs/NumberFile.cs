using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer.Dialogs
{
    public partial class NumberFile : BaseDialog
    {
        public OpenFileDialog fileDialog;
        public ModernFolderBrowserDialog.FolderBrowser folderDialog;
        private bool directoryMode;

        public NumberFile()
        {
            InitializeComponent();

            fileDialog = new OpenFileDialog();
            folderDialog = new ModernFolderBrowserDialog.FolderBrowser(Models.Settings.IsUnderWine);
            directoryMode = false;
        }

        public NumberFile(string title, string prompt1, string prompt2, Form parent, bool directoryMode = false)
        {
            InitializeComponent();

            fileDialog = new OpenFileDialog();
            folderDialog = new ModernFolderBrowserDialog.FolderBrowser(Models.Settings.IsUnderWine);
            this.directoryMode = directoryMode;

            this.Text = title;
            labelNumber.Text = prompt1;
            labelFile.Text = prompt2;

            this.Owner = parent;
        }        

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (directoryMode)
            {
                if (folderDialog.ShowDialog() == DialogResult.OK) inputFile.Text = folderDialog.SelectedPath;
            }
            else
            {
                if (fileDialog.ShowDialog() == DialogResult.OK) inputFile.Text = fileDialog.FileName;
            }            
        }

        private void inputFile_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (!directoryMode)
            {
                if (Path.GetExtension(paths[0]).ToLower() != ".txt") return;
            }

            var attr = File.GetAttributes(paths[0]);            

            //Maybe this can be optimized but I have no time to make it and the inpact will be unnoticeable
            //And is easier to understand the code as it is
            if (directoryMode)
            {
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) inputFile.Text = paths[0];
            }
            else
            {
                if ((attr & FileAttributes.Directory) != FileAttributes.Directory) inputFile.Text = paths[0];
            }
        }

        private void inputFile_DragEnter(object sender, DragEventArgs e)
        {
            this.Activate();

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false)) e.Effect = DragDropEffects.All;            
            else e.Effect = DragDropEffects.None;
        }

        private void NumberFile_DragEnter(object sender, DragEventArgs e)
        {
            this.Activate();
        }

        

            
    }
}
