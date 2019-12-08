using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;
namespace BedsideSystem
{
    public partial class BedsideLoginScreen : Form
    {
        //set static value
        public static int bedside_patient_id = 0;
        public static int bedsideIDPass = 0;

        public BedsideLoginScreen()
        {
            InitializeComponent();
        }

        //do something when bedside login is load
        private void BedsideLogin_Load(object sender, EventArgs e)
        {
            //set assign panel width, height, location
            assignPanel.Width = 321;
            assignPanel.Height = 171;
            assignPanel.Location = new Point(437, 73);

            //set existing panel width, height, location
            existingPanel.Width = 321;
            existingPanel.Height = 171;
            existingPanel.Location = new Point(437, 73);

            //set showMenu panel width, height, location
            showMenuPanel.Width = 321;
            showMenuPanel.Height = 171;
            showMenuPanel.Location = new Point(437, 73);

            //showMenuPanel show when start
            showMenuPanel.Show();

            //existing panel hide when start
            existingPanel.Hide();
            assignPanel.Hide();
        }

        //assign bedside id to a patient
        private void proceedAssignBtn_Click(object sender, EventArgs e)
        {
            //if bedsideIdAssignComboBox selected index = 0, show warning message
            if (bedsideIdAssignComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid bedside id", "Bedside ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //patientIDAssignComboBox selected index = 0, show warning message
            if (patientIDAssignComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid patient id", "Patient ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //connect database
            DBConnector dbC = new DBConnector();
            dbC.connect();

            //get current bedside id when user selected the combo box items
            int bedsideId = int.Parse(bedsideIdAssignComboBox.SelectedItem.ToString());

            //get current patient id when user selected the combo box items
            int patientId = int.Parse(patientIDAssignComboBox.SelectedItem.ToString());

            //create new object bedside handler
            BedsideHandler bedsideHandler = new BedsideHandler();

            //assign a bedside id to a patient
            int assignResult = bedsideHandler.assignBedside(dbC.getConn(), bedsideId, patientId);

            //if assignresult return value = 1
            if (assignResult == 1)
            {
                //assign bedside id to patient
                int statusResult = bedsideHandler.updateStatus(dbC.getConn(), bedsideId);

                if (statusResult == 1)
                {
                    //static int field get value from patientId
                    bedside_patient_id = patientId;

                    //create new object bedside main screen
                    BedsideMainScreen ms = new BedsideMainScreen();

                    //show bedside main screen
                    ms.Show();

                    //close login screen
                    Close();
                }
                else
                {
                    //show error message if failed to access
                    MessageBox.Show("Failed to access", "Failed to access", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //show error message  if failed to access
                MessageBox.Show("Failed to access", "Failed to access", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //back to showMenupanel when assign panel opens
        private void backAssignBtn_Click(object sender, EventArgs e)
        {
            bedsideIdAssignComboBox.Items.Clear();
            patientIDAssignComboBox.Items.Clear();
            showMenuPanel.Show();
            existingPanel.Hide();
            assignPanel.Hide();
        }

        //back to showMenuPanel when existing panel opens
        private void backExistingBtn_Click(object sender, EventArgs e)
        {
            bedsideIdExistingComboBox.Items.Clear();
            showMenuPanel.Show();
            existingPanel.Hide();
            assignPanel.Hide();
        }

        //show existing panel
        private void existingBtn_Click(object sender, EventArgs e)
        {
            existingPanel.Show();
            showMenuPanel.Hide();
            assignPanel.Hide();

            //create object bedside handler 
            BedsideHandler bedsideHandler = new BedsideHandler();
            bool status = true;

            //get all bedside id currently assigned to patient
            bedsideHandler.FetchBedsideId(bedsideIdExistingComboBox, status);
            patientIdTextBox.Text = "";
        }

        //show assign panel
        private void assignBtn_Click(object sender, EventArgs e)
        {
            existingPanel.Hide();
            showMenuPanel.Hide();
            assignPanel.Show();

            //create object bedside handler 
            BedsideHandler bedsideHandler = new BedsideHandler();
            bool status = false;

            //get all bedside id currently not assigned to patient
            bedsideHandler.FetchBedsideId(bedsideIdAssignComboBox, status);
            bedsideHandler.FetchBedsidePatientId(patientIDAssignComboBox);
        }

        //change the patientIdtextbox when bedsideIdExistingComboBox_SelectedIndex is Changed
        private void bedsideIdExistingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BedsideHandler bedsideHandler = new BedsideHandler();
            DBConnector dbC = new DBConnector();
            dbC.connect();
            if(bedsideIdExistingComboBox.SelectedIndex != 0)
            {
                Patient existPatient = bedsideHandler.getSpecificPatientInBedside(dbC.getConn(), int.Parse(bedsideIdExistingComboBox.SelectedItem.ToString()));
                patientIdTextBox.Text = existPatient.Id.ToString();
            }
                 
        }

        //go to the bedside main screen when bedside id currently is assigned to the patient
        private void continueExistingBtn_Click(object sender, EventArgs e)
        {
            if(bedsideIdExistingComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid bedsideId");
                return;
            }
            BedsideHandler bedsideHandler = new BedsideHandler();
            DBConnector dbC = new DBConnector();
            dbC.connect();
            int bedsideId = int.Parse(bedsideIdExistingComboBox.SelectedItem.ToString());
            int patientId = int.Parse(patientIdTextBox.Text);
            bool status = bedsideHandler.continueBedside(dbC.getConn(), bedsideId, patientId);

            if (status)
            {
                bedside_patient_id = patientId;
                bedsideIDPass = bedsideId;
                BedsideMainScreen bedsideMainScreen = new BedsideMainScreen();
                bedsideMainScreen.Show();
                
                Close();
            }
        }
    }
}
