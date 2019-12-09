using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace Manager
{
    public partial class ManagerMainScreen : Form
    {
        public static int patient_alarm_id = 0;

        public ManagerMainScreen()
        {
            InitializeComponent();
        }

        private void ManagerMainScreen_Load(object sender, EventArgs e)
        {
            panelInformationPanel.Hide();
            panel2.Hide();
            panel3.Hide();

            panelInformationPanel.Width = 627;
            panelInformationPanel.Height = 361;
            panelInformationPanel.Location = new Point(12, 171);
            panel2.Width = 627;
            panel2.Height = 361;
            panel2.Location = new Point(12, 171);
            panel3.Width = 627;
            panel3.Height = 361;
            panel3.Location = new Point(12, 171);
        }

        private void staffScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSchedule staffSchedule = new StaffSchedule();
            staffSchedule.ShowDialog();
            this.Close();
        }


        private void patientInformationBtn_Click(object sender, EventArgs e)
        {
            panelInformationPanel.Show();
            panel2.Hide();
            panel3.Hide();
            DbConnector dBConn = new DbConnector();
            dBConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            patientHandler.FetchId(patientIDcomboBox);
            
        }

        private void FetchTableName(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Clear();
            selectedcomboBox.Items.Add("--Select Table Name--");
            selectedcomboBox.Items.Add("BloodPressure");
            selectedcomboBox.Items.Add("BreathingRate");
            selectedcomboBox.Items.Add("PulseRate");
            selectedcomboBox.Items.Add("Temperature");
            selectedcomboBox.SelectedIndex = 0;
        }

        private void readingBtn_Click(object sender, EventArgs e)
        {
            panelInformationPanel.Hide();
            panel2.Hide();
            panel3.Show();
            DbConnector dBConn = new DbConnector();
            dBConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            patientHandler.FetchId(patientIDcb);
            FetchTableName(optional1ComboBox);
            //FetchTableName(optional2ComboBox);
            //FetchTableName(optional3ComboBox);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            PatientHandler patientHandler = new PatientHandler();

            int patientId = int.Parse(patientIDcomboBox.Text);

            bool status = patientHandler.checkPatientID(dbConn.getConn(), patientId);

            if (status)
            {
                patientGridView.DataSource = patientHandler.getSpecificPatientList(dbConn.getConn(), patientIDcomboBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        

        private void resetBtn_Click(object sender, EventArgs e)
        {
            patientIDcomboBox.Text = "";
        }

        private void alarmReportBtn_Click(object sender, EventArgs e)
        {
            panelInformationPanel.Hide();
            panel2.Show();
            panel3.Hide();
            DbConnector dBConn = new DbConnector();
            dBConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            
            patientHandler.FetchId(patientComboBox);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            patientIDcomboBox.Text = "";
        }

        private void patientIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(patientIDcomboBox.SelectedIndex > 0)
            {
                DbConnector dbConn = new DbConnector();
                dbConn.connect();
                PatientHandler patientHandler = new PatientHandler();

                patientGridView.DataSource = patientHandler.getSpecificPatientList(dbConn.getConn(), patientIDcomboBox.SelectedItem.ToString());
            }
           

        }

        private void patientIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewB_Click(object sender, EventArgs e)
        {
            if(patientIDcb.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid Id");
                return;
            }

            if(patientIDcb.SelectedIndex > 0)
            {
                DbConnector dbConn = new DbConnector();
                dbConn.connect();
                PatientHandler patientHandler = new PatientHandler();
                int patientId = int.Parse(patientIDcb.SelectedItem.ToString());
                bool status = patientHandler.checkPatientID(dbConn.getConn(), patientId);
                string selected1 = optional1ComboBox.SelectedItem.ToString().ToLower();

                if (status)
                {
                    if(optional1ComboBox.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please select valid value for reading");
                        return;
                    }
                    if (optional1ComboBox.SelectedIndex > 0)
                    {
                        readingGridView.DataSource = patientHandler.patientWithOptional(dbConn.getConn(), patientId, selected1);
                    }

                }
                else
                {
                    MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

        }

        private void readingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void option1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (patientComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid patient id");
                return;
            }

            //if (AlarmIDcomboBox.SelectedIndex == 0)
            //{
            //    MessageBox.Show("Please select valid alarm id");
            //    return;
            //}

            DBConnector dbC = new DBConnector();
            dbC.connect();
            int patientId = int.Parse(patientComboBox.SelectedItem.ToString());
            //int alarmId = int.Parse(AlarmIDcomboBox.SelectedItem.ToString());
            AlarmHandler alarmhd = new AlarmHandler();
            AlarmGridView.DataSource = alarmhd.getAllAlarmPatient(dbC.getConn(), patientId);
            //int assignResult = alarmhd.assignPatient(dbC.getConn(), alarmId, patientId);

            //if (assignResult == 1)
            //{
            //    int statusResult = alarmhd.updateStatus(dbC.getConn(), patientId);

            //    if (statusResult == 1)
            //    {
            //        patient_alarm_id = alarmId;
            //        ManagerMainScreen mms = new ManagerMainScreen();
            //        mms.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to access");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Failed to access");
            //}
        }

        

        private void patientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
