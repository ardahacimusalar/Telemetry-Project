namespace WindowsFormsApp1
{
    partial class AnaEkran
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
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblGear = new System.Windows.Forms.Label();
            this.lblTPS = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.lblVolt = new System.Windows.Forms.Label();
            this.prgRPM = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPorts
            // 
            this.cmbPorts.ForeColor = System.Drawing.Color.Black;
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(4, 61);
            this.cmbPorts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(159, 27);
            this.cmbPorts.TabIndex = 0;
            this.cmbPorts.SelectedIndexChanged += new System.EventHandler(this.cmbPorts_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(4, 111);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(101, 33);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "BAĞLAN";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(4, 169);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(101, 33);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "KES";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRPM.ForeColor = System.Drawing.Color.White;
            this.lblRPM.Location = new System.Drawing.Point(400, 255);
            this.lblRPM.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(83, 36);
            this.lblRPM.TabIndex = 3;
            this.lblRPM.Text = "0000";
            this.lblRPM.Click += new System.EventHandler(this.lblRPM_Click);
            // 
            // lblGear
            // 
            this.lblGear.AutoSize = true;
            this.lblGear.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGear.ForeColor = System.Drawing.Color.White;
            this.lblGear.Location = new System.Drawing.Point(395, 195);
            this.lblGear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGear.Name = "lblGear";
            this.lblGear.Size = new System.Drawing.Size(68, 64);
            this.lblGear.TabIndex = 4;
            this.lblGear.Text = "N";
            this.lblGear.Click += new System.EventHandler(this.lblGear_Click);
            // 
            // lblTPS
            // 
            this.lblTPS.AutoSize = true;
            this.lblTPS.ForeColor = System.Drawing.Color.White;
            this.lblTPS.Location = new System.Drawing.Point(238, 255);
            this.lblTPS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTPS.Name = "lblTPS";
            this.lblTPS.Size = new System.Drawing.Size(17, 19);
            this.lblTPS.TabIndex = 5;
            this.lblTPS.Text = "0";
            this.lblTPS.Click += new System.EventHandler(this.lblTPS_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.ForeColor = System.Drawing.Color.White;
            this.lblTemp.Location = new System.Drawing.Point(250, 160);
            this.lblTemp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(17, 19);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "0";
            this.lblTemp.Click += new System.EventHandler(this.lblTemp_Click);
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.ForeColor = System.Drawing.Color.White;
            this.lblMap.Location = new System.Drawing.Point(245, 228);
            this.lblMap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(17, 19);
            this.lblMap.TabIndex = 7;
            this.lblMap.Text = "0";
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // lblTiming
            // 
            this.lblTiming.AutoSize = true;
            this.lblTiming.ForeColor = System.Drawing.Color.White;
            this.lblTiming.Location = new System.Drawing.Point(263, 130);
            this.lblTiming.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(17, 19);
            this.lblTiming.TabIndex = 8;
            this.lblTiming.Text = "0";
            this.lblTiming.Click += new System.EventHandler(this.lblTiming_Click);
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.ForeColor = System.Drawing.Color.White;
            this.lblVolt.Location = new System.Drawing.Point(248, 195);
            this.lblVolt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(17, 19);
            this.lblVolt.TabIndex = 9;
            this.lblVolt.Text = "0";
            this.lblVolt.Click += new System.EventHandler(this.lblVolt_Click);
            // 
            // prgRPM
            // 
            this.prgRPM.ForeColor = System.Drawing.Color.White;
            this.prgRPM.Location = new System.Drawing.Point(391, 130);
            this.prgRPM.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.prgRPM.MaximumSize = new System.Drawing.Size(13334, 0);
            this.prgRPM.Name = "prgRPM";
            this.prgRPM.Size = new System.Drawing.Size(102, 10);
            this.prgRPM.TabIndex = 10;
            this.prgRPM.Click += new System.EventHandler(this.prgRPM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "TELEMETRY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "TIMING";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "VOLT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "TEMP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "TPS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "MAP";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "speed";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "rpm";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "gear";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(395, 151);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(68, 50);
            this.lblSpeed.TabIndex = 21;
            this.lblSpeed.Text = "00";
            this.lblSpeed.Click += new System.EventHandler(this.label11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "rpm bar";
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(662, 413);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgRPM);
            this.Controls.Add(this.lblVolt);
            this.Controls.Add(this.lblTiming);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblTPS);
            this.Controls.Add(this.lblGear);
            this.Controls.Add(this.lblRPM);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbPorts);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblRPM;
        private System.Windows.Forms.Label lblGear;
        private System.Windows.Forms.Label lblTPS;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblTiming;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.ProgressBar prgRPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label11;
    }
}