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
    public partial class Number : Form
    {
        public Number()
        {
            InitializeComponent();
        }

        public Number(string title, string prompt, Form parent)
        {
            InitializeComponent();
            this.Text = title;
            labelNumber.Text = prompt;

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

        private void Number_Load(object sender, EventArgs e)
        {
            if (this.Owner.WindowState == FormWindowState.Maximized) this.Top = 10;
            else this.Top = this.Owner.Top + 10;
        }
    }
}
