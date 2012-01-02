using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BlzServersControlPanel
{
    class MysqlHandler
    {
        public static void startMysql()
        {
            ProcessStartInfo mysqlStartInfo = new ProcessStartInfo();
            mysqlStartInfo.WorkingDirectory = "C:\\Development\\mysql\\bin";
            mysqlStartInfo.FileName = "mysqld.exe";
            mysqlStartInfo.UseShellExecute = true;

            Process.Start(mysqlStartInfo);
        }

        public static void stopMysql()
        {
            ProcessStartInfo mysqlAdminInfo = new ProcessStartInfo();
            mysqlAdminInfo.WorkingDirectory = "C:\\Development\\mysql\\bin";
            mysqlAdminInfo.FileName = "mysqladmin.exe";
            mysqlAdminInfo.Arguments = @"-u root -proot shutdown";
            mysqlAdminInfo.UseShellExecute = true;

            Process.Start(mysqlAdminInfo);
        }

        public static bool isMysqlRunning()
        {
            Process[] apacheProcesses = Process.GetProcessesByName("mysqld");

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
