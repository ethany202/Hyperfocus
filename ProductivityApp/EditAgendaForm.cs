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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeFrame_Click(object sender, EventArgs e)
        {

        }

        private void minus10Min_Click(object sender, EventArgs e)
        {

        }
    }
}
