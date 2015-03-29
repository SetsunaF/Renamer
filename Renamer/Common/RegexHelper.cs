using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace Renamer.Common
{
    public static class RegexHelper
    {
        private static List<string[]> data;

        private static bool Load()
        {
            string json;

            try
            {
                json = File.ReadAllText(Models.Settings.ApplicationDataPath + "\\RegexHelper.json");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Renamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                data = JsonConvert.DeserializeObject<List<string[]>>(json);
            }
            catch (JsonException e)
            {
                MessageBox.Show(e.Message, "Renamer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //public static void SetData(ContextMenuStrip menu, TextBox textBox, Action<object, EventArgs> onTextChange)
        public static void SetData(ContextMenuStrip menu, TextBox textBox)
        {
            if (!Load()) return;

            foreach (var pair in data)
            {
                if (pair.Length == 0) menu.Items.Add(new ToolStripSeparator());

                else
                {
                    var item = new ToolStripMenuItem(pair[0]);
                    var regex = pair[1];

                    item.Click += (sender, args) =>
                    {
                        //textBox.Text += regex;
                        //textBox.Focus();
                        //textBox.SelectionStart = textBox.Text.Length - regex.Length;

                        var selectionStart = textBox.SelectionStart;
                        if (textBox.SelectionLength > 0) selectionStart += textBox.SelectionLength;

                        textBox.Text = textBox.Text.Insert(selectionStart, regex);
                        textBox.Focus();
                        textBox.SelectionStart = selectionStart;
                        textBox.SelectionLength = regex.Length;

                        //onTextChange is triggered automatically
                        //onTextChange(null, null);                        
                    };

                    menu.Items.Add(item);
                }
            }
        }
    }
}
