using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Renamer.Windows
{
    public partial class MediaInfo : Form
    {
        public MediaInfo()
        {
            InitializeComponent();
        }

        public MediaInfo(string filePath)
        {
            InitializeComponent();

            string result;

            if (IntPtr.Size == 4)
            {
                var MI = new MediaInfoLib.MediaInfo();

                MI.Open(filePath);
                MI.Option("Complete");
                result = MI.Inform();
                MI.Close();                  
            }
            else
            {
                var MI = new MediaInfoLib.MediaInfo64();

                MI.Open(filePath);
                MI.Option("Complete");
                result = MI.Inform();
                MI.Close();  
            }

            var sp = result
                    .TrimEnd(new char[] { '\r', '\n' })
                    .Split(new string[] { "\r\n" }, StringSplitOptions.None);

            TreeNode root = null;

            foreach (var s in sp)
            {
                if (root == null)
                {
                    root = new TreeNode(s);
                    treeViewInfo.Nodes.Add(root);
                }
                else
                {
                    if (s == "") root = null;
                    else root.Nodes.Add(new TreeNode(Regex.Replace(s, "\\s{2,}", "")));
                }
            }

            treeViewInfo.ExpandAll();
        }



    }
}
