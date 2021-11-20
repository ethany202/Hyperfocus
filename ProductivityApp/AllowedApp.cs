using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp
{
    public class AllowedApp
    {
        private string appName;
        private double totalTime;

        public AllowedApp(string appName, double totalTime)
        {
            this.appName = getFileName(appName);
            this.totalTime = totalTime;
        }

        public string getFileName(string unparsedName)
        {
            int index = unparsedName.LastIndexOf("\\");
            return unparsedName.Substring(index);
        }
    }
}
