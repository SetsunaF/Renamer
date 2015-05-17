using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DropdownButton;
using Renamer.Common;
using Renamer.Models;

namespace Renamer.Windows
{
    public partial class FilterSelector : Form
    {
        public FilterMenuItem[] basicFilters = {
                                                    new FilterMenuItem("Clear", FilterType.Clear),
                                                    new FilterMenuItem("Append Before", FilterType.AppendBefore),
                                                    new FilterMenuItem("Append After", FilterType.AppendAfter),
                                                    new FilterMenuItem("Append at Position", FilterType.AppendAtPosition),
                                                    new FilterMenuItem("Append from Text File", FilterType.AppendFromTextFile),
                                                    new FilterMenuItem("Capitalize each Word", FilterType.CapitalizeEachWord),
                                                    new FilterMenuItem("Upper Case", FilterType.UpperCase),
                                                    new FilterMenuItem("Lower Case", FilterType.LowerCase),
                                                    new FilterMenuItem("Sentence Case", FilterType.SentenceCase)
                                                };

        public FilterMenuItem[] numberingFilters = {
                                                        new FilterMenuItem("Add Numbering", FilterType.AddNumbering),
                                                        new FilterMenuItem("Add Numbering (By Directory)", FilterType.NumberByDirectories),
                                                        new FilterMenuItem("Add Numbering (Swap Order)", FilterType.SwapOrder)
                                                    };

        public FilterMenuItem[] trimFilters = {
                                                    new FilterMenuItem("Keep Numeric Characters", FilterType.KeepNumeric),
                                                    new FilterMenuItem("Keep Alphanumeric Characters", FilterType.KeepAlphanumeric),
                                                    new FilterMenuItem("Remove Invalid Characters", FilterType.RemoveInvalidCharacters),
                                                    new FilterMenuItem("Preserve from Left", FilterType.PreserveFromLeft),
                                                    new FilterMenuItem("Preserve from Right", FilterType.PreserveFromRight),
                                                    new FilterMenuItem("Trim from Left", FilterType.TrimFromLeft),
                                                    new FilterMenuItem("Trim from Right", FilterType.TrimFromRight)
                                              };

        public FilterMenuItem[] matchFilters = {
                                                    new FilterMenuItem("Regex Match", FilterType.Regex),
                                                    new FilterMenuItem("Regex Replace", FilterType.RegexReplace),
                                                    new FilterMenuItem("Replace String", FilterType.ReplaceString),
                                                    new FilterMenuItem("Replace String (Case Insensitive)", FilterType.ReplaceCaseInsensitive)
                                        };

        public FilterMenuItem[] fileFilters = {
                                                  new FilterMenuItem("Parent Directory", FilterType.ParentDirectory),
                                                  new FilterMenuItem("Original File Name", FilterType.OriginalFileName),
                                                  new FilterMenuItem("Add Extension", FilterType.AddExtension),
                                                  new FilterMenuItem("Remove Extension", FilterType.RemoveExtension)
                                              };

        public FilterSelector(Form parent)
        {
            InitializeComponent();

            this.Owner = parent;
            //this.Width = this.Owner.Width - 32;
            //this.Height = this.Owner.Height - 94;
            this.Width = 600;
            this.Height = 340;
        }

        private void FilterSelector_Load(object sender, EventArgs e)
        {
            //Caculate window size
            var rectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = rectangle.Top - this.Top;
            this.Top = this.Owner.Top + titleHeight + 12;

            //Set minimum size
            this.MinimumSize = this.Size;

            //Configure object list view selector
            olvSelector.Dock = DockStyle.Fill;

            olvSelector.CellPadding = new Rectangle(
                new Point(2, 0),
                new Size(0, 0)
            );

            //Set flat button events
            foreach (FlatButton button in panelTabs.Controls)
            {
                button.Click += OnMouseEnter;
                button.MouseEnter += OnMouseEnter;
            }

            OnMouseEnter(flatButton1, null);
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            var button = sender as FlatButton;

            if (button.Style == Styles.Primary) return;

            ShowFilters(button.Tag);
            button.Style = Styles.Primary;
        }

        private void ShowFilters(object tag)
        {
            foreach (FlatButton button in panelTabs.Controls) button.Style = Styles.Default;

            var arrayName = tag.ToString();
            var array = (FilterMenuItem[])this.GetType().GetField(arrayName).GetValue(this);

            olvSelector.Items.Clear();
            olvSelector.SetObjects(array);
        }

        private void olvSelector_MouseEnter(object sender, EventArgs e)
        {
            olvSelector.Focus();
        }        

        private void FilterSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void olvSelector_Click(object sender, EventArgs e)
        {
            if (olvSelector.SelectedObjects.Count == 0) return;
            this.Hide();

            var mainForm = ((Main)this.Owner);
            var filterType = (olvSelector.SelectedObject as FilterMenuItem).type;

            switch (filterType)
            {

            }

            this.Close();
        }
    }

    public class FilterMenuItem
    {
        public string name;
        public FilterType type;

        public FilterMenuItem(string name, FilterType type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
