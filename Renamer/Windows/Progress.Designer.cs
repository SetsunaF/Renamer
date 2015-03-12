namespace Renamer.Windows
{
    partial class Progress
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
            this.barProgress = new MetroFramework.Controls.MetroProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barProgress
            // 
            this.barProgress.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.barProgress.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.barProgress.HideProgressText = true;
            this.barProgress.Location = new System.Drawing.Point(16, 31);
            this.barProgress.Name = "barProgress";
            this.barProgress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barProgress.Size = new System.Drawing.Size(381, 23);
            this.barProgress.Style = MetroFramework.MetroColorStyle.Blue;
            this.barProgress.StyleManager = null;
            this.barProgress.TabIndex = 1;
            this.barProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.barProgress.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoEllipsis = true;
            this.labelCurrent.ForeColor = System.Drawing.Color.Gray;
            this.labelCurrent.Location = new System.Drawing.Point(16, 9);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(381, 18);
            this.labelCurrent.TabIndex = 4;
            this.labelCurrent.Text = "-";
            // 
            // ProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 68);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.barProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgressWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProgressWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroProgressBar barProgress;
        public System.ComponentModel.BackgroundWorker bgWorker;
        public System.Windows.Forms.Label labelCurrent;
    }
}