using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System.Handler;

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
            if(string.IsNullOrEmpty(bPMin.Text))
            {
                MessageBox.Show("Please enter a valid value to the bloodpressure");
                return;
            }

            if (string.IsNullOrEmpty(bPMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the bloodpressure");
                return;
            }

            if (string.IsNullOrEmpty(pulseMin.Text))
            {
                MessageBox.Show("Please enter a valid value to the pulse rate");
                return;
            }

            if (string.IsNullOrEmpty(pulseMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the pulse rate");
                return;
            }

            if (string.IsNullOrEmpty(tempMin.Text))
            {
                MessageBox.Show("Please enter a valid value to the temperature");
                return;
            }

            if (string.IsNullOrEmpty(tempMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the temperature");
                return;
            }

            if (string.IsNullOrEmpty(breathMin.Text))
            {
                MessageBox.Show("Please enter a valid value to the breathing rate");
                return;
            }

            if (string.IsNullOrEmpty(breathMax.Text))
            {
                MessageBox.Show("Please enter a valid value to the breathing rate");
                return;
            }
            
            if(double.Parse(bPMin.Text) > (double.Parse(bPMax.Text)))
            {
                MessageBox.Show("The minimum value must not bigger than maximum value");
                return;
            }

            if (double.Parse(pulseMin.Text) > (double.Parse(pulseMax.Text)))
            {
                MessageBox.Show("The minimum value must not bigger than maximum value");
                return;
            }

            if (double.Parse(tempMax.Text) > (double.Parse(tempMax.Text)))
            {
                MessageBox.Show("The minimum value must not bigger than maximum value");
                return;
            }

            if (double.Parse(breathMin.Text) > (double.Parse(breathMax.Text)))
            {
                MessageBox.Show("The minimum value must not bigger than maximum value");
                return;
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
            sessionId = BedsideSystem.BedsideLoginScreen.bedside_patient_id;
            ReadingHandler readingHandler = new ReadingHandler();
            bool status = readingHandler.checkExistsReading(dbcon.getConn(), sessionId);

            if (status)
            {
                int updateResult = readingHandler.updateReading(dbcon.getConn(), reading, sessionId);

                if(updateResult == 1)
                {
                    MessageBox.Show("The minimum and maximum value is up to date");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }

            }
            else
            {
                int result = readingHandler.addNewReading(dbcon.getConn(), reading, sessionId);

                if (result == 1)
                {
                    MessageBox.Show("The minimum and maximum value is ready to test");
                    Close();
                }
                else
                {
                    MessageBox.Show("The minimum and maximum value is not ready to test");
                }
            }
            
        
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

        //set textbox only allow number
        private void bPMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void bPMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void pulseMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void pulseMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void tempMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void tempMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void breathMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }

        private void breathMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Only allow number");
            }
        }
    }
}
