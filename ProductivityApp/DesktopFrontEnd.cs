using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class DesktopFrontEnd : Form
    {
        private int numAuthorized = 12;
        private int btnLength;

        private Button[] allowedApps;       //Stores data of each dynamic buttons

        public DesktopFrontEnd()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            allowedApps = new Button[numAuthorized];
        }

        private void DesktopFrontEnd_Load(object sender, EventArgs e)
        {
            btnLength = (int)(this.Size.Height * (0.10));       //Length of each button in proportion to Form size
            int margin = btnLength / 20;        //Margin between each button in proportion to button size

            for (int i = 0; i < numAuthorized; i++)     //Adds buttons to the panel
            {
                allowedApps[i] = new Button();
                allowedApps[i].Size = new Size(btnLength, btnLength);
                allowedApps[i].Click += new EventHandler(this.button_click);
                allowedApps[i].Margin = new Padding(margin, margin, margin, margin);
                allowedApps[i].Name = "Allowed App " + (i + 1);
                allowedApps[i].Text = "Button " + (i + 1);
                authorizedApp.Controls.Add(allowedApps[i]);
            }
        }

        #region Button Clicks

        private void button_click(object sender, EventArgs e)       //Runs when dynamic buttons are clicked
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Name + " says Hi");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "Exit Alert", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                MessageBox.Show("You have exited the desktop");
            }
            else if (exit == DialogResult.No)
            {
                MessageBox.Show("You have chosen to stay");
            }
        }

        #endregion
    }
}
