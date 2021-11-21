using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class EditAgendaForm : Form
    {

        public Hyperfocus homePage;
        private Event newEvent;
        private HashSet<string> authorizedApps;
        private List<string> allowedAppsName;

        private HashSet<string> agendaAllApps;

        private Label[] eventApps;
        private int eventAppCount = 0;

        public EditAgendaForm(Hyperfocus homePage)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.textBox1.BackColor = Color.FromArgb(30, 30, 30);

            this.homePage = homePage;
            this.newEvent = new Event();
            authorizedApps = new HashSet<string>();
            agendaAllApps = new HashSet<string>();
            allowedAppsName = (List<string>)Form1.GetCurrentlyAllowedApps();
            PopulateListBox();
            PopulateEventLabels();

        }

        private void PopulateEventLabels()
        {
            eventApps = new Label[]{ currentApps, label4, label5, label6, label7, label8, label9, label10 };
        }

        private void back_Click(object sender, EventArgs e)
        {
            homePage.panel1.Controls.Remove(this);
        }

        private void addHour_Click(object sender, EventArgs e)
        {
            newEvent.IncreaseTimeFrame(60);
            UpdateTimeLabel();
        }

        private void addMinute_Click(object sender, EventArgs e)
        {
            //newEvent.IncreaseTimeFrame(10); 
            newEvent.IncreaseTimeFrame(10);
            UpdateTimeLabel();

        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            //this.allEvents.Items.Add()
            if (GlobalSchedule.GetCurrentAgenda().GetAllEvents().Count >= 5)
            {
                return;
            }
            AddEventNameLabel();
            AddTimeFrameLabel();
            ListAuthorizedApps();

            for(int i = 0; i < eventApps.Length; i++)
            {
                eventApps[i].Text = ":";
            }
            eventAppCount = 0;
            timeFrame.Text = "Time: 01 : 00";
            newEvent.SetAuthorizedApps(authorizedApps);
            authorizedApps = new HashSet<string>();
            GlobalSchedule.GetCurrentAgenda().GetAllEvents().Enqueue(newEvent);
            newEvent = new Event();
        }

        private void AddEventNameLabel()
        {
            Label eventName = new Label();
            eventName.Font = new Font(richTextBox1.Font.Name, 10); 
            eventName.Text = this.textBox1.Text;
            eventName.ForeColor = Color.Gainsboro;
            
            this.flowLayoutPanel1.Controls.Add(eventName);
        }

        private void AddTimeFrameLabel()
        {
            Label timeFrame = new Label();
            timeFrame.Font = new Font(richTextBox1.Font.Name, 10);
            timeFrame.Text = (newEvent.GetTimeFrame() + " minutes");
            timeFrame.ForeColor = Color.Gainsboro;
            this.flowLayoutPanel2.Controls.Add(timeFrame);
        }

        private void ListAuthorizedApps()
        {
           
            foreach(string appName in authorizedApps)
            {
                if (!agendaAllApps.Contains(appName))
                {
                    Label authorizedAppsLabel = new Label();
                    authorizedAppsLabel.Text += Form1.GetAppName(appName);
                    authorizedAppsLabel.ForeColor = Color.Gainsboro;
                    authorizedAppsLabel.Font = new Font(richTextBox1.Font.Name, 7);
                    this.flowLayoutPanel3.Controls.Add(authorizedAppsLabel);
                }
                agendaAllApps.Add(appName);
            }
            
        }

        private void AddAuthorizedApps(string appReference)
        {
            authorizedApps.Add(appReference);
        }

        private void minus10Min_Click(object sender, EventArgs e)
        {
            if (newEvent.GetMinutes() > 0)
            {
                //newEvent.IncreaseTimeFrame(-10);
                newEvent.IncreaseTimeFrame(-10);
                UpdateTimeLabel();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lowerHour_Click(object sender, EventArgs e)
        {
            if (newEvent.GetHours() > 0)
            {
                newEvent.IncreaseTimeFrame(-60);
                UpdateTimeLabel();
            }
        }

        private void UpdateTimeLabel()
        {
            string hour = newEvent.GetHours()+"";
            string minute = newEvent.GetMinutes()+"";

            if (hour.Length == 1)
                hour = "0"+hour;
            if (minute.Length == 1)
                minute = "0" + minute;

            this.timeFrame.Text = "Time: " + hour + " : " + minute;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text) == false)
            {
                listBox1.Items.Clear();
                foreach (string str in allowedAppsName)
                {

                    if (Form1.GetAppName(str).ToUpper().Contains(richTextBox1.Text.ToUpper()))
                    {
                        listBox1.Items.Add(Form1.GetAppName(str));
                    }
                }
            }
            else if (richTextBox1.Text == "")
            {
                listBox1.Items.Clear();
                PopulateListBox();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newEvent.SetEventName(textBox1.Text);
        }

        private void PopulateListBox()
        {
            foreach (string str in allowedAppsName)
            {
                listBox1.Items.Add(Form1.GetAppName(str));
            }
        }



        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gainsboro;
            textBox1.ForeColor = Color.FromArgb(30, 30, 30);

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.ForeColor = Color.Gainsboro;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string appName = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void addAuthorizedApp_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAppName = listBox1.GetItemText(listBox1.SelectedItem);
                if (authorizedApps.Contains(AllowedApps.appNameInRoot[selectedAppName]))
                {
                    return;
                }
                if (authorizedApps.Count < 8)
                {
                    AddAuthorizedApps(AllowedApps.appNameInRoot[selectedAppName]);
                    eventApps[eventAppCount].Text += selectedAppName;
                    eventAppCount++;
                }
                
            }

        }

        private void beginAgenda_Click(object sender, EventArgs e)
        {
            if (GlobalSchedule.GetCurrentAgenda().GetAllEvents().Count != 0)
            {
                ArtificialDesktop focusMode = new ArtificialDesktop();
                focusMode.Show();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
