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
        public NumberFile()
        {
            InitializeComponent();
        }

        public NumberFile(string title, string prompt1, string prompt2, Form parent)
        {
            InitializeComponent();

            this.Text = title;
            labelNumber.Text = prompt1;
            labelFile.Text = prompt2;

            this.Owner = parent;
        }        

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile.Text = fileDialog.FileName;
            }
        }

        private void inputFile_DragDrop(object sender, DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var attr = File.GetAttributes(paths[0]);

            if ((attr & FileAttributes.Directory) != FileAttributes.Directory)
            {
                inputFile.Text = paths[0];
            }
        }

        private void inputFile_DragEnter(object sender, DragEventArgs e)
        {
            this.Activate();

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else e.Effect = DragDropEffects.None;
        }

        private void NumberFile_DragEnter(object sender, DragEventArgs e)
        {
            this.Activate();
        }

            
    }
}
