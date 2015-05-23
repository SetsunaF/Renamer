namespace Renamer.Windows
{
    partial class FilterSelector
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
            this.panelTabs = new System.Windows.Forms.Panel();
            this.flatButton6 = new DropdownButton.FlatButton();
            this.flatButton5 = new DropdownButton.FlatButton();
            this.flatButton4 = new DropdownButton.FlatButton();
            this.flatButton3 = new DropdownButton.FlatButton();
            this.flatButton2 = new DropdownButton.FlatButton();
            this.flatButton1 = new DropdownButton.FlatButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.olvSelector = new BrightIdeasSoftware.ObjectListView();
            this.olvSelectorMainColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelTabs.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTabs.Controls.Add(this.flatButton6);
            this.panelTabs.Controls.Add(this.flatButton5);
            this.panelTabs.Controls.Add(this.flatButton4);
            this.panelTabs.Controls.Add(this.flatButton3);
            this.panelTabs.Controls.Add(this.flatButton2);
            this.panelTabs.Controls.Add(this.flatButton1);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(884, 37);
            this.panelTabs.TabIndex = 0;
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton6.FlatAppearance.BorderSize = 0;
            this.flatButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton6.ForeColor = System.Drawing.Color.White;
            this.flatButton6.Location = new System.Drawing.Point(502, 7);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Size = new System.Drawing.Size(85, 23);
            this.flatButton6.Style = DropdownButton.Styles.Default;
            this.flatButton6.TabIndex = 5;
            this.flatButton6.Tag = "customFilters";
            this.flatButton6.Text = "Custom";
            this.flatButton6.UseVisualStyleBackColor = false;
            this.flatButton6.Visible = false;
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton5.FlatAppearance.BorderSize = 0;
            this.flatButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton5.ForeColor = System.Drawing.Color.White;
            this.flatButton5.Location = new System.Drawing.Point(411, 7);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Size = new System.Drawing.Size(85, 23);
            this.flatButton5.Style = DropdownButton.Styles.Default;
            this.flatButton5.TabIndex = 4;
            this.flatButton5.Tag = "fileFilters";
            this.flatButton5.Text = "File";
            this.flatButton5.UseVisualStyleBackColor = false;
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton4.FlatAppearance.BorderSize = 0;
            this.flatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton4.ForeColor = System.Drawing.Color.White;
            this.flatButton4.Location = new System.Drawing.Point(300, 7);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Size = new System.Drawing.Size(105, 23);
            this.flatButton4.Style = DropdownButton.Styles.Default;
            this.flatButton4.TabIndex = 3;
            this.flatButton4.Tag = "matchFilters";
            this.flatButton4.Text = "Match / Replace";
            this.flatButton4.UseVisualStyleBackColor = false;
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton3.FlatAppearance.BorderSize = 0;
            this.flatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton3.ForeColor = System.Drawing.Color.White;
            this.flatButton3.Location = new System.Drawing.Point(189, 7);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Size = new System.Drawing.Size(105, 23);
            this.flatButton3.Style = DropdownButton.Styles.Default;
            this.flatButton3.TabIndex = 2;
            this.flatButton3.Tag = "trimFilters";
            this.flatButton3.Text = "Keep / Trim";
            this.flatButton3.UseVisualStyleBackColor = false;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton2.FlatAppearance.BorderSize = 0;
            this.flatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton2.ForeColor = System.Drawing.Color.White;
            this.flatButton2.Location = new System.Drawing.Point(98, 7);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Size = new System.Drawing.Size(85, 23);
            this.flatButton2.Style = DropdownButton.Styles.Default;
            this.flatButton2.TabIndex = 1;
            this.flatButton2.Tag = "numberingFilters";
            this.flatButton2.Text = "Numbering";
            this.flatButton2.UseVisualStyleBackColor = false;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton1.FlatAppearance.BorderSize = 0;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.Location = new System.Drawing.Point(7, 7);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(85, 23);
            this.flatButton1.Style = DropdownButton.Styles.Default;
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Tag = "basicFilters";
            this.flatButton1.Text = "Basic";
            this.flatButton1.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.LightGray;
            this.panelContent.Controls.Add(this.olvSelector);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 37);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(884, 229);
            this.panelContent.TabIndex = 3;
            // 
            // olvSelector
            // 
            this.olvSelector.AllColumns.Add(this.olvSelectorMainColumn);
            this.olvSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvSelector.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvSelectorMainColumn});
            this.olvSelector.CopySelectionOnControlC = false;
            this.olvSelector.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvSelector.FullRowSelect = true;
            this.olvSelector.GridLines = true;
            this.olvSelector.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvSelector.Location = new System.Drawing.Point(6, 6);
            this.olvSelector.MultiSelect = false;
            this.olvSelector.Name = "olvSelector";
            this.olvSelector.OwnerDraw = true;
            this.olvSelector.RowHeight = 24;
            this.olvSelector.SelectAllOnControlA = false;
            this.olvSelector.ShowGroups = false;
            this.olvSelector.Size = new System.Drawing.Size(121, 97);
            this.olvSelector.TabIndex = 0;
            this.olvSelector.UseCompatibleStateImageBehavior = false;
            this.olvSelector.View = System.Windows.Forms.View.Details;
            this.olvSelector.Click += new System.EventHandler(this.olvSelector_Click);
            this.olvSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.olvSelector_KeyDown);
            this.olvSelector.MouseEnter += new System.EventHandler(this.olvSelector_MouseEnter);
            // 
            // olvSelectorMainColumn
            // 
            this.olvSelectorMainColumn.AspectName = "name";
            this.olvSelectorMainColumn.FillsFreeSpace = true;
            // 
            // FilterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 266);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FilterSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Filter";
            this.Load += new System.EventHandler(this.FilterSelector_Load);
            this.Shown += new System.EventHandler(this.FilterSelector_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterSelector_KeyDown);
            this.panelTabs.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabs;
        private DropdownButton.FlatButton flatButton1;
        private DropdownButton.FlatButton flatButton4;
        private DropdownButton.FlatButton flatButton3;
        private DropdownButton.FlatButton flatButton2;
        private System.Windows.Forms.Panel panelContent;
        private DropdownButton.FlatButton flatButton6;
        private DropdownButton.FlatButton flatButton5;
        private BrightIdeasSoftware.ObjectListView olvSelector;
        private BrightIdeasSoftware.OLVColumn olvSelectorMainColumn;


    }
}