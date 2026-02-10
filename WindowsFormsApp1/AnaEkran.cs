using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AnaEkran : Form
    {
        SerialPort serialPort;

        public AnaEkran()
        {
            InitializeComponent();
        }

        // Form Yüklendiğinde (Form Load)
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
            if (ports.Length > 0) cmbPorts.SelectedIndex = 0;
            btnDisconnect.Enabled = false;
        }

        // Bağlan Butonu
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPorts.SelectedItem == null) { MessageBox.Show("Port seç!"); return; }

                serialPort = new SerialPort(cmbPorts.SelectedItem.ToString(), 115200, Parity.None, 8, StopBits.One);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataReceived);
                serialPort.Open();

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                cmbPorts.Enabled = false;
                this.BackColor = Color.FromArgb(20, 30, 20); // Bağlanınca yeşilimsi olur
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        // Kes Butonu
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen) serialPort.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                cmbPorts.Enabled = true;
                this.BackColor = DefaultBackColor;
            }
            catch { }
        }

        // Veri Geldiğinde (Arka Planda Çalışır)
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string rawData = serialPort.ReadLine();
                this.Invoke(new MethodInvoker(delegate { ParseAndDisplay(rawData); }));
            }
            catch { }
        }

        // Veriyi Ekrana Yazma
        private void ParseAndDisplay(string data)
        {
            string[] values = data.Split(',');
            if (values.Length == 8)
            {
                lblRPM.Text = values[0];
                lblGear.Text = values[1];
                lblGear.Text = values[2] == "0" ? "N" : values[2];
                lblTPS.Text = "%" + values[3];
                lblTemp.Text = values[4] + " °C";
                lblMap.Text = values[5] + " kPa";
                lblTiming.Text = values[6] + "°";
                lblVolt.Text = values[7] + " V";

                int rpmVal = int.Parse(values[0]);
                if (rpmVal > 10000) rpmVal = 10000;
                prgRPM.Value = rpmVal;

                // Shift Light (9000 devir üstü kırmızı yazı)
                lblRPM.ForeColor = rpmVal > 9000 ? Color.Red : Color.Black;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblRPM_Click(object sender, EventArgs e)
        {

        }

        private void lblGear_Click(object sender, EventArgs e)
        {

        }

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void lblTiming_Click(object sender, EventArgs e)
        {

        }

        private void lblVolt_Click(object sender, EventArgs e)
        {

        }

        private void prgRPM_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTPS_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}