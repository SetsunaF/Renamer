using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DropdownButton;

namespace Renamer.Windows
{
    public partial class FilterSelector : Form
    {
        public FilterSelector(Form parent)
        {
            InitializeComponent();

            this.Owner = parent;            
            this.Width = this.Owner.Width - 32;
            this.Height = 220;
        }

        private void FilterSelector_Load(object sender, EventArgs e)
        {
            var rectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = rectangle.Top - this.Top;
            this.Top = this.Owner.Top + titleHeight + 12;

            this.MinimumSize = this.Size;



            foreach (Panel panel in panelContent.Controls) panel.Dock = DockStyle.Fill;            
            ResetTabControl();

            foreach (FlatButton button in panelTabs.Controls)
            {                
                button.Click += (sd, ea) =>
                {                    
                    ResetTabControl();
                    button.Style = Styles.Primary;

                    string panelName = "panel"+button.Text.Replace(" ", string.Empty);
                    if (button.Tag != null) panelName = button.Tag.ToString();

                    (panelContent.Controls[panelName] as Panel).Visible = true;
                };
            }
        }

        private void ResetTabControl()
        {
            foreach (FlatButton button in panelTabs.Controls) button.Style = Styles.Default;
            foreach (Panel panel in panelContent.Controls) panel.Visible = false;            
        }

        
    }
}
