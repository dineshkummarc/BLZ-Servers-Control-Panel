namespace BlzServersControlPanel
{
    partial class frmControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApache = new System.Windows.Forms.Label();
            this.lblMysql = new System.Windows.Forms.Label();
            this.btnApache = new System.Windows.Forms.Button();
            this.btnMysql = new System.Windows.Forms.Button();
            this.lblApacheStatus = new System.Windows.Forms.Label();
            this.lblMysqlStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApache
            // 
            this.lblApache.AutoSize = true;
            this.lblApache.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblApache.Location = new System.Drawing.Point(10, 14);
            this.lblApache.Name = "lblApache";
            this.lblApache.Size = new System.Drawing.Size(49, 15);
            this.lblApache.TabIndex = 0;
            this.lblApache.Text = "Apache";
            // 
            // lblMysql
            // 
            this.lblMysql.AutoSize = true;
            this.lblMysql.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMysql.Location = new System.Drawing.Point(10, 44);
            this.lblMysql.Name = "lblMysql";
            this.lblMysql.Size = new System.Drawing.Size(42, 15);
            this.lblMysql.TabIndex = 1;
            this.lblMysql.Text = "Mysql";
            // 
            // btnApache
            // 
            this.btnApache.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnApache.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApache.Location = new System.Drawing.Point(65, 10);
            this.btnApache.Name = "btnApache";
            this.btnApache.Size = new System.Drawing.Size(75, 23);
            this.btnApache.TabIndex = 2;
            this.btnApache.TabStop = false;
            this.btnApache.Text = "Start";
            this.btnApache.UseVisualStyleBackColor = false;
            this.btnApache.Click += new System.EventHandler(this.btnApache_Click);
            // 
            // btnMysql
            // 
            this.btnMysql.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMysql.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMysql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMysql.Location = new System.Drawing.Point(65, 40);
            this.btnMysql.Name = "btnMysql";
            this.btnMysql.Size = new System.Drawing.Size(75, 23);
            this.btnMysql.TabIndex = 3;
            this.btnMysql.TabStop = false;
            this.btnMysql.Text = "Start";
            this.btnMysql.UseVisualStyleBackColor = false;
            this.btnMysql.Click += new System.EventHandler(this.btnMysql_Click);
            // 
            // lblApacheStatus
            // 
            this.lblApacheStatus.AutoEllipsis = true;
            this.lblApacheStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblApacheStatus.Location = new System.Drawing.Point(155, 10);
            this.lblApacheStatus.Name = "lblApacheStatus";
            this.lblApacheStatus.Size = new System.Drawing.Size(56, 23);
            this.lblApacheStatus.TabIndex = 4;
            this.lblApacheStatus.Text = "Stopped...";
            this.lblApacheStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMysqlStatus
            // 
            this.lblMysqlStatus.AutoEllipsis = true;
            this.lblMysqlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMysqlStatus.Location = new System.Drawing.Point(155, 40);
            this.lblMysqlStatus.Name = "lblMysqlStatus";
            this.lblMysqlStatus.Size = new System.Drawing.Size(56, 23);
            this.lblMysqlStatus.TabIndex = 5;
            this.lblMysqlStatus.Text = "Stopped...";
            this.lblMysqlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 74);
            this.Controls.Add(this.lblMysqlStatus);
            this.Controls.Add(this.lblApacheStatus);
            this.Controls.Add(this.btnMysql);
            this.Controls.Add(this.btnApache);
            this.Controls.Add(this.lblMysql);
            this.Controls.Add(this.lblApache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmControlPanel";
            this.Text = "Server Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApache;
        private System.Windows.Forms.Label lblMysql;
        private System.Windows.Forms.Button btnApache;
        private System.Windows.Forms.Button btnMysql;
        private System.Windows.Forms.Label lblApacheStatus;
        private System.Windows.Forms.Label lblMysqlStatus;
    }
}

