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
    public partial class BaseDialog : Form
    {
        public BaseDialog()
        {
            InitializeComponent();
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

        private void BaseDialog_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            this.MinimumSize = this.Size;
            this.MaximumSize = new Size(SystemInformation.VirtualScreen.Width, this.Height); //new Size(int.MaxValue, this.Height);

            if (this.Owner != null)
            {
                if (this.Owner.WindowState == FormWindowState.Maximized) this.Top = 10;
                else this.Top = this.Owner.Top + 10;
            }
        }
    }
}
