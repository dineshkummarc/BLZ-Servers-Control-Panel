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

            notifyIcon.Icon = TrayIcons.off_off;

            Rectangle screenRes = Screen.PrimaryScreen.WorkingArea;
            int left = screenRes.Width - this.Width;
            int top = screenRes.Height - this.Height;

            this.Location = new Point(left - 10, top - 10);
        }

        private void btnApache_Click(object sender, EventArgs e)
        {
            if (btnApache.Text == "Start")
            {
                if (!ApacheHandler.isApacheRunning())
                {
                    btnApache.Text = "Stop";
                    lblApacheStatus.Text = "Running...";
                    lblApacheStatus.BackColor = System.Drawing.Color.PaleGreen;
                                   
                    ApacheHandler.startApache();
                    if (MysqlHandler.isMysqlRunning())
                    {
                        notifyIcon.Icon = TrayIcons.on_on;
                    }
                    else
                    {
                        notifyIcon.Icon = TrayIcons.on_off;
                    }
                    //C:\Development\Apache\bin\httpd.exe -w -f "C:\Development\Apache\conf\httpd.conf" -d "C:\Development\Apache\."
                }
            }
            else if (btnApache.Text == "Stop")
            {
                if (ApacheHandler.isApacheRunning())
                {
                    btnApache.Text = "Start";
                    lblApacheStatus.Text = "Stopped...";
                    lblApacheStatus.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
                                    
                    ApacheHandler.stopApache();
                    if (MysqlHandler.isMysqlRunning())
                    {
                        notifyIcon.Icon = TrayIcons.off_on;
                    }
                    else
                    {
                        notifyIcon.Icon = TrayIcons.off_off;
                    }
                }
            }
        }

        private void btnMysql_Click(object sender, EventArgs e)
        {
            if (btnMysql.Text == "Start")
            {
                if (!MysqlHandler.isMysqlRunning())
                {
                    btnMysql.Text = "Stop";
                    lblMysqlStatus.Text = "Running...";
                    lblMysqlStatus.BackColor = System.Drawing.Color.PaleGreen;
                                    
                    MysqlHandler.startMysql();
                    if (ApacheHandler.isApacheRunning())
                    {
                        notifyIcon.Icon = TrayIcons.on_on;
                    }
                    else 
                    {
                        notifyIcon.Icon = TrayIcons.off_on;
                    }
                }
            }
            else if (btnMysql.Text == "Stop")
            {
                if (MysqlHandler.isMysqlRunning())
                {
                    btnMysql.Text = "Start";
                    lblMysqlStatus.Text = "Stopped...";
                    lblMysqlStatus.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);

                    MysqlHandler.stopMysql();
                    if (ApacheHandler.isApacheRunning())
                    {
                        notifyIcon.Icon = TrayIcons.on_off;
                    }
                    else
                    {
                        notifyIcon.Icon = TrayIcons.off_off;
                    }
                }
            }
        }

        private void initServersStatus()
        {
            if (ApacheHandler.isApacheRunning()) 
            {
                btnApache.Text = "Stop";
                lblApacheStatus.Text = "Running...";
                lblApacheStatus.BackColor = System.Drawing.Color.PaleGreen;
                notifyIcon.Icon = TrayIcons.on_off;
            }

            if (MysqlHandler.isMysqlRunning())
            {
                btnMysql.Text = "Stop";
                lblMysqlStatus.Text = "Running...";
                lblMysqlStatus.BackColor = System.Drawing.Color.PaleGreen;
                notifyIcon.Icon = TrayIcons.off_on;
            }

            if (ApacheHandler.isApacheRunning() && MysqlHandler.isMysqlRunning())
            {
                notifyIcon.Icon = TrayIcons.on_on;
            }
        }

        private void showForm()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showForm();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void frmControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showForm();
        }
    }
}
