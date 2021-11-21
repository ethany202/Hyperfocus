using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class ArtificialDesktop : Form
    {

        private int authorizedAppCount;
        private DateTime startTime;
        private Agenda currentAgenda;
        private Event currentEvent;
        private DetectApp currentTracker;

        public ArtificialDesktop(DetectApp currentTracker)
        {
            InitializeComponent();
            startTime = DateTime.Now;
            currentAgenda = GlobalSchedule.GetCurrentAgenda();
            currentEvent = currentAgenda.GetAllEvents().Peek();
            authorizedAppCount = currentEvent.GetAuthorizedApps().Count;
            this.currentTracker = currentTracker;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan difference = DateTime.Now.Subtract(startTime);
            if (difference.TotalMinutes == currentEvent.GetTimeFrame())
            {
                this.Close();
                currentAgenda.GetAllEvents().Dequeue();
            }
        }
    }
}
