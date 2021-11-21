using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public class Agenda
    {
        private Queue<Event> allEvents;

        public Agenda()
        {
            allEvents = new Queue<Event>();
            GlobalSchedule.SetCurrentAgenda(this);
        }

        public Queue<Event> GetAllEvents()
        {
            return allEvents;
        }

        
    }
}
