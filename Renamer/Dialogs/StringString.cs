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
    public partial class StringString : Form
    {
        public StringString()
        {
            InitializeComponent();
        }

        public StringString(string title, string prompt1, string prompt2, Form parent)
        {
            InitializeComponent();
            this.Text = title;
            labelText1.Text = prompt1;
            labelText2.Text = prompt2;

            this.Owner = parent;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void StringString_Load(object sender, EventArgs e)
        {
            if (this.Owner.WindowState == FormWindowState.Maximized) this.Top = 10;
            else this.Top = this.Owner.Top + 10;
        }

        private void StringString_Shown(object sender, EventArgs e)
        {
            if (inputText1.Text != "")
                inputText2.Focus();
        }
    }
}
