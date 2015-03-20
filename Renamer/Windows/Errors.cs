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
    public partial class Errors : Form
    {
        public Errors()
        {
            InitializeComponent();
        }

        public Errors(string title, string prompt, List<string[]> messages)
        {
            InitializeComponent();

            this.Text = title;
            labelError.Text = prompt;
            textMessage.Text = FormatMessages(messages);
        }        

        //format list of arrays, each array contains [file name, error message]
        private string FormatMessages(List<string[]> messages)
        {
            string m = "";

            foreach(var message in messages)
                m += message[0] + "\r\n" + message[1] + "\r\n\r\n";

            return m.Substring(0, m.Length-4);
        }

        private void ErrorList_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
