using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlzServersControlPanel
{
    public partial class frmControlPanel : Form
    {

        public frmControlPanel()
        {
            InitializeComponent();
            initServersStatus();
        }

        private void btnApache_Click(object sender, EventArgs e)
        {
            if (btnApache.Text == "Start")
            {
                btnApache.Text = "Stop";
                lblApacheStatus.Text = "Running...";
                lblApacheStatus.BackColor = System.Drawing.Color.PaleGreen;

                ApacheHandler.startApache();
                //C:\Development\Apache\bin\httpd.exe -w -f "C:\Development\Apache\conf\httpd.conf" -d "C:\Development\Apache\."
            }
            else if (btnApache.Text == "Stop")
            {
                btnApache.Text = "Start";
                lblApacheStatus.Text = "Stopped...";
                lblApacheStatus.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);

                ApacheHandler.stopApache();
            }
        }

        private void btnMysql_Click(object sender, EventArgs e)
        {
            if (btnMysql.Text == "Start")
            {
                btnMysql.Text = "Stop";
                lblMysqlStatus.Text = "Running...";
                lblMysqlStatus.BackColor = System.Drawing.Color.PaleGreen;

                MysqlHandler.startMysql();
            }
            else if (btnMysql.Text == "Stop")
            {
                btnMysql.Text = "Start";
                lblMysqlStatus.Text = "Stopped...";
                lblMysqlStatus.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);

                MysqlHandler.stopMysql();
            }
        }

        private void initServersStatus()
        {
            if (ApacheHandler.isApacheRunning()) 
            {
                btnApache.Text = "Stop";
                lblApacheStatus.Text = "Running...";
                lblApacheStatus.BackColor = System.Drawing.Color.PaleGreen;
            }

            if (MysqlHandler.isMysqlRunning())
            {
                btnMysql.Text = "Stop";
                lblMysqlStatus.Text = "Running...";
                lblMysqlStatus.BackColor = System.Drawing.Color.PaleGreen;
            }
        }
    }
}
