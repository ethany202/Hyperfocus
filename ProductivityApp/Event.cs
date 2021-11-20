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
        }

        public void SetTimeFrame(double timeFrame)
        {
            this.timeFrame = timeFrame;
            
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
