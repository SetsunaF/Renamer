using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Controls;
using Renamer.Common;
using Renamer.Models;

namespace Renamer
{
    public partial class Main : Form
    {
        private string[] fileList=new string[0];

        private List<FileName> fileNames = new List<FileName>();
        private List<FileName> previousNames = new List<FileName>();

        private List<Filter> filterList = new List<Filter>();
        private ProfileManager profileManager;

        private List<string[]> errorList = new List<string[]>();

        public FilterEvaluator filterEvaluator;
        public FilterType selectedFilter;

        #region GUI

        public Main()
        {
            InitializeComponent();
            this.folderBrowser = new ModernFolderBrowserDialog.FolderBrowser(Models.Settings.IsUnderWine);
        }

        public Main(string defaultPath)
        {
            InitializeComponent();
            this.folderBrowser = new ModernFolderBrowserDialog.FolderBrowser(Models.Settings.IsUnderWine);

            if(Directory.Exists(defaultPath))
                textBoxInputDir.Text = defaultPath;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            Main_Resize(null, null);

            filterEvaluator = new FilterEvaluator(this);
            buttonAdd.Dialog = new Windows.FilterSelector(this);
            buttonAdd.onDialogCloseEvent = () => filterEvaluator.Evaluate(selectedFilter);

            olvPreview.CellPadding = new Rectangle(
                new Point(2, 0),
                new Size(0, 0)
            );

            //dropDownSort.SelectedIndex = 0;
            Settings.Load();

            profileManager = new ProfileManager(dropDownProfile);
            profileManager.PopulateProfiles();

            naturalSortToolStripMenuItem.Checked = true;
            //olvPreview.Columns[0].

            //Set colors to textBoxFilter
            SetFocusColor(textBoxFilter);

            //Load regex filters
            //RegexFilters.SetData(contextMenuRegex, textBoxFilter, textBoxFilter_TextChanged)
            RegexHelper.SetData(contextMenuRegex, textBoxFilter);

            //objectlistview.sourceforge.net/cs/dragdrop.html
            var dropSink = new BrightIdeasSoftware.SimpleDropSink()
            {
                CanDropOnItem = false,
                CanDropBetween = true,
                FeedbackColor = Color.LightGray
            };

            //var dropSink = new BrightIdeasSoftware.RearrangingDropSink(false) 
            //{
            //    FeedbackColor = Color.LightGray
            //};
            
            olvPreview.DropSink = dropSink;
        }

        private void SetFocusColor(TextBox textBox)
        {
            textBox.GotFocus += (sender, e) => { textBox.ForeColor = Color.Black; };
            textBox.LostFocus += (sender, e) => { textBox.ForeColor = Color.Gray; };
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            int width;

            if (olvPreview.Columns.Count == 2)
            {
                width = olvPreview.Width / 2 - 15;
                olvPreview.Columns[0].Width = width;
                olvPreview.Columns[1].Width = width;
            }

            //if (olvFilters.Columns.Count != 3) return;
            width = olvFilters.Width - olvFilters.Columns[1].Width - olvFilters.Columns[2].Width - 25;
            if (width > 0) olvFilters.Columns[0].Width = width;
        }

        private void buttonBrowseInput_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (folderBrowser.ShowDialog() != DialogResult.OK) return;

                if (folderBrowser.SelectedPath.StartsWith(Environment.GetEnvironmentVariable("windir")))
                    MessageBox.Show("The selected path is not allowed, please choose a different one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else break;
            }

            textBoxInputDir.Text = folderBrowser.SelectedPath;
        }        

        private void buttonBrowseOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() != DialogResult.OK) return;
            textBoxOutput.Text = folderBrowser.SelectedPath;
        }        

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            buttonRevert.Enabled = false;
            LoadFiles();
        }

        #endregion

        void SortFileList()
        {
            if (fileList.Length == 0) return;            

            switch (sortMethod)
            {                   
                case 0: //Natural
                    Array.Sort(fileList, new Common.Comparers.Natural());
                    break;

                case 1: //Natural Descending                     
                    Array.Sort(
                        fileList,
                        new Common.Comparers.Natural(Common.Comparers.NaturalComparerOptions.Default, Common.Comparers.NaturalComparerDirection.Descending)
                        );
                    break;

                case 2: //Alphanumerical
                    Array.Sort(fileList);
                    break;

                case 3: //Alphanumerical Descending
                    Array.Sort(fileList, new Common.Comparers.Descending());
                    break;
                //case 4: //Custom Sort
            }
        }

        void LoadFiles()
        {
            //if (!Directory.Exists(textBoxInputDir.Text)) return;
            if (textBoxInputDir.Text == "")
            {
                fileList=new string[0];

                //these are the same three lines inside ApplyFileNameFilter()
                //but they're never reached if the input dir is empty
                textBoxFilter.BackColor = SystemColors.Window;
                if (!StringFunctions.ValidPattern(textBoxFilter.Text))
                    textBoxFilter.BackColor = Color.MistyRose;

                return;
            }

            //Get files from specified path, it's necessary to sort them because GetFiles() returns an unsorted array on network drives            
            //Sometimes user deletes/renames the directory and after pressing the refresh button will give an error
            try { fileList = Directory.GetFiles(textBoxInputDir.Text); }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxInputDir.Clear();
                RefreshUI();
                return;
            }

            //Get files recursively
            if (checkBoxRecursive.Checked)
            {
                var files = new List<string>();
                var directories = Directory.GetDirectories(textBoxInputDir.Text);

                foreach (var dir in directories)
                {
                    string[] list = null;

                    try { list = Directory.GetFiles(dir); }
                    catch { }

                    if(list!=null) files.AddRange(list);
                }

                var tmp = new string[fileList.Length+files.Count];
                fileList.CopyTo(tmp,0);
                files.CopyTo(tmp, fileList.Length);

                fileList = tmp;
            }

            if (customSortToolStripMenuItem.Checked)
                OnSortMenuItemClick(naturalSortToolStripMenuItem, 0, true);
            
            RefreshUI();
        }

        void RefreshUI()
        {
            SortFileList();
            ApplyFileNameFilter();
            ApplyFiltersAndUpdate();

            totalFiles.Text = fileList.Length + " Files";
            filesFound.Text = fileNames.Count + " Files";

            panelDetails.Hide();
        }

        void ApplyFileNameFilter()
        {
            fileNames.Clear();
            textBoxFilter.BackColor = SystemColors.Window;

            if (textBoxFilter.Text.Length > 0)
            {
                foreach (var file in fileList)
                {
                    if (!StringFunctions.ValidPattern(textBoxFilter.Text))
                    {
                        textBoxFilter.BackColor = Color.MistyRose;
                        break;
                    }

                    string name = Path.GetFileName(file);

                    //if (name.ToLower().Contains(textBoxFilter.Text.ToLower()))
                    //    fileNames.Add(new FileName(Path.GetDirectoryName(file), name, name));

                    //Use RegEx match
                    if (name.RegexMatch(textBoxFilter.Text))
                        fileNames.Add(new FileName(Path.GetDirectoryName(file), name, name));

                }
            }
            else
            {
                foreach (var file in fileList)
                {
                    //Console.WriteLine(file);
                    string name = Path.GetFileName(file);
                    fileNames.Add(new FileName(Path.GetDirectoryName(file), name, name));
                }
            }
        }

        void ApplyFilterList(List<Filter> list)
        {
            for (int i = 0; i < fileNames.Count; i++)
            {
                fileNames[i].Reset();

                foreach (var filter in list)
                {
                    fileNames[i].Modified = filter.ApplyTo(fileNames[i], i, fileNames.Count);
                }
            }
        }

        void PreviewFilter(FilterType type, object x = null, object y = null)
        {
            var temp = new List<Filter>(filterList);
            temp.Add(new Filter(type, x, y));

            ApplyFilterList(temp);

            olvPreview.SetObjects(fileNames);
        }

        void ApplyFiltersAndUpdate(bool preserveSelectedIndex=true)
        {
            ScrollDownFilters();
            ApplyFilterList(filterList);

            if (preserveSelectedIndex)
                olvIndex = olvPreview.SelectedIndex;
            
            olvPreview.SetObjects(fileNames);

            if (olvPreview.Items.Count > 0)
            {
                olvPreview.SelectedIndex = olvIndex;
                olvIndex = 0;
            }
        }

        //Make last element from filters preview visible
        void ScrollDownFilters()
        {
            if (olvFilters.Items.Count > 0)
            {
                int lastIndex = olvFilters.Items.Count - 1;
                olvFilters.Items[lastIndex].EnsureVisible();
                olvFilters.SelectedIndex = lastIndex;
            }
        }

        #region Filter Dialogs

        //Only for filters without arguments
        public void ApplySimpleFilter(FilterType filterType)
        {
            filterList.Add(new Filter(filterType));
            olvFilters.SetObjects(filterList);

            ApplyFiltersAndUpdate();
        }

        void AddFilter(Filter filter)
        {
            filterList.Add(filter);
            olvFilters.SetObjects(filterList);
        }

        void ResetNumericUpDown(NumericUpDown numericUpDown)
        {
            numericUpDown.Value = 0;
            numericUpDown.Minimum = 0;
        }

        //Evaluate dialog for Filters with 1 numeric argument (the blue rows on the excel file)
        public void EvalDialog_Num(string title, string prompt, FilterType filterType)
        {
            using (var dlg = new Dialogs.Number(title, prompt, this))
            {
                dlg.inputNumber.ValueChanged += (o, args) => PreviewFilter(filterType, dlg.inputNumber.Value);

                ResetNumericUpDown(dlg.inputNumber);

                if (dlg.ShowDialog() == DialogResult.OK)
                    AddFilter(new Filter(filterType, dlg.inputNumber.Value));

                ApplyFiltersAndUpdate();
            }
        }

        //Evaluate dialog for Filters with 2 numeric arguments
        public void EvalDialog_Num_Num(string title, string prompt1, string prompt2, FilterType filterType)
        {
            using (var dlg = new Dialogs.NumberNumber(title, prompt1, prompt2, this))
            {
                dlg.inputNumber1.ValueChanged += (o, args) => PreviewFilter(filterType, dlg.inputNumber1.Value, dlg.inputNumber2.Value);
                dlg.inputNumber2.ValueChanged += (o, args) => PreviewFilter(filterType, dlg.inputNumber1.Value, dlg.inputNumber2.Value);

                ResetNumericUpDown(dlg.inputNumber1);
                ResetNumericUpDown(dlg.inputNumber2);

                if (dlg.ShowDialog() == DialogResult.OK)
                    AddFilter(new Filter(filterType, dlg.inputNumber1.Value, dlg.inputNumber2.Value));

                ApplyFiltersAndUpdate();
            }
        }

        //Evaluate dialog for Filters with 1 string argument (the purple rows on the excel file)
        public void EvalDialog_Str(string title, string prompt, FilterType filterType)
        {
            using (var dlg = new Dialogs.String(title, prompt, this))
            {
                dlg.inputText.TextChanged += (o, args) => PreviewFilter(filterType, dlg.inputText.Text);

                if (dlg.ShowDialog() == DialogResult.OK)
                    AddFilter(new Filter(filterType, dlg.inputText.Text));

                ApplyFiltersAndUpdate();
            }
        }

        //Evaluate dialog for Filters with 2 string arguments (the cyan rows on the excel file)
        public void EvalDialog_Str_Str(string title, string prompt1, string prompt2, FilterType filterType, string searchString = null)
        {
            using (var dlg = new Dialogs.StringString(title, prompt1, prompt2, this))
            {
                dlg.inputText1.TextChanged += (sender, args) => PreviewFilter(filterType, dlg.inputText1.Text, dlg.inputText2.Text);
                dlg.inputText2.TextChanged += (sender, args) => PreviewFilter(filterType, dlg.inputText1.Text, dlg.inputText2.Text);

                if (searchString != null)
                {
                    dlg.inputText1.Text = searchString;
                    dlg.inputText2.Text = searchString;
                }

                if (dlg.ShowDialog() == DialogResult.OK)
                    AddFilter(new Filter(filterType, dlg.inputText1.Text, dlg.inputText2.Text));

                ApplyFiltersAndUpdate();
            }
        }

        #endregion

        #region Menu Items

        public void appendAtPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new Dialogs.NumberString("Append at Position", "Position:", "Text:", this))
            {
                dlg.inputNumber.ValueChanged += (o, args) => PreviewFilter(FilterType.AppendAtPosition, dlg.inputText.Text, dlg.inputNumber.Value);
                dlg.inputText.TextChanged += (o, args) => PreviewFilter(FilterType.AppendAtPosition, dlg.inputText.Text, dlg.inputNumber.Value);

                if (dlg.ShowDialog() == DialogResult.OK)
                    AddFilter(new Filter(FilterType.AppendAtPosition, dlg.inputText.Text, dlg.inputNumber.Value));

                ApplyFiltersAndUpdate();
            }
        }

        public void appendFromTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new Dialogs.NumberFile("Append from Text File", "Position:", "Text File:", this))
            {
                dlg.fileDialog.Filter = @"Text Files (*.txt)|*.txt|All Files|*.*";
                dlg.inputNumber.ValueChanged += (o, args) => PreviewFilter(FilterType.AppendFromTextFile, dlg.inputFile.Text, dlg.inputNumber.Value);
                dlg.inputFile.TextChanged += (o, args) => PreviewFilter(FilterType.AppendFromTextFile, dlg.inputFile.Text, dlg.inputNumber.Value);

                if (dlg.ShowDialog() == DialogResult.OK)
                    AddFilter(new Filter(FilterType.AppendFromTextFile, dlg.inputFile.Text, dlg.inputNumber.Value));

                ApplyFiltersAndUpdate();
            }
        }        

        #endregion

        #region Buttons

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Duplicate selected filter
            if (filterList.Count > 0)
            {
                AddFilter(filterList[olvFilters.SelectedIndex]);
                ApplyFiltersAndUpdate();
            }
            else buttonAdd.Expand();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Delete selected filter
            if (filterList.Count > 0 && olvFilters.SelectedIndices.Count == 1)
            {
                filterList.RemoveAt(olvFilters.SelectedIndex);

                olvFilters.SetObjects(filterList);
                ApplyFiltersAndUpdate();

                if (filterList.Count > 0)
                {
                    olvFilters.SelectedIndex = filterList.Count - 1;
                }
            }
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDelete_Click(null, null);
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterList.Clear();

            olvFilters.SetObjects(filterList);
            ApplyFiltersAndUpdate();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (filterList.Count > 1 && olvFilters.SelectedIndices.Count == 1)
            {
                int index = olvFilters.SelectedIndex;
                var filter = filterList[index];
                if (index > 0)
                {
                    filterList.RemoveAt(index);
                    index--;
                    filterList.Insert(index, filter);

                    olvFilters.SetObjects(filterList);
                    ApplyFiltersAndUpdate();

                    olvFilters.SelectedIndex = index;
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (filterList.Count > 1 && olvFilters.SelectedIndices.Count == 1)
            {
                int index = olvFilters.SelectedIndex;
                var filter = filterList[index];
                if (index < filterList.Count - 1)
                {
                    filterList.RemoveAt(index);
                    index++;
                    filterList.Insert(index, filter);

                    olvFilters.SetObjects(filterList);
                    ApplyFiltersAndUpdate();

                    olvFilters.SelectedIndex = index;
                }
            }
        }               

        #endregion

        #region Profile Methods

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dropDownProfile.SelectedIndex == -1) saveAsToolStripMenuItem_Click(null, null);
            else profileManager.Update(filterList);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSave_Click(null, null);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new Dialogs.String("Save Profile", "Name:");
            var result = dlg.ShowDialog();

            while (true)
            {
                //If user pressed OK button
                if (result == DialogResult.OK)
                {
                    //If profile was saved successfully
                    if (profileManager.AddProfile(new Profile(dlg.inputText.Text, filterList)))
                    {
                        break;
                    }
                }

                //If user pressed Cancel button
                if (result == DialogResult.Cancel) break;

                result = dlg.ShowDialog();
            }


            //if (dlg.ShowDialog() == DialogResult.OK)
            //    profileManager.AddProfile(new Profile(dlg.inputText.Text, filterList));
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dropDownProfile.SelectedIndex == -1) return;

            var dlg = new Dialogs.String("Rename Profile", "Name:");
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.inputText.Text == "") return;

                profileManager.DeleteSelected(); 
                profileManager.AddProfile(new Profile(dlg.inputText.Text, filterList));
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dropDownProfile.SelectedIndex == -1) return;

            var result = MessageBox.Show("Are you sure you want to delete the selected profile?", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                profileManager.DeleteSelected(); 
        }

        private void dropDownProfile_SelectedIndexChanged(object sender, EventArgs e)
        {            
            profileManager.AssignProfile(out filterList);

            olvFilters.SetObjects(filterList);
            ApplyFiltersAndUpdate();
        }

        #endregion

        private void olvPreview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            var current = (FileName)e.Model;
            if (!current.IsValidName())
                e.Item.BackColor = Color.FromArgb(255, 41, 56);
        }

        #region Rename and Revert Buttons

        void FileRename(FileName name)
        {
            try
            {
                //move here
                if (textBoxInputDir.Text == textBoxOutput.Text) File.Move(name.FullPath(), name.FullPathModified());
                //copy if directories are different
                else File.Copy(name.FullPath(), name.FullPathModified(textBoxOutput.Text));
            }
            catch (Exception ex)
            {
                errorList.Add(new string[] { name.Modified, ex.Message });
            }
        }

        void Rename()
        {
            errorList.Clear();

            using (var dlg = new Windows.Progress("Rename in Progress..."))
            {
                //stackoverflow.com/questions/661561/how-to-update-the-gui-from-another-thread-in-c?rq=1
                //never use a loop inside a method invoker

                dlg.bgWorker.DoWork += (o, args) =>
                {
                    double step = 100.0 / fileNames.Count;
                    double sum = 0;

                    foreach (var name in fileNames)
                    {
                        while (dlg.pauseWork)
                        {
                            System.Threading.Thread.Sleep(100);
                        }

                        if (dlg.wantToCancel) break;

                        this.Invoke((MethodInvoker)delegate
                        {
                            dlg.labelCurrent.Text = name.Modified;
                            FileRename(name);

                            sum += step;
                            dlg.barProgress.Value = (int)sum;
                        });
                    }

                    this.Invoke((MethodInvoker)delegate
                    {
                        dlg.barProgress.Value = 100;
                        dlg.wantToCancel = true;
                        dlg.Close();

                        if (errorList.Count > 0)
                        {
                            using (var errorDlg = new Windows.Errors("Error", "Cannot rename some files, please review the errors below", errorList))
                            {
                                errorDlg.ShowDialog();
                            }
                        }
                    });

                    //if input and output directories are the same, reload files
                    if (textBoxInputDir.Text == textBoxOutput.Text)
                    {
                        this.Invoke((MethodInvoker)LoadFiles);
                    }
                };

                dlg.bgWorker.RunWorkerAsync();
                dlg.ShowDialog();
            }
        }

        void BackupFileNames()
        {
            previousNames.Clear();

            foreach (var name in fileNames)
                previousNames.Add(new FileName(name, true));

            if (textBoxInputDir.Text == textBoxOutput.Text)
                buttonRevert.Enabled = true;
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            if (textBoxInputDir.Text == "" || textBoxOutput.Text == "") return;
            if (fileNames.Count == 0 || filterList.Count == 0) return;

            bool allNamesAreValid = fileNames.All(name => name.IsValidName());
            if (allNamesAreValid)
            {
                bool allNamesAreUnique = fileNames.Select(x => x.Modified).Count() ==
                                         fileNames.Select(x => x.Modified).Distinct().Count();

                if (!allNamesAreUnique)
                {
                    var result = MessageBox.Show("The file names must be unique, are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) return;
                }

                if (textBoxInputDir.Text != textBoxOutput.Text)
                {
                    var result=MessageBox.Show("Since the input and output directories are different, this operation could take several minutes. Are you sure you want to continue?", "Different Directories", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;
                }

                if (checkBoxRecursive.Checked && Settings.WarnBeforeRecursiveRename)
                {
                    var result = MessageBox.Show("Please make sure there are not additional files in the list, are you sure you want to continue?", "Recursive Rename", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) return;
                }

                BackupFileNames();
                Rename();
            }
            else MessageBox.Show("Some file names are not valid, please correct them before continue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            buttonRevert.Enabled = false;
            fileNames = new List<FileName>(previousNames);
            Rename();
        }

        #endregion

        #region Drag and Drop
        //Drag and drop folders
        //stackoverflow.com/questions/7189779/drag-and-drop-a-folder-from-windows-explorer-to-listbox-in-c-sharp
        //stackoverflow.com/questions/1395205/better-way-to-check-if-path-is-a-file-or-a-directory

        private void textBox_DragEnter(object sender, DragEventArgs e)
        {
            this.Activate();

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else e.Effect = DragDropEffects.None;
        }

        private string GetFirstPath(DragEventArgs e)
        {
            var paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var attr = File.GetAttributes(paths[0]);

            if ((attr & FileAttributes.Directory) == FileAttributes.Directory) return paths[0];
            return "";
        }

        private void textBoxInputDir_DragDrop(object sender, DragEventArgs e)
        {            
            string path = GetFirstPath(e);
            if (path != "") textBoxInputDir.Text = path;            
        }

        private void textBoxOutput_DragDrop(object sender, DragEventArgs e)
        {
            string path = GetFirstPath(e);

            if (path != "")
            {
                textBoxOutput.Text = path;
                checkBoxCopy.Checked = true;
            }
        }

        #endregion

        private void dropDownSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileList == null || fileNames.Count == 0) return;

            SortFileList();
            ApplyFileNameFilter();
            ApplyFiltersAndUpdate();
        }

        /*
         * 0: Natural
         * 1: Natural Descending
         * 2: Alphanumerical
         * 3: Alphanumerical Descending
         */
        byte sortMethod = 0;
                
        void UncheckSortMenuItems()
        {
            naturalSortToolStripMenuItem.Checked = false;
            naturalDescendingSortToolStripMenuItem.Checked = false;
            alphanumericalSortToolStripMenuItem.Checked = false;
            alphanumericalDescendingSortToolStripMenuItem.Checked = false;
            customSortToolStripMenuItem.Checked = false;
        }

        /*
         * sender: The menu item
         * method: Sort method, see above
         */
        void OnSortMenuItemClick(object sender, byte method, bool reset=false)
        {
            UncheckSortMenuItems();
            var thisItem = sender as ToolStripMenuItem;
            thisItem.Checked = true;

            sortMethod = method;

            if (reset) return;
            if (fileList == null || fileNames.Count == 0) return;

            SortFileList();

            ApplyFileNameFilter();
            ApplyFiltersAndUpdate(false);
        }

        private void naturalSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSortMenuItemClick(sender, 0);
        }

        private void naturalDescendingSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSortMenuItemClick(sender, 1);
        }

        private void alphanumericalSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSortMenuItemClick(sender, 2);
        }

        private void alphanumericalDescendingSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSortMenuItemClick(sender, 3);
        }
        
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBoxFilter_TextChanged(null, null);
        }

        private void buttonRegex_Click(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            textBoxFilter.Focus();
        }

        private void olvPreview_DoubleClick(object sender, EventArgs e)
        {            
            var fn = (FileName)olvPreview.SelectedObject;
            EvalDialog_Str_Str("Replace String", "Search String:", "Replace String:", FilterType.ReplaceString, fn.Modified);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Windows.About().ShowDialog();
        }

        //private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    string data = "";

        //    foreach (var row in olvPreview.Objects)
        //        data += (row as FileName).Original + "\r\n";            

        //    Clipboard.SetText(data);
        //}

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olvPreview_DoubleClick(null, null);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fn = (FileName)olvPreview.SelectedObject;
            Clipboard.SetText(fn.Original + "\t" + fn.Modified);
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.IsUnderWine)
            {
                buttonMediaInfo_Click(null, null);
                return;
            }

            var fn = (FileName)olvPreview.SelectedObject;
            FileProperties.Show(fn.FullPath());
        }        

        private void contextMenuProperties_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (olvPreview.Items.Count == 0 || olvPreview.SelectedObjects.Count == 0 || !showPropertiesMenu)
            {
                e.Cancel = true;
                showPropertiesMenu = true;
            }
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            buttonRevert.Enabled = false;
        }        

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            this.Activate();
        }

        private void textBoxInputDir_TextChanged(object sender, EventArgs e)
        {
            buttonRevert.Enabled = false;
            if (!checkBoxCopy.Checked) textBoxOutput.Text = textBoxInputDir.Text;
            LoadFiles();
        }

        private bool showPropertiesMenu = true;

        private void olvPreview_ColumnRightClick(object sender, ColumnClickEventArgs e)
        {
            showPropertiesMenu = false;
            if (e.Column == 0) contextMenuSort.Show(Cursor.Position);            
        }

        private void checkBoxCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                textBoxOutput.Text = textBoxInputDir.Text;
                buttonBrowseOutput.Enabled = false;
            }
            else
            {                
                buttonBrowseOutput.Enabled = true;
                checkBoxRecursive.Checked = false;
            }
        }

        private void checkBoxRecursive_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) checkBoxCopy.Checked = false;

            if (textBoxInputDir.Text == "") return;            
            buttonRevert.Enabled = false;
            LoadFiles();            
        }

        private void olvPreview_Scroll(object sender, ScrollEventArgs e)
        {
            contextMenuProperties.Close();
        }

        //For some reason this event is working better than ItemMouseHover
        private void olvPreview_MouseMove(object sender, MouseEventArgs e)
        {
            var item = olvPreview.GetItemAt(e.X, e.Y);
            var info = olvPreview.HitTest(e.X, e.Y);

            if ((item != null) && (info.SubItem != null))
            {                
                var obj = (FileName)olvPreview.GetItem(item.Index).RowObject;
                item.ToolTipText = obj.ParentDirectory() + @"\" + obj.Original;
            }
        }        

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Settings.SaveLastProfile)
                profileManager.SaveLastProfile(filterList);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start((olvPreview.SelectedObject as FileName).FullPath());
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            textBoxInputDir.Clear();
            textBoxFilter.Clear();  
          
            checkBoxCopy.Checked = false;
            checkBoxRecursive.Checked = false;

            profileManager.SaveLastProfile(filterList);
            dropDownProfile.SelectedIndex = -1;

            RefreshUI();
        }        

        private void olvPreview_SelectionChanged(object sender, EventArgs e)
        {
            ShowDetails(olvPreview.SelectedObject as FileName);
        }

        void ShowDetails(FileName fn)
        {
            if (fn != null)
            {
                dateCreated.Text = fn.CreationDate();
                dateModified.Text = fn.LastWriteDate();
                fileSize.Text = fn.ReadableFileSize();
                //fileSize.Text = fn.Original;

                panelDetails.Show();
            }
            else panelDetails.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new Windows.Settings())
            {
                dlg.ShowDialog();
            }
        }

        private void buttonMediaInfo_Click(object sender, EventArgs e)
        {
            var fn = olvPreview.SelectedObject as FileName;
            if (fn == null) return;

            using (var info = new Windows.MediaInfo(fn))
            {
                info.ShowDialog();
            }
        }               

        private void olvPreview_ModelCanDrop(object sender, BrightIdeasSoftware.ModelDropEventArgs e)
        {
            var fn = e.TargetModel as FileName;
            if (fn != null) e.Effect = DragDropEffects.Move;
            
            ShowDetails(e.SourceModels[0] as FileName);            
        }

        int olvIndex = 0;

        private void MoveSelected(int targetIndex, BrightIdeasSoftware.DropTargetLocation targetLocation)
        {
            //buttonRename.Text = e.DropTargetLocation.ToString();

            if (targetIndex == -1) return;
            if (olvPreview.SelectedIndex == targetIndex) return;

            //olvPreview.LowLevelScroll(0, 20);
            var tmp = new List<string>(fileList);

            if (olvPreview.SelectedIndex > targetIndex)
            {
                tmp.RemoveAt(olvPreview.SelectedIndex);
                tmp.Insert(targetIndex, fileList[olvPreview.SelectedIndex]);
                olvIndex = targetIndex;
            }

            else if (olvPreview.SelectedIndex < targetIndex)
            {
                if (targetLocation == BrightIdeasSoftware.DropTargetLocation.BelowItem) targetIndex++;

                tmp.Insert(targetIndex, fileList[olvPreview.SelectedIndex]);
                tmp.RemoveAt(olvPreview.SelectedIndex);
                olvIndex = targetIndex - 1;
            }

            fileList = tmp.ToArray();
            customSortToolStripMenuItem_Click(customSortToolStripMenuItem, null); 
        }

        private void olvPreview_ModelDropped(object sender, BrightIdeasSoftware.ModelDropEventArgs e)
        {
            MoveSelected(e.DropTargetIndex, e.DropTargetLocation);                 
        }

        private void customSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSortMenuItemClick(sender, 4);
        }

        private void excludeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tmp = new List<string>(fileList);

            tmp.RemoveAt(olvPreview.SelectedIndex);
            olvIndex=olvPreview.SelectedIndex;

            fileList = tmp.ToArray();
            customSortToolStripMenuItem_Click(customSortToolStripMenuItem, null);

            filesFound.Text = fileNames.Count + " Files";
            panelDetails.Hide();
        }

        private void moveToTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveSelected(0, BrightIdeasSoftware.DropTargetLocation.AboveItem);
            olvPreview.Items[0].EnsureVisible();
        }

        private void moveToBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = fileList.Length - 1;
            MoveSelected(index, BrightIdeasSoftware.DropTargetLocation.BelowItem);
            olvPreview.Items[index].EnsureVisible();
        }

        




        

                         

      

       

    
        












    }
}
