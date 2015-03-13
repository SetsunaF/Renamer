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
    public partial class NumberString : BaseDialog
    {
        public NumberString()
        {
            InitializeComponent();
        }

        public NumberString(string title, string prompt1, string prompt2, Form parent)
        {
            InitializeComponent();

            this.Text = title;
            labelNumber.Text = prompt1;
            labelText.Text = prompt2;

            this.Owner = parent;
        }        
    }
}
