using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            HashSet<string> apps = new HashSet<string>(Form1.GetCurrentlyAllowedApps());
            foreach (string appRoot in apps)
            {
                AllowedApps.appNameInRoot.Add(Form1.GetAppName(appRoot), appRoot);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hyperfocus());
            //Application.Run(new ArtificialDesktop());
        }
    }
}
