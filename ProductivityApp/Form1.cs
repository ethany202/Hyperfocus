using Newtonsoft.Json;
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
    public partial class Form1 : Form
    {

        //private string allowedAppsFile = "allowed_apps.json";
        private Rectangle originalSettingsBtn;

        private Size originalFormSize = new Size(900, 900);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize.Height = this.Size.Height;
            originalFormSize.Width = this.Size.Width;

            originalSettingsBtn = new Rectangle(settingsButton.Location.X, settingsButton.Location.Y, settingsButton.Width, settingsButton.Height);
            resizeControl();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void addAppsButton_Click(object sender, EventArgs e)
        {
            /*
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
            */

        }

        /*private void writeToAllowedApps(string jsonVal)
        {
            using(StreamWriter f = File.CreateText(allowedAppsFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(f, jsonVal);
            }
        }*/

        /*private void resizeChildrenControls() 
        {
            resizeControl(originalSettingsBtn, settingsButton);
        }*/

        private void resizeControl()
        {
            Debug.WriteLine(originalFormSize);
            float xRatio = (float)(this.Width)/(float)(originalFormSize.Width);
            float yRatio = (float)(this.Height)/(float)(originalFormSize.Height);

            int newX = (int)(originalSettingsBtn.Location.X * xRatio);
            int newY = (int)(originalSettingsBtn.Location.Y * yRatio);
            //int newWidth = (int)(originalControlRect.Size.Width * xRatio);
            //int newHeight = (int)(originalControlRect.Size.Height * yRatio);

            settingsButton.Location = new Point(newX, newY);
            //control.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl();
        }
    }
}
