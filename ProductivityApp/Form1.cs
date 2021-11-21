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
using Newtonsoft.Json;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProductivityApp
{
    public partial class Form1 : Form
    {
        private static Dictionary<int, string> monthInWords = new Dictionary<int, string>()
        {
            {1, "Janruary" },
            {2, "February" },
            {3, "March" },
            {4, "April" },
            {5, "May" },
            {6, "June" },
            {7, "July" },
            {8, "August" },
            {9, "September" },
            {10, "October" },
            {11, "November" },
            {12, "December" }
        };

        private static string allowedAppsFile = AppContext.BaseDirectory+"allowed_apps.json";
        private HomeInterface homeForm;

        public Form1(HomeInterface homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.newAgendaButton.BackColor = Color.FromArgb(25, 25, 25);
        }




        private void addAppsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            DialogResult file = o.ShowDialog();
            if (File.Exists(allowedAppsFile) && file == DialogResult.OK)
            {
                string fileName = o.FileName;

                HashSet<string> apps = new HashSet<string>(GetCurrentlyAllowedApps());
                apps.Add(fileName);
                string jsonVal = JsonConvert.SerializeObject(apps.ToArray());
                File.WriteAllText(allowedAppsFile, jsonVal);

                foreach(string appRoot in apps)
                {
                    AllowedApps.appNameInRoot.Add(GetAppName(appRoot), appRoot);
                }

            }

        }
        public static string GetAppName(string unparsedName)
        {
            int index = unparsedName.LastIndexOf("\\");
            return unparsedName.Substring(index + 1);
        }

        public static IList<string> GetCurrentlyAllowedApps()
        {
            if(new FileInfo(allowedAppsFile).Length == 0)
            {
                return new List<string>();
            }
            IList<string> currentlyAllowedApps = new List<string>();
            string jsonVal = File.ReadAllText(allowedAppsFile);

            JsonTextReader reader = new JsonTextReader(new StringReader(jsonVal));
            reader.SupportMultipleContent = true;
            JsonSerializer serializer = new JsonSerializer();
            currentlyAllowedApps = serializer.Deserialize<List<string>>(reader);
            return currentlyAllowedApps;
        }

        private void newAgendaButton_Click(object sender, EventArgs e)
        {
            EditAgendaForm agendaPage = new EditAgendaForm(homeForm);
            agendaPage.TopLevel = false;
            agendaPage.FormBorderStyle = FormBorderStyle.None;
            agendaPage.Dock = DockStyle.Fill;
            homeForm.panel1.Controls.Add(agendaPage);
            homeForm.panel1.Tag = agendaPage;
            agendaPage.BringToFront();
            agendaPage.Show();

            new Agenda();
        }

        private void seeAllowedApps_Click(object sender, EventArgs e)
        {
            AllowedApps allowedApps = new AllowedApps(homeForm);
            allowedApps.TopLevel = false;
            allowedApps.Dock = DockStyle.Fill;
            homeForm.panel1.Controls.Add(allowedApps);
            homeForm.panel1.Tag = allowedApps;
            allowedApps.BringToFront();
            allowedApps.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateTime.Text = monthInWords[now.Month]+" "+now.Day+", "+ now.Year;
        }

        private void newAgendaButton_MouseHover(object sender, EventArgs e)
        {
            this.newAgendaButton.ForeColor = Color.FromArgb(25, 25, 25);
            this.newAgendaButton.BackColor = Color.Gainsboro;
        }

        private void newAgendaButton_MouseLeave(object sender, EventArgs e)
        {
            this.newAgendaButton.BackColor = Color.FromArgb(25, 25, 25);
            this.newAgendaButton.ForeColor = Color.Gainsboro;
        }
    }
}
