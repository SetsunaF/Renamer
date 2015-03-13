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
    public partial class String : BaseDialog
    {
        public String()
        {
            InitializeComponent();
        }

        public String(string title, string prompt, Form parent=null)
        {
            InitializeComponent();

            this.Text = title;
            labelText.Text = prompt;

            this.Owner = parent;
        }
    }
}
