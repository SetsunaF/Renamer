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
                                                        new FilterMenuItem("Add Numbering (Multiple)", FilterType.AddMultipleNumbering),
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
        }

        private void FilterSelector_Shown(object sender, EventArgs e)
        {
            //Enable first "tab" when form is shown
            OnMouseEnter(flatButton1, null);
        } 

        private void OnMouseEnter(object sender, EventArgs e)
        {
            var button = sender as FlatButton;

            if (e != null)
            {
                if (button.Style == Styles.Primary) return;
            }

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
                case FilterType.Clear:
                    mainForm.ApplySimpleFilter(FilterType.Clear);
                    break;

                case FilterType.AddNumbering:
                    mainForm.EvalDialog_Num("Add Numbering", "Position:", FilterType.AddNumbering);
                    break;

                case FilterType.NumberByDirectories:
                    mainForm.EvalDialog_Num("Number By Directories", "Position:", FilterType.NumberByDirectories);
                    break;

                case FilterType.AddMultipleNumbering:
                    mainForm.EvalDialog_Num_Num("Add Numbering (Multiple)", "Position:", "Numbers:", FilterType.AddMultipleNumbering);
                    break;

                case FilterType.SwapOrder:
                    mainForm.EvalDialog_Num("Swap Order", "Position:", FilterType.SwapOrder);
                    break;

                case FilterType.AppendBefore:
                    mainForm.EvalDialog_Str("Append Before", "Text:", FilterType.AppendBefore);
                    break;

                case FilterType.AppendAfter:
                    mainForm.EvalDialog_Str("Append After", "Text:", FilterType.AppendAfter);
                    break;

                case FilterType.AppendAtPosition:
                    mainForm.appendAtPositionToolStripMenuItem_Click(null, null);
                    break;

                case FilterType.AppendFromTextFile:
                    mainForm.appendFromTextFileToolStripMenuItem_Click(null, null);
                    break;

                case FilterType.KeepNumeric:
                    mainForm.ApplySimpleFilter(FilterType.KeepNumeric);
                    break;

                case FilterType.KeepAlphanumeric:
                    mainForm.ApplySimpleFilter(FilterType.KeepAlphanumeric);
                    break;

                case FilterType.RemoveInvalidCharacters:
                    mainForm.ApplySimpleFilter(FilterType.RemoveInvalidCharacters);
                    break;

                case FilterType.PreserveFromLeft:
                    mainForm.EvalDialog_Num("Preserve from Left", "Count:", FilterType.PreserveFromLeft);
                    break;

                case FilterType.PreserveFromRight:
                    mainForm.EvalDialog_Num("Preserve from Right", "Count:", FilterType.PreserveFromRight);
                    break;

                case FilterType.TrimFromLeft:
                    mainForm.EvalDialog_Num("Trim from Left", "Count:", FilterType.TrimFromLeft);
                    break;

                case FilterType.TrimFromRight:
                    mainForm.EvalDialog_Num("Trim from Right", "Count:", FilterType.TrimFromRight);
                    break;

                case FilterType.CapitalizeEachWord:
                    mainForm.ApplySimpleFilter(FilterType.CapitalizeEachWord);
                    break;

                case FilterType.UpperCase:
                    mainForm.ApplySimpleFilter(FilterType.UpperCase);
                    break;

                case FilterType.LowerCase:
                    mainForm.ApplySimpleFilter(FilterType.LowerCase);
                    break;

                case FilterType.SentenceCase:
                    mainForm.ApplySimpleFilter(FilterType.SentenceCase);
                    break;

                case FilterType.Regex:
                    mainForm.EvalDialog_Str("Regular Expression", "Expression:", FilterType.Regex);
                    break;

                case FilterType.RegexReplace:
                    mainForm.EvalDialog_Str_Str("Regex Replace", "Expression:", "Replace String:", FilterType.RegexReplace);
                    break;

                case FilterType.ReplaceString:
                    mainForm.EvalDialog_Str_Str("Replace String", "Search String:", "Replace String:", FilterType.ReplaceString);
                    break;

                case FilterType.ReplaceCaseInsensitive:
                    mainForm.EvalDialog_Str_Str("Replace String (Case Insensitive)", "Search String:", "Replace String:", FilterType.ReplaceCaseInsensitive);
                    break;

                case FilterType.AddExtension:
                    mainForm.ApplySimpleFilter(FilterType.AddExtension);
                    break;

                case FilterType.RemoveExtension:
                    mainForm.ApplySimpleFilter(FilterType.RemoveExtension);
                    break;

                case FilterType.ParentDirectory:
                    mainForm.EvalDialog_Num("Parent Directory", "Position:", FilterType.ParentDirectory);
                    break;

                case FilterType.OriginalFileName:
                    mainForm.EvalDialog_Num("Original Filename", "Position:", FilterType.OriginalFileName);
                    break;

            }

            this.Close();
        }                

        private void olvSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                olvSelector_Click(null, null);
            }
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
