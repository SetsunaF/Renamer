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
    public partial class NumberNumber : BaseDialog
    {
        public NumberNumber()
        {
            InitializeComponent();
        }

        public NumberNumber(string title, string prompt1, string prompt2, Form parent)
        {
            InitializeComponent();

            this.Text = title;
            labelNumber1.Text = prompt1;
            labelNumber2.Text = prompt2;

            this.Owner = parent;
        }
    }
}
