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
    public partial class Number : BaseDialog
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
    }
}
