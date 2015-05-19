namespace Renamer.Dialogs
{
    partial class NumberNumber
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
            this.inputNumber1 = new System.Windows.Forms.NumericUpDown();
            this.labelNumber1 = new MetroFramework.Controls.MetroLabel();
            this.inputNumber2 = new System.Windows.Forms.NumericUpDown();
            this.labelNumber2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOK.FlatAppearance.BorderSize = 0;
            this.buttonOK.Location = new System.Drawing.Point(16, 116);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.Location = new System.Drawing.Point(107, 116);
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(16, 31);
            this.inputNumber1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputNumber1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(120, 20);
            this.inputNumber1.TabIndex = 32;
            this.inputNumber1.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // labelNumber1
            // 
            this.labelNumber1.AutoSize = true;
            this.labelNumber1.Location = new System.Drawing.Point(13, 10);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(42, 14);
            this.labelNumber1.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelNumber1.TabIndex = 31;
            this.labelNumber1.Text = "Value";
            this.labelNumber1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // inputNumber2
            // 
            this.inputNumber2.Location = new System.Drawing.Point(16, 83);
            this.inputNumber2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputNumber2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.Size = new System.Drawing.Size(120, 20);
            this.inputNumber2.TabIndex = 34;
            this.inputNumber2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // labelNumber2
            // 
            this.labelNumber2.AutoSize = true;
            this.labelNumber2.Location = new System.Drawing.Point(13, 62);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(42, 14);
            this.labelNumber2.Style = MetroFramework.MetroColorStyle.Blue;
            this.labelNumber2.TabIndex = 33;
            this.labelNumber2.Text = "Value";
            this.labelNumber2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // NumberNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 154);
            this.Controls.Add(this.inputNumber2);
            this.Controls.Add(this.labelNumber2);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.labelNumber1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NumberNumber";
            this.Text = "NumberNumber";
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.labelNumber1, 0);
            this.Controls.SetChildIndex(this.inputNumber1, 0);
            this.Controls.SetChildIndex(this.labelNumber2, 0);
            this.Controls.SetChildIndex(this.inputNumber2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown inputNumber1;
        private MetroFramework.Controls.MetroLabel labelNumber1;
        public System.Windows.Forms.NumericUpDown inputNumber2;
        private MetroFramework.Controls.MetroLabel labelNumber2;
    }
}