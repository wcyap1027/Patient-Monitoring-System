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
        public static int bedside_patient_id = 0;

        public BedsideLoginScreen()
        {
            InitializeComponent();
        }

        

        private void BedsideLogin_Load(object sender, EventArgs e)
        {
            assignPanel.Width = 321;
            assignPanel.Height = 171;
            assignPanel.Location = new Point(437, 73);
            existingPanel.Width = 321;
            existingPanel.Height = 171;
            existingPanel.Location = new Point(437, 73);
            showMenuPanel.Width = 321;
            showMenuPanel.Height = 171;
            showMenuPanel.Location = new Point(437, 73);
            showMenuPanel.Show();
            existingPanel.Hide();
            assignPanel.Hide();
        }

        private void proceedAssignBtn_Click(object sender, EventArgs e)
        {
            if (bedsideIdAssignComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid bedside id");
                return;
            }

            if (patientIDAssignComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid patient id");
                return;
            }

            DBConnector dbC = new DBConnector();
            dbC.connect();
            int bedsideId = int.Parse(bedsideIdAssignComboBox.SelectedItem.ToString());
            int patientId = int.Parse(patientIDAssignComboBox.SelectedItem.ToString());
            BedsideHandler bedsideHandler = new BedsideHandler();
            int assignResult = bedsideHandler.assignBedside(dbC.getConn(), bedsideId, patientId);

            if (assignResult == 1)
            {
                int statusResult = bedsideHandler.updateStatus(dbC.getConn(), bedsideId);

                if (statusResult == 1)
                {
                    BedsideMainScreen ms = new BedsideMainScreen();
                    ms.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to access");
                }
            }
            else
            {
                MessageBox.Show("Failed to access");
            }
        }

        private void backAssignBtn_Click(object sender, EventArgs e)
        {
            bedsideIdAssignComboBox.Items.Clear();
            patientIDAssignComboBox.Items.Clear();
            showMenuPanel.Show();
            existingPanel.Hide();
            assignPanel.Hide();
        }

        private void backExistingBtn_Click(object sender, EventArgs e)
        {
            bedsideIdExistingComboBox.Items.Clear();
            showMenuPanel.Show();
            existingPanel.Hide();
            assignPanel.Hide();
        }

        private void existingBtn_Click(object sender, EventArgs e)
        {
            existingPanel.Show();
            showMenuPanel.Hide();
            assignPanel.Hide();
            BedsideHandler bedsideHandler = new BedsideHandler();
            bool status = true;
            bedsideHandler.FetchBedsideId(bedsideIdExistingComboBox, status);
            patientIdTextBox.Text = "";
        }

        private void assignBtn_Click(object sender, EventArgs e)
        {
            existingPanel.Hide();
            showMenuPanel.Hide();
            assignPanel.Show();
            BedsideHandler bedsideHandler = new BedsideHandler();
            bool status = false;
            bedsideHandler.FetchBedsideId(bedsideIdAssignComboBox, status);
            bedsideHandler.FetchBedsidePatientId(patientIDAssignComboBox);
        }

        private void bedsideIdExistingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BedsideHandler bedsideHandler = new BedsideHandler();
            DBConnector dbC = new DBConnector();
            dbC.connect();
            if(bedsideIdExistingComboBox.SelectedIndex != 0)
            {
                Patient existPatient = bedsideHandler.getSpecificPatientInBedside(dbC.getConn(), bedsideIdExistingComboBox.SelectedItem.ToString());
                patientIdTextBox.Text = existPatient.Id.ToString();
            }
            
             
        }

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
           
                BedsideMainScreen bedsideMainScreen = new BedsideMainScreen();
                bedsideMainScreen.Show();
                
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
