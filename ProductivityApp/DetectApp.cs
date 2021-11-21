using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ProductivityApp
{
    public class DetectApp : IDisposable
    {
        public DetectApp()
        {
            StartDetection();
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
                    if (active.activeAppInfoCollector.focusedApp.Keys.Count > 20)
                    {
                        a = active.activeAppInfoCollector.focusedApp;

                        break;
                    }
                    Debug.WriteLine(active.AppInfo);
                    Thread.Sleep(1000);
                }
            }).Start();
            

        }
    }
}
