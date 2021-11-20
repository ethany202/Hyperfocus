using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class Form1 : Form
    {

        private string allowedAppsFile = "allowed_apps.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void addAppsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            DialogResult file = o.ShowDialog();
            if(file == DialogResult.OK)
            {
                string fileName = o.FileName;
                AllowedApp newApp = new AllowedApp(fileName, 0.0);
                string jsonVal = JsonConvert.SerializeObject(newApp);
                writeToAllowedApps(jsonVal);
            }

        }

        private void writeToAllowedApps(string jsonVal)
        {
            using(StreamWriter f = File.CreateText(allowedAppsFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(f, jsonVal);
            }
        }
    }
}
