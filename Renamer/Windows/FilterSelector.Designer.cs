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
            this.flatButton1 = new DropdownButton.FlatButton();
            this.flatButton2 = new DropdownButton.FlatButton();
            this.flatButton3 = new DropdownButton.FlatButton();
            this.flatButton4 = new DropdownButton.FlatButton();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTabs.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTabs.Controls.Add(this.flatButton4);
            this.panelTabs.Controls.Add(this.flatButton3);
            this.panelTabs.Controls.Add(this.flatButton2);
            this.panelTabs.Controls.Add(this.flatButton1);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(574, 45);
            this.panelTabs.TabIndex = 0;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton1.FlatAppearance.BorderSize = 0;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.ForeColor = System.Drawing.Color.White;
            this.flatButton1.Location = new System.Drawing.Point(12, 9);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(85, 27);
            this.flatButton1.Style = DropdownButton.Styles.Default;
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Tag = "panelRed";
            this.flatButton1.Text = "flatButton1";
            this.flatButton1.UseVisualStyleBackColor = false;
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton2.FlatAppearance.BorderSize = 0;
            this.flatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton2.ForeColor = System.Drawing.Color.White;
            this.flatButton2.Location = new System.Drawing.Point(103, 9);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Size = new System.Drawing.Size(85, 27);
            this.flatButton2.Style = DropdownButton.Styles.Default;
            this.flatButton2.TabIndex = 1;
            this.flatButton2.Tag = "panelBlue";
            this.flatButton2.Text = "flatButton2";
            this.flatButton2.UseVisualStyleBackColor = false;
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton3.FlatAppearance.BorderSize = 0;
            this.flatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton3.ForeColor = System.Drawing.Color.White;
            this.flatButton3.Location = new System.Drawing.Point(194, 9);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Size = new System.Drawing.Size(85, 27);
            this.flatButton3.Style = DropdownButton.Styles.Default;
            this.flatButton3.TabIndex = 2;
            this.flatButton3.Text = "flatButton3";
            this.flatButton3.UseVisualStyleBackColor = false;
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.flatButton4.FlatAppearance.BorderSize = 0;
            this.flatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton4.ForeColor = System.Drawing.Color.White;
            this.flatButton4.Location = new System.Drawing.Point(285, 9);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Size = new System.Drawing.Size(85, 27);
            this.flatButton4.Style = DropdownButton.Styles.Default;
            this.flatButton4.TabIndex = 3;
            this.flatButton4.Text = "flatButton4";
            this.flatButton4.UseVisualStyleBackColor = false;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(28, 18);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(148, 100);
            this.panelRed.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(238, 18);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(200, 100);
            this.panelBlue.TabIndex = 2;
            this.panelBlue.Tag = "panelBlue";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelRed);
            this.panelContent.Controls.Add(this.panelBlue);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 45);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(574, 661);
            this.panelContent.TabIndex = 3;
            // 
            // FilterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 706);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FilterSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FilterSelector";
            this.Load += new System.EventHandler(this.FilterSelector_Load);
            this.panelTabs.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTabs;
        private DropdownButton.FlatButton flatButton1;
        private DropdownButton.FlatButton flatButton4;
        private DropdownButton.FlatButton flatButton3;
        private DropdownButton.FlatButton flatButton2;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelContent;


    }
}