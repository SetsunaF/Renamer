namespace Renamer.Dialogs
{
    partial class NumberString
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
            this.labelNumber = new MetroFramework.Controls.MetroLabel();
            this.inputNumber = new System.Windows.Forms.NumericUpDown();
            this.labelText = new MetroFramework.Controls.MetroLabel();
            this.inputText = new System.Windows.Forms.TextBox();
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
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(13, 59);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(34, 14);
            this.labelText.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Text";
            this.labelText.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(16, 80);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(176, 23);
            this.inputText.TabIndex = 3;
            // 
            // NumberString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(208, 152);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.labelNumber);
            this.Name = "NumberString";
            this.Text = "NumberString";
            this.Controls.SetChildIndex(this.labelNumber, 0);
            this.Controls.SetChildIndex(this.inputNumber, 0);
            this.Controls.SetChildIndex(this.labelText, 0);
            this.Controls.SetChildIndex(this.inputText, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown inputNumber;
        public System.Windows.Forms.TextBox inputText;
        private MetroFramework.Controls.MetroLabel labelNumber;
        private MetroFramework.Controls.MetroLabel labelText;
    }
}