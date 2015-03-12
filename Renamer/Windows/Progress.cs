using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Renamer.Windows
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        public Progress(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        public bool wantToCancel = false;

        private void ProgressWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wantToCancel) return;

            var result = MessageBox.Show("Are you sure you want to cancel the current operation?", "Cancel Operation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
                wantToCancel = true;

            if (wantToCancel) return;

            e.Cancel = true;
        }
    }
}
