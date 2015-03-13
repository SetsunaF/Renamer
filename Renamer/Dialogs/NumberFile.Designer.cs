namespace Renamer.Dialogs
{
    partial class NumberFile
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
            this.inputNumber = new System.Windows.Forms.NumericUpDown();
            this.labelNumber = new MetroFramework.Controls.MetroLabel();
            this.labelFile = new MetroFramework.Controls.MetroLabel();
            this.inputFile = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonFile = new DropdownButton.FlatButton();
            this.buttonCancel = new DropdownButton.FlatButton();
            this.buttonOK = new DropdownButton.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(16, 31);
            this.inputNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(120, 20);
            this.inputNumber.TabIndex = 1;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(13, 10);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(42, 14);
            this.labelNumber.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Value";
            this.labelNumber.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(13, 59);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(36, 14);
            this.labelFile.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "Path";
            this.labelFile.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // inputFile
            // 
            this.inputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFile.Location = new System.Drawing.Point(16, 80);
            this.inputFile.Name = "inputFile";
            this.inputFile.ReadOnly = true;
            this.inputFile.ShortcutsEnabled = false;
            this.inputFile.Size = new System.Drawing.Size(240, 23);
            this.inputFile.TabIndex = 3;
            // 
            // buttonFile
            // 
            this.buttonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFile.BackColor = System.Drawing.Color.DarkGray;
            this.buttonFile.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFile.FlatAppearance.BorderSize = 0;
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.ForeColor = System.Drawing.Color.White;
            this.buttonFile.Location = new System.Drawing.Point(262, 80);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(40, 23);
            this.buttonFile.Style = DropdownButton.Styles.Default;
            this.buttonFile.TabIndex = 4;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(107, 113);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 27);
            this.buttonCancel.Style = DropdownButton.Styles.Default;
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(16, 113);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 27);
            this.buttonOK.Style = DropdownButton.Styles.Primary;
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // NumberFile
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(314, 156);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.labelNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumberFile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NumberFile";
            this.Load += new System.EventHandler(this.NumberFile_Load);
            this.ResizeBegin += new System.EventHandler(this.NumberFile_ResizeBegin);
            this.Resize += new System.EventHandler(this.NumberFile_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DropdownButton.FlatButton buttonCancel;
        private DropdownButton.FlatButton buttonOK;
        public System.Windows.Forms.NumericUpDown inputNumber;
        private MetroFramework.Controls.MetroLabel labelNumber;
        private MetroFramework.Controls.MetroLabel labelFile;
        public System.Windows.Forms.OpenFileDialog fileDialog;
        public System.Windows.Forms.TextBox inputFile;
        private DropdownButton.FlatButton buttonFile;
    }
}