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

namespace ProductivityApp
{
    public partial class Form1 : Form
    {

        private string allowedAppsFile = AppContext.BaseDirectory+"allowed_apps.json";
        private HomeInterface homeForm;

        public Form1(HomeInterface homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

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
            }

        }
        public string GetFileName(string unparsedName)
        {
            int index = unparsedName.LastIndexOf("\\");
            return unparsedName.Substring(index + 1);
        }

        public IList<string> GetCurrentlyAllowedApps()
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
    }
}
