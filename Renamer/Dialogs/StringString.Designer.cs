namespace Renamer.Dialogs
{
    partial class StringString
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
            this.buttonCancel = new DropdownButton.FlatButton();
            this.buttonOK = new DropdownButton.FlatButton();
            this.inputText1 = new System.Windows.Forms.TextBox();
            this.labelText1 = new MetroFramework.Controls.MetroLabel();
            this.inputText2 = new System.Windows.Forms.TextBox();
            this.labelText2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(107, 116);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 27);
            this.buttonCancel.Style = DropdownButton.Styles.Default;
            this.buttonCancel.TabIndex = 5;
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
            this.buttonOK.Location = new System.Drawing.Point(16, 116);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 27);
            this.buttonOK.Style = DropdownButton.Styles.Primary;
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // inputText1
            // 
            this.inputText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText1.Location = new System.Drawing.Point(16, 31);
            this.inputText1.Name = "inputText1";
            this.inputText1.Size = new System.Drawing.Size(177, 23);
            this.inputText1.TabIndex = 1;
            // 
            // labelText1
            // 
            this.labelText1.AutoSize = true;
            this.labelText1.Location = new System.Drawing.Point(13, 10);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(34, 14);
            this.labelText1.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelText1.TabIndex = 0;
            this.labelText1.Text = "Text";
            this.labelText1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // inputText2
            // 
            this.inputText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText2.Location = new System.Drawing.Point(16, 83);
            this.inputText2.Name = "inputText2";
            this.inputText2.Size = new System.Drawing.Size(177, 23);
            this.inputText2.TabIndex = 3;
            // 
            // labelText2
            // 
            this.labelText2.AutoSize = true;
            this.labelText2.Location = new System.Drawing.Point(13, 62);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(34, 14);
            this.labelText2.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelText2.TabIndex = 2;
            this.labelText2.Text = "Text";
            this.labelText2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // StringString
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(206, 154);
            this.Controls.Add(this.inputText2);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.inputText1);
            this.Controls.Add(this.labelText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StringString";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StringString";
            this.Load += new System.EventHandler(this.StringString_Load);
            this.Shown += new System.EventHandler(this.StringString_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DropdownButton.FlatButton buttonCancel;
        private DropdownButton.FlatButton buttonOK;
        public System.Windows.Forms.TextBox inputText1;
        private MetroFramework.Controls.MetroLabel labelText1;
        public System.Windows.Forms.TextBox inputText2;
        private MetroFramework.Controls.MetroLabel labelText2;
    }
}