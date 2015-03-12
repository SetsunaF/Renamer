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
    public partial class NumberFile : Form
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (inputFile.Text == "")
            {
                MessageBox.Show("Please choose a file before continue.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile.Text = fileDialog.FileName;
            }
        }

        private int initialHeight;

        private void NumberFile_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            initialHeight = this.Height;

            if (this.Owner.WindowState == FormWindowState.Maximized) this.Top = 10;
            else this.Top = this.Owner.Top + 10;
        }

        private void NumberFile_Resize(object sender, EventArgs e)
        {
            this.Height = initialHeight;
        }
    }
}
