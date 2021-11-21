using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;

namespace ProductivityApp
{
    public class ActiveAppThread
    {
        private string appName = "Idle";
        private bool stopThread = true;
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();
        [DllImport("user32")]
        private static extern UInt32 GetWindowThreadProcessId(Int32 hWnd, out Int32 lpdwProcessId);

        public ActiveAppInfoCollector activeAppInfoCollector;
        private string sentApp = "";
        public ActiveAppThread()
        {
            activeAppInfoCollector = new ActiveAppInfoCollector();
        }

        public void StopThread()
        {
            stopThread = false;
        }

        public void StartThread()
        {
            while (stopThread)
            {
                ActiveAppName();

                if (sentApp == "")
                {
                    sentApp = appName;
                    activeAppInfoCollector.ApplicationFocusStart(appName);
                }
                if (sentApp != appName)
                {
                    activeAppInfoCollector.ApplicationFocusEnd(sentApp);
                    activeAppInfoCollector.ApplicationFocusStart(appName);
                    sentApp = appName;
                }

                Thread.Sleep(1000);
            }
        }

        public string AppInfo
        {
            get { return appName; }
        }

        private Int32 GetWindowProcessID(Int32 handle)
        {
            Int32 aProcessID = 1;
            GetWindowThreadProcessId(handle, out aProcessID);
            return aProcessID;
        }

        private void ActiveAppName()
        {
            Int32 handle2 = 0;
            handle2 = GetForegroundWindow();
            try
            {
                appName = Process.GetProcessById(GetWindowProcessID(handle2)).MainModule.ModuleName;
            }
            catch (Exception x)
            {
                Debug.WriteLine(x);
            }

        }
    }
}
