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
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            InitializeComponent();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            PatientScreen patientScreen = new PatientScreen();
            patientScreen.Show();
        }

        private void centralStationbtn_Click(object sender, EventArgs e)
        {
            central_station_screen centralStationScreen = new central_station_screen();
            centralStationScreen.Show();
        }
    }
}
