using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ProductivityApp
{
    public class DetectApp : IDisposable
    {

        private string previousApp;
        private string openedApp;

        public DetectApp()
        {
            StartDetection();
            previousApp = "None";
            openedApp = "None";
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void StartDetection()
        {
            new Thread(() =>
            {
                
                ActiveAppThread active = new ActiveAppThread();
                Thread activeThread = new Thread(active.StartThread);
                activeThread.Start();
                Dictionary<string, Double> a;
                while (true)
                {
                    previousApp = openedApp;
                    openedApp = active.AppInfo;
                    if (active.activeAppInfoCollector.focusedApp.Keys.Count > 20)
                    {
                        a = active.activeAppInfoCollector.focusedApp;

                        break;
                    }
                    Thread.Sleep(1000);
                }
            }).Start();
            

        }

        public string GetPreviousApp()
        {
            return previousApp;
        }

        public string GetOpenedApp()
        {
            return openedApp;

        }
    }
}
