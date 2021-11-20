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
        private Rectangle initialAgendaBtn;
        private Rectangle initialPlusBtn;
        private Rectangle initialAppsBtn;
        private Rectangle initialExpandBtn;
        private Rectangle initialLabel;

        private float initialAgendaFontSize;
        private float initialPlusFontSize;
        private float initialAppsFontSize;
        private float initialExpandFontSize;
        private float initialLabelFontSize;

        private int formWidth;
        private int formHeight;

        private int count = 1;

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

            formHeight = this.Size.Height;
            formWidth = this.Size.Width;

            initialAgendaBtn = new Rectangle(newAgendaButton.Location.X, newAgendaButton.Location.Y, newAgendaButton.Width, newAgendaButton.Height);
            initialPlusBtn = new Rectangle(addAppsButton.Location.X, addAppsButton.Location.Y, addAppsButton.Width, addAppsButton.Height);
            initialAppsBtn = new Rectangle(seeAllowedApps.Location.X, seeAllowedApps.Location.Y, seeAllowedApps.Width, seeAllowedApps.Height);
            initialExpandBtn = new Rectangle(moreInfoButton.Location.X, moreInfoButton.Location.Y, moreInfoButton.Width, moreInfoButton.Height);
            initialLabel = new Rectangle(dateTime.Location.X, dateTime.Location.Y, dateTime.Width, dateTime.Height);

            initialAgendaFontSize = newAgendaButton.Font.Size;
            initialPlusFontSize = addAppsButton.Font.Size;
            initialAppsFontSize = seeAllowedApps.Font.Size;
            initialExpandFontSize = moreInfoButton.Font.Size;
            initialLabelFontSize = dateTime.Font.Size;
        }

        private void ResizeAllButtons()
        {
            ResizeButton(initialAgendaBtn, newAgendaButton, initialAgendaFontSize);
            ResizeButton(initialPlusBtn, addAppsButton, initialPlusFontSize);
            ResizeButton(initialAppsBtn, seeAllowedApps, initialAppsFontSize);
            ResizeButton(initialExpandBtn, moreInfoButton, initialExpandFontSize);
            ResizeButton(initialLabel, dateTime, initialLabelFontSize);
        }

        private void ResizeButton(Rectangle originalButton, Control newButton, float fontSize)
        {
            float widthRatio = (float)(this.Width) / (float)(formWidth);
            float heightRatio = (float)(this.Height) / (float)(formHeight);
            Console.WriteLine(formWidth);

            int newX = (int)(originalButton.Location.X * widthRatio);
            int newY = (int)(originalButton.Location.Y * heightRatio);
            int newWidth = (int)(originalButton.Size.Width * widthRatio);
            int newHeight = (int)(originalButton.Size.Height * heightRatio);
            float newFontSize = fontSize * widthRatio;      //Font size is based on width of button

            if (count > 15)      //First 15 calls are ignored since Form is still being made
            {
                newButton.Location = new Point(newX, newY);
                newButton.Size = new Size(newWidth, newHeight);
                newButton.Font = new Font(newButton.Font.FontFamily, newFontSize);
            }
            count++;
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            ResizeAllButtons();
        }

        private void moreInfoButton_MouseEnter(object sender, EventArgs e)
        {
            moreInfoButton.ForeColor = Color.White;
            moreInfoButton.BackColor = Color.Black;
        }

        private void moreInfoButton_MouseLeave(object sender, EventArgs e)
        {
            moreInfoButton.ForeColor = Color.Black;
            moreInfoButton.BackColor = Color.White;
        }

        private void addAppsButton_MouseEnter_1(object sender, EventArgs e)
        {
            addAppsButton.ForeColor = Color.White;
            addAppsButton.BackColor = Color.Black;
        }

        private void addAppsButton_MouseLeave_1(object sender, EventArgs e)
        {
            addAppsButton.ForeColor = Color.Black;
            addAppsButton.BackColor = Color.White;
        }

        private void seeAllowedApps_MouseEnter(object sender, EventArgs e)
        {
            seeAllowedApps.ForeColor = Color.White;
            seeAllowedApps.BackColor = Color.Black;
        }

        private void seeAllowedApps_MouseLeave(object sender, EventArgs e)
        {
            seeAllowedApps.ForeColor = Color.Black;
            seeAllowedApps.BackColor = Color.White;
        }

        private void newAgendaButton_MouseEnter(object sender, EventArgs e)
        {
            newAgendaButton.ForeColor = Color.White;
            newAgendaButton.BackColor = Color.Black;
        }

        private void newAgendaButton_MouseLeave(object sender, EventArgs e)
        {
            newAgendaButton.ForeColor = Color.Black;
            newAgendaButton.BackColor = Color.White;
        }
    }
}
