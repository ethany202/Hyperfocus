using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
class DetectApp
    {
    static void Main(string[] args)
    {
        ActiveAppThread active = new ActiveAppThread();
        Thread activeThread = new Thread(active.StartThread);
        activeThread.Start();
        Dictionary<string, Double> a;
        while (true)
        {
            Console.WriteLine(active.AppInfo);
            if (active.activeAppInfoCollector.focusedApp.Keys.Count > 20)
            {
                a = active.activeAppInfoCollector.focusedApp;

                break;
            }

            Thread.Sleep(1000);
        }

        foreach (var i in a.Keys)
        {
            Console.WriteLine(i + "             " + a[i] / 1000);

        }
    }
}
