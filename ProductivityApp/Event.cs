using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public class Event
    {
        private double startTime;
        private double endTime;
        private HashSet<string> authorizedApps;

        public Event()
        {
            authorizedApps = new HashSet<string>();
        }

        public void SetStartTime(double startTime)
        {
            this.startTime = startTime;
            
        }

        public void SetEndTime(double endTime)
        {
            this.endTime = endTime;
        }
    }
}
