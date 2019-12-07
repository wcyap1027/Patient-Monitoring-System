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
    public partial class PatientProfileScreen : Form
    {
        
        public PatientProfileScreen()
        {
            InitializeComponent();
        }

        public string BedsideId 
        {
            get
            {
                return bedsideIdLabel.Text;
            }

            set
            {
                bedsideIdLabel.Text = value;
            }
            
        }
        public string PatientId
        {
            get
            {
                return patientIdLabel.Text;
            }

            set
            {
                patientIdLabel.Text = value;
            }

        }
        public string Age
        {
            get
            {
                return patientAGELabel.Text;
            }

            set
            {
                patientAGELabel.Text = value;
            }

        }
        public string PatientName
        {
            get
            {
                return patientNameLabel.Text;
            }

            set
            {
                patientNameLabel.Text = value;
            }

        }
        public string AlarmDetails
        {
            get
            {
                return alarmDetailsLabel.Text;
            }

            set
            {
                alarmDetailsLabel.Text = value;
            }

        }
        public string PatientNRIC
        {
            get
            {
                return patientNRICLabel.Text;
            }

            set
            {
                patientNRICLabel.Text = value;
            }

        }

        private void setAlarmBtn_Click(object sender, EventArgs e)
        {
            AlarmScreen alarmScreen = new AlarmScreen();
            alarmScreen.Show();
        }
    }
}
