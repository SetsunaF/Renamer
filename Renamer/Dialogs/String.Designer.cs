namespace Renamer.Dialogs
{
    partial class String
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
            this.labelText = new MetroFramework.Controls.MetroLabel();
            this.inputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.Location = new System.Drawing.Point(16, 64);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.Location = new System.Drawing.Point(107, 64);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(13, 10);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(34, 14);
            this.labelText.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Text";
            this.labelText.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(16, 31);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(176, 23);
            this.inputText.TabIndex = 1;
            // 
            // String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(206, 102);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.labelText);
            this.Name = "String";
            this.Text = "StringInput";
            this.Controls.SetChildIndex(this.labelText, 0);
            this.Controls.SetChildIndex(this.inputText, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelText;
        public System.Windows.Forms.TextBox inputText;
    }
}