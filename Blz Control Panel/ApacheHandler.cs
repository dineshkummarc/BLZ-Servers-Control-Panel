using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BlzServersControlPanel
{
    class ApacheHandler
    {

        public static void startApache()
        {
            ProcessStartInfo apacheStartInfo = new ProcessStartInfo("C:\\Development\\Apache\\bin");
            apacheStartInfo.WorkingDirectory = "C:\\Development\\Apache\\bin";
            apacheStartInfo.FileName = "httpd.exe";
            apacheStartInfo.Arguments = @"-w -f C:\Development\Apache\conf\httpd.conf -d C:\Development\Apache\.";
            apacheStartInfo.UseShellExecute = true;
            apacheStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            Process.Start(apacheStartInfo);
        }

        public static void stopApache() 
        {
            Process[] apacheProcesses = Process.GetProcessesByName("httpd");

            foreach (Process p in apacheProcesses)
            {
                p.Kill();
            }
        }

        public static bool isApacheRunning()
        {
            Process[] apacheProcesses = Process.GetProcessesByName("httpd");

            if (apacheProcesses.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
