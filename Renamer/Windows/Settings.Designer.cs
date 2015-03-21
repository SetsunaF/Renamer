namespace Renamer.Windows
{
    partial class Settings
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
            this.checkBoxSaveLastProfile = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableContextMenu = new System.Windows.Forms.CheckBox();
            this.checkBoxSavePreviousFilenames = new System.Windows.Forms.CheckBox();
            this.buttonOK = new DropdownButton.FlatButton();
            this.buttonCancel = new DropdownButton.FlatButton();
            this.SuspendLayout();
            // 
            // checkBoxSaveLastProfile
            // 
            this.checkBoxSaveLastProfile.AutoSize = true;
            this.checkBoxSaveLastProfile.Enabled = false;
            this.checkBoxSaveLastProfile.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxSaveLastProfile.Location = new System.Drawing.Point(13, 13);
            this.checkBoxSaveLastProfile.Name = "checkBoxSaveLastProfile";
            this.checkBoxSaveLastProfile.Size = new System.Drawing.Size(164, 17);
            this.checkBoxSaveLastProfile.TabIndex = 0;
            this.checkBoxSaveLastProfile.Text = "Automatically save last profile";
            this.checkBoxSaveLastProfile.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableContextMenu
            // 
            this.checkBoxEnableContextMenu.AutoSize = true;
            this.checkBoxEnableContextMenu.Enabled = false;
            this.checkBoxEnableContextMenu.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxEnableContextMenu.Location = new System.Drawing.Point(13, 37);
            this.checkBoxEnableContextMenu.Name = "checkBoxEnableContextMenu";
            this.checkBoxEnableContextMenu.Size = new System.Drawing.Size(192, 17);
            this.checkBoxEnableContextMenu.TabIndex = 1;
            this.checkBoxEnableContextMenu.Text = "Enable context menu on directories";
            this.checkBoxEnableContextMenu.UseVisualStyleBackColor = true;
            // 
            // checkBoxSavePreviousFilenames
            // 
            this.checkBoxSavePreviousFilenames.AutoSize = true;
            this.checkBoxSavePreviousFilenames.Enabled = false;
            this.checkBoxSavePreviousFilenames.ForeColor = System.Drawing.Color.DimGray;
            this.checkBoxSavePreviousFilenames.Location = new System.Drawing.Point(13, 61);
            this.checkBoxSavePreviousFilenames.Name = "checkBoxSavePreviousFilenames";
            this.checkBoxSavePreviousFilenames.Size = new System.Drawing.Size(203, 17);
            this.checkBoxSavePreviousFilenames.TabIndex = 2;
            this.checkBoxSavePreviousFilenames.Text = "Save previous filenames after rename";
            this.checkBoxSavePreviousFilenames.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(106, 93);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 27);
            this.buttonOK.Style = DropdownButton.Styles.Primary;
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(197, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 27);
            this.buttonCancel.Style = DropdownButton.Styles.Default;
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(294, 132);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.checkBoxSavePreviousFilenames);
            this.Controls.Add(this.checkBoxEnableContextMenu);
            this.Controls.Add(this.checkBoxSaveLastProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSaveLastProfile;
        private System.Windows.Forms.CheckBox checkBoxEnableContextMenu;
        private System.Windows.Forms.CheckBox checkBoxSavePreviousFilenames;
        private DropdownButton.FlatButton buttonOK;
        private DropdownButton.FlatButton buttonCancel;
    }
}