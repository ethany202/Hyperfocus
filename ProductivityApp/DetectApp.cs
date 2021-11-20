using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public class DetectApp
    {
        public DetectApp()
        {
            StartDetection();
        }

        public void StartDetection()
        {
            ActiveAppThread active = new ActiveAppThread();
            Thread activeThread = new Thread(active.StartThread);
            activeThread.Start();
            Dictionary<string, Double> a;
            while (true)
            {
                if (active.activeAppInfoCollector.focusedApp.Keys.Count > 20)
                {
                    a = active.activeAppInfoCollector.focusedApp;

                    break;
                }

                Thread.Sleep(1000);
            }
        }
    }
}
