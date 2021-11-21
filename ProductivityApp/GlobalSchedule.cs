using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public class GlobalSchedule
    {
        private static Agenda currentAgenda;
        public static Agenda GetCurrentAgenda()
        {
            return currentAgenda;
        }

        public static void SetCurrentAgenda(Agenda yes)
        {
            currentAgenda = yes;
        }



    }
}
