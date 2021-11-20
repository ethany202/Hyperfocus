using System;
using System.Collections.Generic;
using System.Text;


    class ActiveAppInfoCollector
    {
    public DateTime startTime;
    public Dictionary<string, Double> focusedApp;
    public ActiveAppInfoCollector()
    {
        focusedApp = new Dictionary<string, Double>();
        
    }
    public void ApplicationFocusStart(string appName)
    {
        startTime = DateTime.Now;
        if (!focusedApp.ContainsKey(appName))
        {
            focusedApp.Add(appName, 0);

        }
    }
    public void ApplicationFocusEnd(string appName)
    {
        //end timer; update seconds  
        TimeSpan elapsed = DateTime.Now - startTime;
        focusedApp[appName] = focusedApp[appName] + elapsed.TotalMilliseconds;
    }
}

