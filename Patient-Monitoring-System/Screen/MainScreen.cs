using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System.Screen;
using Patient_Monitoring_System.Handler;

namespace Patient_Monitoring_System
{
    public partial class MainScreen : Form
    {
        //set static value
        public static string mainScreenUserIdStatic;
        public static string mainScreenUserDepartment;
        public MainScreen()
        {
            InitializeComponent();
        }

        //go to patient screen
        private void patientButton_Click(object sender, EventArgs e)
        {
            PatientScreen patientScreen = new PatientScreen();
            patientScreen.Show();
        }

        //go to central station screen
        private void centralStationbtn_Click(object sender, EventArgs e)
        {
            central_station_screen centralStationScreen = new central_station_screen();
            centralStationScreen.Show();
        }
        
        //go to bedside
        private void bedsideBtn_Click(object sender, EventArgs e)
        {
            BedsideScreen bedsideScreen = new BedsideScreen();
            bedsideScreen.Show();
        }

        //current user log out
        private void logOutbtn_Click(object sender, EventArgs e)
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            mainScreenUserIdStatic = Login.userIdStatic;
            mainScreenUserDepartment = Login.userDepartment;
            UserHandler userHandler = new UserHandler();
            int id = userHandler.FindUserId(dBConn.getConn(), mainScreenUserDepartment, mainScreenUserIdStatic);
            bool status = userHandler.Logout(dBConn.getConn(), id);

            if (status)
            {
                MessageBox.Show("Log Out Successfully");
                Login login = new Login();
                login.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Log Out Failed");
            }
        }
    }
}
