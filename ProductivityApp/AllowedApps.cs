using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class AllowedApps : Form
    {

        private Hyperfocus homePage;
        private string allowedAppsFile = Directory.GetCurrentDirectory()+"\\allowed_apps.json";
        public static Dictionary<string, string> appNameInRoot = new Dictionary<string, string>();

        public AllowedApps(Hyperfocus homePage)
        {
            this.homePage = homePage;
            InitializeComponent();
            this.backButton.BackColor = Color.FromArgb(30, 30, 30);
            this.BackColor = Color.FromArgb(30, 30, 30);
            
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
                current.Text = " - "+parsedName;
                current.Font = new Font(label1.Font.Name, 11);
                current.Size = new Size(current.Size.Width *3, current.Size.Height);
                current.Margin = new Padding(2, 2, 2, 2);

                current.ForeColor = Color.Gainsboro;
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

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Gainsboro;
            btn.ForeColor = Color.FromArgb(30, 30, 30);
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(30, 30, 30);
            btn.ForeColor = Color.Gainsboro;
        }
    }
}
