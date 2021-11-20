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

        private string allowedAppsFile = "allowed_apps.json";
        private Rectangle initialSettingsBtn;
        private Rectangle initialAddAppsBtn;
        private float initialSettingsFontSize;
        private float initialAddAppsFontSize;

        private int formWidth;
        private int formHeight;

        private int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formHeight = this.Size.Height;
            formWidth = this.Size.Width;

            initialSettingsBtn = new Rectangle(settingsButton.Location.X, settingsButton.Location.Y, settingsButton.Width, settingsButton.Height);
            initialAddAppsBtn = new Rectangle(addAppsButton.Location.X, addAppsButton.Location.Y, addAppsButton.Width, addAppsButton.Height);
            initialSettingsFontSize = settingsButton.Font.Size;
            initialAddAppsFontSize = addAppsButton.Font.Size;
        }

        #region Button Click

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

        #endregion

        private void writeToAllowedApps(string jsonVal)
        {
            using(StreamWriter f = File.CreateText(allowedAppsFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(f, jsonVal);
            }
        }

        #region Resize Buttons

        private void ResizeAllButtons()
        {
            ResizeButton(initialSettingsBtn, settingsButton, initialSettingsFontSize);
            ResizeButton(initialAddAppsBtn, addAppsButton, initialAddAppsFontSize);            
        }

        private void ResizeButton(Rectangle originalButton, Control newButton, float fontSize)
        {
            float widthRatio = (float)(this.Width)/(float)(formWidth);
            float heightRatio = (float)(this.Height)/(float)(formHeight);

            int newX = (int)(originalButton.Location.X * widthRatio);
            int newY = (int)(originalButton.Location.Y * heightRatio);
            int newWidth = (int)(originalButton.Size.Width * widthRatio);
            int newHeight = (int)(originalButton.Size.Height * heightRatio);
            float newFontSize = fontSize * widthRatio;      //Font size is based on width of button

            if (count > 2)      //First 2 calls are ignored since Form is still being made
            {
                newButton.Location = new Point(newX, newY);
                newButton.Size = new Size(newWidth, newHeight);
                newButton.Font = new Font(newButton.Font.FontFamily, newFontSize);
            }
            count++;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeAllButtons();
        }

        #endregion

        #region Mouse Hover Animation

        private void settingsButton_MouseEnter(object sender, EventArgs e)
        {
            settingsButton.ForeColor = Color.White;
            settingsButton.BackColor = Color.Black;
        }

        private void settingsButton_MouseLeave(object sender, EventArgs e)
        {
            settingsButton.ForeColor = Color.Black;
            settingsButton.BackColor = Color.White;
        }

        private void addAppsButton_MouseEnter(object sender, EventArgs e)
        {
            addAppsButton.ForeColor = Color.White;
            addAppsButton.BackColor = Color.Black;
        }

        private void addAppsButton_MouseLeave(object sender, EventArgs e)
        {
            addAppsButton.ForeColor = Color.Black;
            addAppsButton.BackColor = Color.White;
        }

        #endregion
    }
}
