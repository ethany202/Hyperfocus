using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class AllowedApps : Form
    {

        private HomeInterface homePage;
        private string allowedAppsFile = AppContext.BaseDirectory + "allowed_apps.json";

        public AllowedApps(HomeInterface homePage)
        {
            this.homePage = homePage;
            InitializeComponent();
            
        }

        public void DisplayAllApps()
        {
            IList<string> allowedApps = Form1.GetCurrentlyAllowedApps();
            foreach(string appName in allowedApps)
            {
                Label current = new Label();
                //current.Location = new Point(xPos, 75);
                //curren
                string parsedName = Form1.GetAppName(appName);
                current.Text = parsedName;
                current.Size = new Size(15 * parsedName.Length, 15);
                this.panel1.Controls.Add(current);
            }
        }

        private void AllowedApps_Load(object sender, EventArgs e)
        {
            DisplayAllApps();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            homePage.panel1.Controls.Remove(this);
        }
    }
}
