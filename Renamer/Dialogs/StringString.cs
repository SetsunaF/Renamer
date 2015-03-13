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
    public partial class StringString : BaseDialog
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

        private void StringString_Shown(object sender, EventArgs e)
        {
            if (inputText1.Text != "")
                inputText2.Focus();
        }
    }
}
