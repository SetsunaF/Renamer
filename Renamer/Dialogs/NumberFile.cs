using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
