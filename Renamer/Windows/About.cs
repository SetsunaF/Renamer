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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {            
            labelVersion.Text = GetVersion();
            labelYear.Text = "© " + RetrieveLinkerTimestamp().Year.ToString();
        }

        private string GetVersion()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        private DateTime RetrieveLinkerTimestamp()
        {
            string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;
            byte[] b = new byte[2048];
            System.IO.Stream s = null;

            try
            {
                s = new System.IO.FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                s.Read(b, 0, 2048);
            }
            finally
            {
                if (s != null)
                {
                    s.Close();
                }
            }

            int i = System.BitConverter.ToInt32(b, c_PeHeaderOffset);
            int secondsSince1970 = System.BitConverter.ToInt32(b, i + c_LinkerTimestampOffset);
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(secondsSince1970);
            dt = dt.ToLocalTime();
            return dt;
        }

        private void labelWebsite_Click(object sender, EventArgs e)
        {
            var url = (sender as Label).Text;
            if(url!="") System.Diagnostics.Process.Start(url);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
