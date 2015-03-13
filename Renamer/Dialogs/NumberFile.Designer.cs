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
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.Location = new System.Drawing.Point(16, 113);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.Location = new System.Drawing.Point(107, 113);
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
            // NumberFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 156);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.labelNumber);
            this.Name = "NumberFile";
            this.Text = "NumberFile";
            this.Controls.SetChildIndex(this.labelNumber, 0);
            this.Controls.SetChildIndex(this.inputNumber, 0);
            this.Controls.SetChildIndex(this.labelFile, 0);
            this.Controls.SetChildIndex(this.inputFile, 0);
            this.Controls.SetChildIndex(this.buttonFile, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown inputNumber;
        private MetroFramework.Controls.MetroLabel labelNumber;
        private MetroFramework.Controls.MetroLabel labelFile;
        public System.Windows.Forms.OpenFileDialog fileDialog;
        public System.Windows.Forms.TextBox inputFile;
        private DropdownButton.FlatButton buttonFile;
    }
}