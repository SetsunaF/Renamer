namespace Renamer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCopy = new System.Windows.Forms.CheckBox();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.buttonRegex = new DropdownButton.DropdownButton();
            this.contextMenuRegex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonRefresh = new System.Windows.Forms.PictureBox();
            this.filesFound = new MetroFramework.Controls.MetroLabel();
            this.totalFiles = new MetroFramework.Controls.MetroLabel();
            this.buttonBrowseOutput = new DropdownButton.FlatButton();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.buttonBrowseInput = new DropdownButton.FlatButton();
            this.textBoxInputDir = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new DropdownButton.DropdownButton();
            this.contextMenuDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new DropdownButton.DropdownButton();
            this.contextMenuAdd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNumberingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNumberingByDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swapOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.appendBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendAtPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendFromTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.extractNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepAlphanumericCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeInvalidCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.preserveFromLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preserveFromRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trimFromLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trimFromRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.capitalizeEachWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toUppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toSentenceCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.regularExpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regexReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceStringCaseInsensitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.parentDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalFileNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDown = new DropdownButton.FlatButton();
            this.buttonUp = new DropdownButton.FlatButton();
            this.buttonSave = new DropdownButton.DropdownButton();
            this.contextMenuSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownProfile = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.olvFilters = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuSort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.naturalSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalDescendingSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphanumericalSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphanumericalDescendingSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipProvider = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRevert = new DropdownButton.FlatButton();
            this.buttonRename = new DropdownButton.FlatButton();
            this.olvPreview = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuProperties = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowser = new ModernFolderBrowserDialog.FolderBrowser();
            this.buttonOptions = new DropdownButton.DropdownButton();
            this.contextMenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.buttonMediaInfo = new System.Windows.Forms.LinkLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.fileSize = new MetroFramework.Controls.MetroLabel();
            this.dateCreated = new MetroFramework.Controls.MetroLabel();
            this.dateModified = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRefresh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.contextMenuDelete.SuspendLayout();
            this.contextMenuAdd.SuspendLayout();
            this.contextMenuSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvFilters)).BeginInit();
            this.contextMenuSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPreview)).BeginInit();
            this.contextMenuProperties.SuspendLayout();
            this.contextMenuOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxCopy);
            this.groupBox1.Controls.Add(this.checkBoxRecursive);
            this.groupBox1.Controls.Add(this.buttonRegex);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.filesFound);
            this.groupBox1.Controls.Add(this.totalFiles);
            this.groupBox1.Controls.Add(this.buttonBrowseOutput);
            this.groupBox1.Controls.Add(this.textBoxOutput);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.textBoxFilter);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.buttonBrowseInput);
            this.groupBox1.Controls.Add(this.textBoxInputDir);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxCopy
            // 
            this.checkBoxCopy.AutoSize = true;
            this.checkBoxCopy.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxCopy.Location = new System.Drawing.Point(10, 190);
            this.checkBoxCopy.Name = "checkBoxCopy";
            this.checkBoxCopy.Size = new System.Drawing.Size(128, 17);
            this.checkBoxCopy.TabIndex = 11;
            this.checkBoxCopy.Text = "Copy to new directory";
            this.checkBoxCopy.UseVisualStyleBackColor = true;
            this.checkBoxCopy.CheckedChanged += new System.EventHandler(this.checkBoxCopy_CheckedChanged);
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxRecursive.Location = new System.Drawing.Point(150, 190);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(125, 17);
            this.checkBoxRecursive.TabIndex = 14;
            this.checkBoxRecursive.Text = "Recursive file search";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            this.checkBoxRecursive.CheckedChanged += new System.EventHandler(this.checkBoxRecursive_CheckedChanged);
            // 
            // buttonRegex
            // 
            this.buttonRegex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegex.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRegex.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRegex.FlatAppearance.BorderSize = 0;
            this.buttonRegex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegex.ForeColor = System.Drawing.Color.White;
            this.buttonRegex.HideArrow = false;
            this.buttonRegex.Location = new System.Drawing.Point(266, 98);
            this.buttonRegex.Menu = this.contextMenuRegex;
            this.buttonRegex.Name = "buttonRegex";
            this.buttonRegex.Size = new System.Drawing.Size(58, 23);
            this.buttonRegex.Style = DropdownButton.Styles.Default;
            this.buttonRegex.TabIndex = 7;
            this.buttonRegex.Text = "Clear";
            this.buttonRegex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegex.UseVisualStyleBackColor = false;
            this.buttonRegex.Click += new System.EventHandler(this.buttonRegex_Click);
            // 
            // contextMenuRegex
            // 
            this.contextMenuRegex.Name = "contextMenuRegex";
            this.contextMenuRegex.ShowImageMargin = false;
            this.contextMenuRegex.Size = new System.Drawing.Size(36, 4);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Image = global::Renamer.Properties.Resources.refresh;
            this.buttonRefresh.Location = new System.Drawing.Point(108, 19);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(16, 16);
            this.buttonRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.TabStop = false;
            this.toolTipProvider.SetToolTip(this.buttonRefresh, "Click to Reload");
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // filesFound
            // 
            this.filesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filesFound.ForeColor = System.Drawing.Color.Gray;
            this.filesFound.Location = new System.Drawing.Point(156, 77);
            this.filesFound.Name = "filesFound";
            this.filesFound.Size = new System.Drawing.Size(171, 14);
            this.filesFound.Style = MetroFramework.MetroColorStyle.Blue;
            this.filesFound.TabIndex = 5;
            this.filesFound.Text = "0 Files";
            this.filesFound.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.filesFound.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // totalFiles
            // 
            this.totalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalFiles.ForeColor = System.Drawing.Color.Gray;
            this.totalFiles.Location = new System.Drawing.Point(156, 19);
            this.totalFiles.Name = "totalFiles";
            this.totalFiles.Size = new System.Drawing.Size(171, 14);
            this.totalFiles.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalFiles.TabIndex = 1;
            this.totalFiles.Text = "0 Files";
            this.totalFiles.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.totalFiles.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // buttonBrowseOutput
            // 
            this.buttonBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseOutput.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBrowseOutput.Enabled = false;
            this.buttonBrowseOutput.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBrowseOutput.FlatAppearance.BorderSize = 0;
            this.buttonBrowseOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseOutput.ForeColor = System.Drawing.Color.White;
            this.buttonBrowseOutput.Location = new System.Drawing.Point(266, 156);
            this.buttonBrowseOutput.Name = "buttonBrowseOutput";
            this.buttonBrowseOutput.Size = new System.Drawing.Size(58, 23);
            this.buttonBrowseOutput.Style = DropdownButton.Styles.Default;
            this.buttonBrowseOutput.TabIndex = 10;
            this.buttonBrowseOutput.Text = "...";
            this.buttonBrowseOutput.UseVisualStyleBackColor = false;
            this.buttonBrowseOutput.Click += new System.EventHandler(this.buttonBrowseOutput_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AllowDrop = true;
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(10, 156);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ShortcutsEnabled = false;
            this.textBoxOutput.Size = new System.Drawing.Size(250, 23);
            this.textBoxOutput.TabIndex = 9;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            this.textBoxOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxOutput_DragDrop);
            this.textBoxOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 14);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Output Directory";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFilter.Location = new System.Drawing.Point(10, 98);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(250, 23);
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 14);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Filter";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // buttonBrowseInput
            // 
            this.buttonBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseInput.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBrowseInput.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBrowseInput.FlatAppearance.BorderSize = 0;
            this.buttonBrowseInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseInput.ForeColor = System.Drawing.Color.White;
            this.buttonBrowseInput.Location = new System.Drawing.Point(266, 40);
            this.buttonBrowseInput.Name = "buttonBrowseInput";
            this.buttonBrowseInput.Size = new System.Drawing.Size(58, 23);
            this.buttonBrowseInput.Style = DropdownButton.Styles.Default;
            this.buttonBrowseInput.TabIndex = 3;
            this.buttonBrowseInput.Text = "...";
            this.buttonBrowseInput.UseVisualStyleBackColor = false;
            this.buttonBrowseInput.Click += new System.EventHandler(this.buttonBrowseInput_Click);
            // 
            // textBoxInputDir
            // 
            this.textBoxInputDir.AllowDrop = true;
            this.textBoxInputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputDir.Location = new System.Drawing.Point(10, 40);
            this.textBoxInputDir.Name = "textBoxInputDir";
            this.textBoxInputDir.ReadOnly = true;
            this.textBoxInputDir.ShortcutsEnabled = false;
            this.textBoxInputDir.Size = new System.Drawing.Size(250, 23);
            this.textBoxInputDir.TabIndex = 2;
            this.textBoxInputDir.TextChanged += new System.EventHandler(this.textBoxInputDir_TextChanged);
            this.textBoxInputDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxInputDir_DragDrop);
            this.textBoxInputDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox_DragEnter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 14);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Input Directory";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.buttonDown);
            this.groupBox2.Controls.Add(this.buttonUp);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.dropDownProfile);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.olvFilters);
            this.groupBox2.Location = new System.Drawing.Point(343, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.HideArrow = false;
            this.buttonDelete.Location = new System.Drawing.Point(86, 182);
            this.buttonDelete.Menu = this.contextMenuDelete;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 27);
            this.buttonDelete.Style = DropdownButton.Styles.Default;
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.ShowImageMargin = false;
            this.contextMenuDelete.Size = new System.Drawing.Size(130, 48);
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete Selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.removeAllToolStripMenuItem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.HideArrow = false;
            this.buttonAdd.Location = new System.Drawing.Point(10, 182);
            this.buttonAdd.Menu = this.contextMenuAdd;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 27);
            this.buttonAdd.Style = DropdownButton.Styles.Default;
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // contextMenuAdd
            // 
            this.contextMenuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripMenuItem2,
            this.addNumberingToolStripMenuItem,
            this.addNumberingByDirectoryToolStripMenuItem,
            this.swapOrderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.appendBeforeToolStripMenuItem,
            this.appendAfterToolStripMenuItem,
            this.appendAtPositionToolStripMenuItem,
            this.appendFromTextFileToolStripMenuItem,
            this.toolStripMenuItem3,
            this.extractNumbersToolStripMenuItem,
            this.keepAlphanumericCharactersToolStripMenuItem,
            this.removeInvalidCharactersToolStripMenuItem,
            this.toolStripMenuItem4,
            this.preserveFromLeftToolStripMenuItem,
            this.preserveFromRightToolStripMenuItem,
            this.trimFromLeftToolStripMenuItem,
            this.trimFromRightToolStripMenuItem,
            this.toolStripMenuItem5,
            this.capitalizeEachWordToolStripMenuItem,
            this.toUppercaseToolStripMenuItem,
            this.toLowercaseToolStripMenuItem,
            this.toSentenceCaseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.regularExpressionToolStripMenuItem,
            this.regexReplaceToolStripMenuItem,
            this.replaceStringToolStripMenuItem,
            this.replaceStringCaseInsensitiveToolStripMenuItem,
            this.toolStripMenuItem7,
            this.parentDirectoryToolStripMenuItem,
            this.originalFileNameToolStripMenuItem,
            this.addExtensionToolStripMenuItem,
            this.removeExtensionToolStripMenuItem});
            this.contextMenuAdd.Name = "contextMenuAdd";
            this.contextMenuAdd.ShowImageMargin = false;
            this.contextMenuAdd.Size = new System.Drawing.Size(219, 640);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 6);
            // 
            // addNumberingToolStripMenuItem
            // 
            this.addNumberingToolStripMenuItem.Name = "addNumberingToolStripMenuItem";
            this.addNumberingToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.addNumberingToolStripMenuItem.Text = "Add Numbering";
            this.addNumberingToolStripMenuItem.Click += new System.EventHandler(this.addNumberingToolStripMenuItem_Click);
            // 
            // addNumberingByDirectoryToolStripMenuItem
            // 
            this.addNumberingByDirectoryToolStripMenuItem.Name = "addNumberingByDirectoryToolStripMenuItem";
            this.addNumberingByDirectoryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.addNumberingByDirectoryToolStripMenuItem.Text = "Add Numbering (By Directory)";
            this.addNumberingByDirectoryToolStripMenuItem.Click += new System.EventHandler(this.addNumberingByDirectoryToolStripMenuItem_Click);
            // 
            // swapOrderToolStripMenuItem
            // 
            this.swapOrderToolStripMenuItem.Name = "swapOrderToolStripMenuItem";
            this.swapOrderToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.swapOrderToolStripMenuItem.Text = "Add Numbering (Swap Order)";
            this.swapOrderToolStripMenuItem.Click += new System.EventHandler(this.swapOrderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            // 
            // appendBeforeToolStripMenuItem
            // 
            this.appendBeforeToolStripMenuItem.Name = "appendBeforeToolStripMenuItem";
            this.appendBeforeToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.appendBeforeToolStripMenuItem.Text = "Append Before";
            this.appendBeforeToolStripMenuItem.Click += new System.EventHandler(this.appendBeforeToolStripMenuItem_Click);
            // 
            // appendAfterToolStripMenuItem
            // 
            this.appendAfterToolStripMenuItem.Name = "appendAfterToolStripMenuItem";
            this.appendAfterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.appendAfterToolStripMenuItem.Text = "Append After";
            this.appendAfterToolStripMenuItem.Click += new System.EventHandler(this.appendAfterToolStripMenuItem_Click);
            // 
            // appendAtPositionToolStripMenuItem
            // 
            this.appendAtPositionToolStripMenuItem.Name = "appendAtPositionToolStripMenuItem";
            this.appendAtPositionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.appendAtPositionToolStripMenuItem.Text = "Append at Position";
            this.appendAtPositionToolStripMenuItem.Click += new System.EventHandler(this.appendAtPositionToolStripMenuItem_Click);
            // 
            // appendFromTextFileToolStripMenuItem
            // 
            this.appendFromTextFileToolStripMenuItem.Name = "appendFromTextFileToolStripMenuItem";
            this.appendFromTextFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.appendFromTextFileToolStripMenuItem.Text = "Append from Text File";
            this.appendFromTextFileToolStripMenuItem.Click += new System.EventHandler(this.appendFromTextFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(215, 6);
            // 
            // extractNumbersToolStripMenuItem
            // 
            this.extractNumbersToolStripMenuItem.Name = "extractNumbersToolStripMenuItem";
            this.extractNumbersToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.extractNumbersToolStripMenuItem.Text = "Keep Numeric Characters";
            this.extractNumbersToolStripMenuItem.Click += new System.EventHandler(this.extractNumbersToolStripMenuItem_Click);
            // 
            // keepAlphanumericCharactersToolStripMenuItem
            // 
            this.keepAlphanumericCharactersToolStripMenuItem.Name = "keepAlphanumericCharactersToolStripMenuItem";
            this.keepAlphanumericCharactersToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.keepAlphanumericCharactersToolStripMenuItem.Text = "Keep Alphanumeric Characters";
            this.keepAlphanumericCharactersToolStripMenuItem.Click += new System.EventHandler(this.keepAlphanumericCharactersToolStripMenuItem_Click);
            // 
            // removeInvalidCharactersToolStripMenuItem
            // 
            this.removeInvalidCharactersToolStripMenuItem.Name = "removeInvalidCharactersToolStripMenuItem";
            this.removeInvalidCharactersToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.removeInvalidCharactersToolStripMenuItem.Text = "Remove Invalid Characters";
            this.removeInvalidCharactersToolStripMenuItem.Click += new System.EventHandler(this.removeInvalidCharactersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(215, 6);
            // 
            // preserveFromLeftToolStripMenuItem
            // 
            this.preserveFromLeftToolStripMenuItem.Name = "preserveFromLeftToolStripMenuItem";
            this.preserveFromLeftToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.preserveFromLeftToolStripMenuItem.Text = "Preserve from Left";
            this.preserveFromLeftToolStripMenuItem.Click += new System.EventHandler(this.preserveFromLeftToolStripMenuItem_Click);
            // 
            // preserveFromRightToolStripMenuItem
            // 
            this.preserveFromRightToolStripMenuItem.Name = "preserveFromRightToolStripMenuItem";
            this.preserveFromRightToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.preserveFromRightToolStripMenuItem.Text = "Preserve from Right";
            this.preserveFromRightToolStripMenuItem.Click += new System.EventHandler(this.preserveFromRightToolStripMenuItem_Click);
            // 
            // trimFromLeftToolStripMenuItem
            // 
            this.trimFromLeftToolStripMenuItem.Name = "trimFromLeftToolStripMenuItem";
            this.trimFromLeftToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.trimFromLeftToolStripMenuItem.Text = "Trim from Left";
            this.trimFromLeftToolStripMenuItem.Click += new System.EventHandler(this.trimFromLeftToolStripMenuItem_Click);
            // 
            // trimFromRightToolStripMenuItem
            // 
            this.trimFromRightToolStripMenuItem.Name = "trimFromRightToolStripMenuItem";
            this.trimFromRightToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.trimFromRightToolStripMenuItem.Text = "Trim from Right";
            this.trimFromRightToolStripMenuItem.Click += new System.EventHandler(this.trimFromRightToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(215, 6);
            // 
            // capitalizeEachWordToolStripMenuItem
            // 
            this.capitalizeEachWordToolStripMenuItem.Name = "capitalizeEachWordToolStripMenuItem";
            this.capitalizeEachWordToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.capitalizeEachWordToolStripMenuItem.Text = "Capitalize each Word";
            this.capitalizeEachWordToolStripMenuItem.Click += new System.EventHandler(this.capitalizeEachWordToolStripMenuItem_Click);
            // 
            // toUppercaseToolStripMenuItem
            // 
            this.toUppercaseToolStripMenuItem.Name = "toUppercaseToolStripMenuItem";
            this.toUppercaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.toUppercaseToolStripMenuItem.Text = "Upper Case";
            this.toUppercaseToolStripMenuItem.Click += new System.EventHandler(this.toUppercaseToolStripMenuItem_Click);
            // 
            // toLowercaseToolStripMenuItem
            // 
            this.toLowercaseToolStripMenuItem.Name = "toLowercaseToolStripMenuItem";
            this.toLowercaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.toLowercaseToolStripMenuItem.Text = "Lower Case";
            this.toLowercaseToolStripMenuItem.Click += new System.EventHandler(this.toLowercaseToolStripMenuItem_Click);
            // 
            // toSentenceCaseToolStripMenuItem
            // 
            this.toSentenceCaseToolStripMenuItem.Name = "toSentenceCaseToolStripMenuItem";
            this.toSentenceCaseToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.toSentenceCaseToolStripMenuItem.Text = "Sentence Case";
            this.toSentenceCaseToolStripMenuItem.Click += new System.EventHandler(this.toSentenceCaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(215, 6);
            // 
            // regularExpressionToolStripMenuItem
            // 
            this.regularExpressionToolStripMenuItem.Name = "regularExpressionToolStripMenuItem";
            this.regularExpressionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.regularExpressionToolStripMenuItem.Text = "Regex Match";
            this.regularExpressionToolStripMenuItem.Click += new System.EventHandler(this.regularExpressionToolStripMenuItem_Click);
            // 
            // regexReplaceToolStripMenuItem
            // 
            this.regexReplaceToolStripMenuItem.Name = "regexReplaceToolStripMenuItem";
            this.regexReplaceToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.regexReplaceToolStripMenuItem.Text = "Regex Replace";
            this.regexReplaceToolStripMenuItem.Click += new System.EventHandler(this.regexReplaceToolStripMenuItem_Click);
            // 
            // replaceStringToolStripMenuItem
            // 
            this.replaceStringToolStripMenuItem.Name = "replaceStringToolStripMenuItem";
            this.replaceStringToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.replaceStringToolStripMenuItem.Text = "Replace String";
            this.replaceStringToolStripMenuItem.Click += new System.EventHandler(this.replaceStringToolStripMenuItem_Click);
            // 
            // replaceStringCaseInsensitiveToolStripMenuItem
            // 
            this.replaceStringCaseInsensitiveToolStripMenuItem.Name = "replaceStringCaseInsensitiveToolStripMenuItem";
            this.replaceStringCaseInsensitiveToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.replaceStringCaseInsensitiveToolStripMenuItem.Text = "Replace String (Case Insensitive)";
            this.replaceStringCaseInsensitiveToolStripMenuItem.Click += new System.EventHandler(this.replaceStringCaseInsensitiveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(215, 6);
            // 
            // parentDirectoryToolStripMenuItem
            // 
            this.parentDirectoryToolStripMenuItem.Name = "parentDirectoryToolStripMenuItem";
            this.parentDirectoryToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.parentDirectoryToolStripMenuItem.Text = "Parent Directory";
            this.parentDirectoryToolStripMenuItem.Click += new System.EventHandler(this.parentDirectoryToolStripMenuItem_Click);
            // 
            // originalFileNameToolStripMenuItem
            // 
            this.originalFileNameToolStripMenuItem.Name = "originalFileNameToolStripMenuItem";
            this.originalFileNameToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.originalFileNameToolStripMenuItem.Text = "Original File Name";
            this.originalFileNameToolStripMenuItem.Click += new System.EventHandler(this.originalFilenameToolStripMenuItem_Click);
            // 
            // addExtensionToolStripMenuItem
            // 
            this.addExtensionToolStripMenuItem.Name = "addExtensionToolStripMenuItem";
            this.addExtensionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.addExtensionToolStripMenuItem.Text = "Add Extension";
            this.addExtensionToolStripMenuItem.Click += new System.EventHandler(this.addExtensionToolStripMenuItem_Click);
            // 
            // removeExtensionToolStripMenuItem
            // 
            this.removeExtensionToolStripMenuItem.Name = "removeExtensionToolStripMenuItem";
            this.removeExtensionToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.removeExtensionToolStripMenuItem.Text = "Remove Extension";
            this.removeExtensionToolStripMenuItem.Click += new System.EventHandler(this.removeExtensionToolStripMenuItem_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDown.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.ForeColor = System.Drawing.Color.White;
            this.buttonDown.Location = new System.Drawing.Point(264, 182);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 27);
            this.buttonDown.Style = DropdownButton.Styles.Default;
            this.buttonDown.TabIndex = 7;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUp.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.ForeColor = System.Drawing.Color.White;
            this.buttonUp.Location = new System.Drawing.Point(198, 182);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 27);
            this.buttonUp.Style = DropdownButton.Styles.Default;
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.HideArrow = false;
            this.buttonSave.Location = new System.Drawing.Point(254, 40);
            this.buttonSave.Menu = this.contextMenuSave;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 29);
            this.buttonSave.Style = DropdownButton.Styles.Default;
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // contextMenuSave
            // 
            this.contextMenuSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuSave.Name = "contextMenuSave";
            this.contextMenuSave.ShowImageMargin = false;
            this.contextMenuSave.Size = new System.Drawing.Size(93, 92);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dropDownProfile
            // 
            this.dropDownProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownProfile.FormattingEnabled = true;
            this.dropDownProfile.ItemHeight = 23;
            this.dropDownProfile.Location = new System.Drawing.Point(10, 40);
            this.dropDownProfile.Name = "dropDownProfile";
            this.dropDownProfile.Size = new System.Drawing.Size(238, 29);
            this.dropDownProfile.Style = MetroFramework.MetroColorStyle.Blue;
            this.dropDownProfile.TabIndex = 1;
            this.dropDownProfile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dropDownProfile.UseSelectable = true;
            this.dropDownProfile.SelectedIndexChanged += new System.EventHandler(this.dropDownProfile_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 14);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Profile";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // olvFilters
            // 
            this.olvFilters.AllColumns.Add(this.olvColumn3);
            this.olvFilters.AllColumns.Add(this.olvColumn4);
            this.olvFilters.AllColumns.Add(this.olvColumn5);
            this.olvFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvFilters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.olvFilters.FullRowSelect = true;
            this.olvFilters.GridLines = true;
            this.olvFilters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.olvFilters.HideSelection = false;
            this.olvFilters.Location = new System.Drawing.Point(10, 75);
            this.olvFilters.MultiSelect = false;
            this.olvFilters.Name = "olvFilters";
            this.olvFilters.SelectColumnsOnRightClick = false;
            this.olvFilters.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvFilters.ShowFilterMenuOnRightClick = false;
            this.olvFilters.ShowGroups = false;
            this.olvFilters.Size = new System.Drawing.Size(314, 101);
            this.olvFilters.TabIndex = 3;
            this.olvFilters.UseCompatibleStateImageBehavior = false;
            this.olvFilters.View = System.Windows.Forms.View.Details;
            this.olvFilters.VirtualMode = true;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "GetFunctionName";
            this.olvColumn3.Sortable = false;
            this.olvColumn3.Text = "Filter";
            this.olvColumn3.Width = 170;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "FirstArgument";
            this.olvColumn4.Sortable = false;
            this.olvColumn4.Text = "";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "SecondArgument";
            this.olvColumn5.Sortable = false;
            this.olvColumn5.Text = "";
            // 
            // contextMenuSort
            // 
            this.contextMenuSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naturalSortToolStripMenuItem,
            this.naturalDescendingSortToolStripMenuItem,
            this.alphanumericalSortToolStripMenuItem,
            this.alphanumericalDescendingSortToolStripMenuItem,
            this.customSortToolStripMenuItem,
            this.toolStripMenuItem8,
            this.copyAllToolStripMenuItem});
            this.contextMenuSort.Name = "contextMenuSort";
            this.contextMenuSort.Size = new System.Drawing.Size(248, 142);
            // 
            // naturalSortToolStripMenuItem
            // 
            this.naturalSortToolStripMenuItem.Name = "naturalSortToolStripMenuItem";
            this.naturalSortToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.naturalSortToolStripMenuItem.Text = "Natural Sort";
            this.naturalSortToolStripMenuItem.Click += new System.EventHandler(this.naturalSortToolStripMenuItem_Click);
            // 
            // naturalDescendingSortToolStripMenuItem
            // 
            this.naturalDescendingSortToolStripMenuItem.Name = "naturalDescendingSortToolStripMenuItem";
            this.naturalDescendingSortToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.naturalDescendingSortToolStripMenuItem.Text = "Natural Descending Sort";
            this.naturalDescendingSortToolStripMenuItem.Click += new System.EventHandler(this.naturalDescendingSortToolStripMenuItem_Click);
            // 
            // alphanumericalSortToolStripMenuItem
            // 
            this.alphanumericalSortToolStripMenuItem.Name = "alphanumericalSortToolStripMenuItem";
            this.alphanumericalSortToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.alphanumericalSortToolStripMenuItem.Text = "Alphanumerical Sort";
            this.alphanumericalSortToolStripMenuItem.Click += new System.EventHandler(this.alphanumericalSortToolStripMenuItem_Click);
            // 
            // alphanumericalDescendingSortToolStripMenuItem
            // 
            this.alphanumericalDescendingSortToolStripMenuItem.Name = "alphanumericalDescendingSortToolStripMenuItem";
            this.alphanumericalDescendingSortToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.alphanumericalDescendingSortToolStripMenuItem.Text = "Alphanumerical Descending Sort";
            this.alphanumericalDescendingSortToolStripMenuItem.Click += new System.EventHandler(this.alphanumericalDescendingSortToolStripMenuItem_Click);
            // 
            // customSortToolStripMenuItem
            // 
            this.customSortToolStripMenuItem.Name = "customSortToolStripMenuItem";
            this.customSortToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.customSortToolStripMenuItem.Text = "Custom Sort";
            this.customSortToolStripMenuItem.Click += new System.EventHandler(this.customSortToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(244, 6);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRevert.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRevert.Enabled = false;
            this.buttonRevert.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRevert.FlatAppearance.BorderSize = 0;
            this.buttonRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRevert.ForeColor = System.Drawing.Color.White;
            this.buttonRevert.Location = new System.Drawing.Point(604, 9);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(85, 27);
            this.buttonRevert.Style = DropdownButton.Styles.Default;
            this.buttonRevert.TabIndex = 3;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = false;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // buttonRename
            // 
            this.buttonRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRename.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonRename.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonRename.FlatAppearance.BorderSize = 0;
            this.buttonRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRename.ForeColor = System.Drawing.Color.White;
            this.buttonRename.Location = new System.Drawing.Point(513, 9);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(85, 27);
            this.buttonRename.Style = DropdownButton.Styles.Primary;
            this.buttonRename.TabIndex = 2;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = false;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // olvPreview
            // 
            this.olvPreview.AllColumns.Add(this.olvColumn1);
            this.olvPreview.AllColumns.Add(this.olvColumn2);
            this.olvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvPreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.olvPreview.ContextMenuStrip = this.contextMenuProperties;
            this.olvPreview.FullRowSelect = true;
            this.olvPreview.GridLines = true;
            this.olvPreview.HideSelection = false;
            this.olvPreview.IsSimpleDragSource = true;
            this.olvPreview.Location = new System.Drawing.Point(15, 236);
            this.olvPreview.MultiSelect = false;
            this.olvPreview.Name = "olvPreview";
            this.olvPreview.OwnerDraw = true;
            this.olvPreview.RowHeight = 24;
            this.olvPreview.SelectColumnsOnRightClick = false;
            this.olvPreview.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.olvPreview.ShowFilterMenuOnRightClick = false;
            this.olvPreview.ShowGroups = false;
            this.olvPreview.ShowItemToolTips = true;
            this.olvPreview.Size = new System.Drawing.Size(674, 155);
            this.olvPreview.TabIndex = 1;
            this.olvPreview.UseCompatibleStateImageBehavior = false;
            this.olvPreview.View = System.Windows.Forms.View.Details;
            this.olvPreview.VirtualMode = true;
            this.olvPreview.ColumnRightClick += new BrightIdeasSoftware.ColumnRightClickEventHandler(this.olvPreview_ColumnRightClick);
            this.olvPreview.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.olvPreview_FormatRow);
            this.olvPreview.ModelCanDrop += new System.EventHandler<BrightIdeasSoftware.ModelDropEventArgs>(this.olvPreview_ModelCanDrop);
            this.olvPreview.ModelDropped += new System.EventHandler<BrightIdeasSoftware.ModelDropEventArgs>(this.olvPreview_ModelDropped);
            this.olvPreview.SelectionChanged += new System.EventHandler(this.olvPreview_SelectionChanged);
            this.olvPreview.Scroll += new System.EventHandler<System.Windows.Forms.ScrollEventArgs>(this.olvPreview_Scroll);
            this.olvPreview.DoubleClick += new System.EventHandler(this.olvPreview_DoubleClick);
            this.olvPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.olvPreview_MouseMove);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Original";
            this.olvColumn1.AspectToStringFormat = "";
            this.olvColumn1.ImageAspectName = "GetIcon";
            this.olvColumn1.Sortable = false;
            this.olvColumn1.Text = "Before";
            this.olvColumn1.ToolTipText = "";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Modified";
            this.olvColumn2.ImageAspectName = "GetIconModified";
            this.olvColumn2.Sortable = false;
            this.olvColumn2.Text = "After";
            // 
            // contextMenuProperties
            // 
            this.contextMenuProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem10,
            this.editToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.excludeToolStripMenuItem,
            this.toolStripMenuItem9,
            this.propertiesToolStripMenuItem});
            this.contextMenuProperties.Name = "contextMenuProperties";
            this.contextMenuProperties.Size = new System.Drawing.Size(128, 126);
            this.contextMenuProperties.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuProperties_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(124, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // excludeToolStripMenuItem
            // 
            this.excludeToolStripMenuItem.Name = "excludeToolStripMenuItem";
            this.excludeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.excludeToolStripMenuItem.Text = "Exclude";
            this.excludeToolStripMenuItem.Click += new System.EventHandler(this.excludeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(124, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOptions.BackColor = System.Drawing.Color.DarkGray;
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.ForeColor = System.Drawing.Color.White;
            this.buttonOptions.HideArrow = true;
            this.buttonOptions.Image = global::Renamer.Properties.Resources.menu;
            this.buttonOptions.Location = new System.Drawing.Point(15, 9);
            this.buttonOptions.Menu = this.contextMenuOptions;
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(27, 27);
            this.buttonOptions.Style = DropdownButton.Styles.Default;
            this.buttonOptions.TabIndex = 0;
            this.buttonOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOptions.UseVisualStyleBackColor = false;
            // 
            // contextMenuOptions
            // 
            this.contextMenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.toolStripMenuItem11,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.contextMenuOptions.Name = "contextMenuOptions";
            this.contextMenuOptions.Size = new System.Drawing.Size(139, 76);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(135, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.buttonOptions);
            this.panel1.Controls.Add(this.buttonRename);
            this.panel1.Controls.Add(this.buttonRevert);
            this.panel1.Controls.Add(this.panelDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 45);
            this.panel1.TabIndex = 2;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetails.Controls.Add(this.buttonMediaInfo);
            this.panelDetails.Controls.Add(this.metroLabel7);
            this.panelDetails.Controls.Add(this.metroLabel6);
            this.panelDetails.Controls.Add(this.metroLabel5);
            this.panelDetails.Controls.Add(this.fileSize);
            this.panelDetails.Controls.Add(this.dateCreated);
            this.panelDetails.Controls.Add(this.dateModified);
            this.panelDetails.Location = new System.Drawing.Point(48, 0);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(420, 45);
            this.panelDetails.TabIndex = 8;
            this.panelDetails.Visible = false;
            // 
            // buttonMediaInfo
            // 
            this.buttonMediaInfo.ActiveLinkColor = System.Drawing.Color.Black;
            this.buttonMediaInfo.AutoSize = true;
            this.buttonMediaInfo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonMediaInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.buttonMediaInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.buttonMediaInfo.Location = new System.Drawing.Point(244, 22);
            this.buttonMediaInfo.Name = "buttonMediaInfo";
            this.buttonMediaInfo.Size = new System.Drawing.Size(126, 12);
            this.buttonMediaInfo.TabIndex = 1;
            this.buttonMediaInfo.TabStop = true;
            this.buttonMediaInfo.Text = "Advanced information";
            this.buttonMediaInfo.Click += new System.EventHandler(this.buttonMediaInfo_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(8, 22);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(89, 12);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Date modified:";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(8, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 12);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Date created:";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(244, 11);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 12);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Size:";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.BackColor = System.Drawing.Color.Transparent;
            this.fileSize.FontSize = MetroFramework.MetroLabelSize.Small;
            this.fileSize.Location = new System.Drawing.Point(276, 11);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(71, 12);
            this.fileSize.TabIndex = 6;
            this.fileSize.Text = "1023.31 MB";
            this.fileSize.UseCustomBackColor = true;
            // 
            // dateCreated
            // 
            this.dateCreated.AutoSize = true;
            this.dateCreated.BackColor = System.Drawing.Color.Transparent;
            this.dateCreated.FontSize = MetroFramework.MetroLabelSize.Small;
            this.dateCreated.Location = new System.Drawing.Point(96, 11);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(127, 12);
            this.dateCreated.TabIndex = 5;
            this.dateCreated.Text = "01/26/2015 12:45:12";
            this.dateCreated.UseCustomBackColor = true;
            // 
            // dateModified
            // 
            this.dateModified.AutoSize = true;
            this.dateModified.BackColor = System.Drawing.Color.Transparent;
            this.dateModified.FontSize = MetroFramework.MetroLabelSize.Small;
            this.dateModified.Location = new System.Drawing.Point(96, 22);
            this.dateModified.Name = "dateModified";
            this.dateModified.Size = new System.Drawing.Size(127, 12);
            this.dateModified.TabIndex = 4;
            this.dateModified.Text = "05/26/2015 10:18:02";
            this.dateModified.UseCustomBackColor = true;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.olvPreview);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renamer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRefresh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuDelete.ResumeLayout(false);
            this.contextMenuAdd.ResumeLayout(false);
            this.contextMenuSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvFilters)).EndInit();
            this.contextMenuSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPreview)).EndInit();
            this.contextMenuProperties.ResumeLayout(false);
            this.contextMenuOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox textBoxInputDir;
        private DropdownButton.FlatButton buttonBrowseInput;
        private DropdownButton.FlatButton buttonBrowseOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox textBoxFilter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DropdownButton.FlatButton buttonRename;
        private MetroFramework.Controls.MetroComboBox dropDownProfile;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private DropdownButton.DropdownButton buttonSave;
        private DropdownButton.FlatButton buttonDown;
        private DropdownButton.FlatButton buttonUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuSave;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DropdownButton.DropdownButton buttonAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addNumberingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem appendBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendAfterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendAtPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appendFromTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem extractNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepAlphanumericCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem preserveFromLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preserveFromRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimFromLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimFromRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toUppercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toSentenceCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalizeEachWordToolStripMenuItem;
        private DropdownButton.DropdownButton buttonDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem regularExpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeInvalidCharactersToolStripMenuItem;
        private BrightIdeasSoftware.FastObjectListView olvPreview;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.FastObjectListView olvFilters;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.ToolStripMenuItem regexReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem addExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceStringCaseInsensitiveToolStripMenuItem;
        private ModernFolderBrowserDialog.FolderBrowser folderBrowser;
        private DropdownButton.FlatButton buttonRevert;
        private System.Windows.Forms.ContextMenuStrip contextMenuSort;
        private System.Windows.Forms.ToolStripMenuItem naturalSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalDescendingSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphanumericalSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphanumericalDescendingSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private MetroFramework.Controls.MetroLabel filesFound;
        private MetroFramework.Controls.MetroLabel totalFiles;
        private System.Windows.Forms.PictureBox buttonRefresh;
        private System.Windows.Forms.ToolTip toolTipProvider;
        private System.Windows.Forms.ToolStripMenuItem swapOrderToolStripMenuItem;
        private DropdownButton.DropdownButton buttonRegex;
        private System.Windows.Forms.ContextMenuStrip contextMenuRegex;
        private DropdownButton.DropdownButton buttonOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuOptions;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuProperties;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxRecursive;
        private System.Windows.Forms.CheckBox checkBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem parentDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNumberingByDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel fileSize;
        private MetroFramework.Controls.MetroLabel dateModified;
        private MetroFramework.Controls.MetroLabel dateCreated;
        private System.Windows.Forms.LinkLabel buttonMediaInfo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panelDetails;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ToolStripMenuItem originalFileNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeToolStripMenuItem;
    }
}