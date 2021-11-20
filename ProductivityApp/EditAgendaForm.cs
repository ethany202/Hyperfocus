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
    public partial class EditAgendaForm : Form
    {

        public HomeInterface homePage;
        private Event newEvent;
        private HashSet<string> authorizedApps;
        private int minuteDisplay=0;
        private int hourDisplay=1;

        public EditAgendaForm(HomeInterface homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.newEvent = new Event();
            authorizedApps = new HashSet<string>();
        }

        private void back_Click(object sender, EventArgs e)
        {
            homePage.panel1.Controls.Remove(this);
        }

        private void addHour_Click(object sender, EventArgs e)
        {
            newEvent.IncreaseTimeFrame(60);
        }

        private void addMinute_Click(object sender, EventArgs e)
        {
            newEvent.IncreaseTimeFrame(10);
        }

        private void addEvent_Click(object sender, EventArgs e)
        {
            //this.allEvents.Items.Add()
            newEvent.SetAuthorizedApps(authorizedApps);
            authorizedApps = new HashSet<string>();
            GlobalSchedule.GetCurrentAgenda().GetAllEvents().Enqueue(newEvent);
            newEvent = new Event();
        }

        private void add1Min_Click(object sender, EventArgs e)
        {
            newEvent.IncreaseTimeFrame(1);
        }

        private void AddAuthorizedApps(string appReference)
        {
            authorizedApps.Add(appReference);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (GlobalSchedule.GetCurrentAgenda().GetAllEvents().Count != 0)
            {
                ArtificialDesktop focusMode = new ArtificialDesktop();
                focusMode.Show();
            }
            else
            {
                //show message
            }
            
        }
    }
}
