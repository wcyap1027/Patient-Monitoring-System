using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Patient_Monitoring_System
{
    public partial class AlarmScreen : Form
    {
        public static int sessionId = 0;
        public AlarmScreen()
        {
            InitializeComponent();
        }

        private void confirmBtnAlarm_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bPMin.Text) || String.IsNullOrEmpty(bPMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the bloodpressure");
            }
            else
                if(String.IsNullOrEmpty(pulseMin.Text) || String.IsNullOrEmpty(pulseMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the pulse rate");
            }
            else
                if(String.IsNullOrEmpty(tempMin.Text) || String.IsNullOrEmpty(tempMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the temperature");
            }
            else
                if(String.IsNullOrEmpty(breathMin.Text) || String.IsNullOrEmpty(breathMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the breathing rate");
            }


            Reading reading = new Reading();
            reading.MinBloodPressure = double.Parse(bPMin.Text);
            reading.MaxBloodPressure = double.Parse(bPMax.Text);
            reading.MinPulse = double.Parse(pulseMin.Text);
            reading.MaxPulse = double.Parse(pulseMax.Text);
            reading.MinTemperature = double.Parse(tempMin.Text);
            reading.MaxTemperature = double.Parse(tempMax.Text);
            reading.MinBreathing = double.Parse(breathMin.Text);
            reading.MaxBreathing = double.Parse(breathMax.Text);

            DBConnector dbcon = new DBConnector();
            dbcon.connect();
            sessionId = bedside
            string query = 

        
        }

        private void resetAlarmBtn_Click(object sender, EventArgs e)
        {
            bPMin.Text = "";
            bPMax.Text = "";
            breathMin.Text = "";
            breathMax.Text = "";
            tempMin.Text = "";
            tempMax.Text = "";
            pulseMin.Text = "";
            pulseMax.Text = "";
        }
    }
}
