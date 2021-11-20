using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public class Event
    {
        private double timeFrame; //In minutes
        private HashSet<string> authorizedApps;

        public Event()
        {
            authorizedApps = new HashSet<string>();
            timeFrame = 60;
        }

        public void IncreaseTimeFrame(double timeInterval)
        {
            this.timeFrame+=timeInterval;
            
        }

        public double GetTimeFrame()
        {
            return timeFrame;
        }

        public void SetAuthorizedApps(HashSet<string> authorizedApps)
        {
            this.authorizedApps = authorizedApps;
        }

    }
}
