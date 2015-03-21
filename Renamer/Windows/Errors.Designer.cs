namespace Renamer.Windows
{
    partial class Errors
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
            this.labelError = new MetroFramework.Controls.MetroLabel();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.buttonOK = new DropdownButton.FlatButton();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(9, 14);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(38, 14);
            this.labelError.Style = MetroFramework.MetroColorStyle.Red;
            this.labelError.TabIndex = 0;
            this.labelError.Text = "Error";
            this.labelError.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labelError.UseStyleColors = true;
            // 
            // textMessage
            // 
            this.textMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMessage.Location = new System.Drawing.Point(12, 35);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMessage.Size = new System.Drawing.Size(440, 138);
            this.textMessage.TabIndex = 2;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.BackColor = System.Drawing.Color.Crimson;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(367, 183);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 27);
            this.buttonOK.Style = DropdownButton.Styles.Danger;
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Errors
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.buttonOK;
            this.ClientSize = new System.Drawing.Size(464, 222);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.labelError);
            this.MinimizeBox = false;
            this.Name = "Errors";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ErrorList";
            this.Load += new System.EventHandler(this.ErrorList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DropdownButton.FlatButton buttonOK;
        public MetroFramework.Controls.MetroLabel labelError;
        public System.Windows.Forms.TextBox textMessage;
    }
}