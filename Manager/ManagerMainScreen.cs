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
        public ManagerMainScreen()
        {
            InitializeComponent();
        }

        private void ManagerMainScreen_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();

            panel1.Width = 852;
            panel1.Height = 386;
            panel1.Location = new Point(50, 170);
            panel2.Width = 852;
            panel2.Height = 386;
            panel2.Location = new Point(50, 170);
            panel3.Width = 852;
            panel3.Height = 386;
            panel3.Location = new Point(50, 170);
        }

        private void staffScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSchedule staffSchedule = new StaffSchedule();
            staffSchedule.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void patientInformationBtn_Click(object sender, EventArgs e)
        {
            panel1.Show();
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
            panel1.Hide();
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


            /*if (string.IsNullOrEmpty(patientIDTextBox.Text))
            {
                MessageBox.Show("Please enter a correct patient ID", "Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int patientId = int.Parse(patientIDTextBox.Text);

            bool status = patientHandler.checkPatientID(dbConn.getConn(), patientId);

            if (status)
            {
                patientGridView.DataSource = patientHandler.getSpecificPatientList(dbConn.getConn(), patientIDTextBox.Text);
            }
            else
            {
                MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */


        }
        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            patientIDcomboBox.Text = "";
        }

        private void alarmReportBtn_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            panel3.Hide();
            DbConnector dBConn = new DbConnector();
            dBConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            patientHandler.FetchId(patientComboBox);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            patientIDcomboBox.Text = "";
        }

        private void patientIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PatientHandler patientHandler = new PatientHandler();
            DBConnector dbC = new DBConnector();
            dbC.connect();
            //if (patientIDcomboBox.SelectedIndex != 0)
            //{
            //    Patient existingPatient = patientHandler.FetchId(dbC.getConn(), patientIDcomboBox.SelectedItem.ToString());
            //}

        }

        private void patientIDcb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void readingTypeTB_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void ViewB_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            //BloodPressureHandler bphandler = new BloodPressureHandler();

            int patientId = int.Parse(patientIDcb.Text);
            //string optionId = option1ComboBox.Text;

            bool status = patientHandler.checkPatientID(dbConn.getConn(), patientId);
            //bool status1 = bphandler.checkOption(dbConn.getConn(), optionId);

            string selected1 = optional1ComboBox.SelectedItem.ToString().ToLower();
            //string selected2 = optional2ComboBox.SelectedItem.ToString().ToLower();
            //string selected3 = optional3ComboBox.SelectedItem.ToString().ToLower();

            if (status)
            {
                if(optional1ComboBox.SelectedIndex > 0 /*&& optional2ComboBox.SelectedIndex == 0 && optional3ComboBox.SelectedIndex == 0*/)
                {
                    readingGridView.DataSource = patientHandler.patientWithOptional(dbConn.getConn(), patientId, selected1);
                }
                //else if (optional1ComboBox.SelectedIndex > 0 && optional2ComboBox.SelectedIndex > 0 && optional3ComboBox.SelectedIndex == 0)
                //{
                //    readingGridView.DataSource = patientHandler.patientWith2Optional(dbConn.getConn(), patientId, selected1, selected2);
                //}

                //if(selected == "Blood Pressure")
                //{
                //    status = true;
                //    MessageBox.Show("Exist");
                //    readingGridView.DataSource = bphandler.getSpecificBloodPressureList(dbConn.getConn(), optionalComboBox.Text);
                //}

                    //string sql = "SELECT patient_id FROM bloodpressure WHERE patient_id='" + patientIDcb.Text + "'";
                    //MySqlCommand sqlComm = new MySqlCommand(sql, dbConn.getConn());

                    //var qId = sqlComm.ExecuteScalar();

                    //if (qId != null)
                    //{
                    //    status = true;
                    //    MessageBox.Show("Exist");
                    //    readingGridView.DataSource = bphandler.getSpecificBloodPressureList(dbConn.getConn(), option1ComboBox.Text);
                    //}
                    //else
                    //{
                    //    status = false;
                    //}

                    //if (status1)
                    //{

                    //    readingGridView.DataSource = bphandler.getSpecificBloodPressureList(dbConn.getConn(), option1ComboBox.Text);
                    //}
            }
            else
            {
                MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void readingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void option1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            PatientHandler patientHandler = new PatientHandler();

            int patientId = int.Parse(patientComboBox.Text);

            bool status = patientHandler.checkPatientID(dbConn.getConn(), patientId);

            string selected = optional1ComboBox.SelectedItem.ToString().ToLower();

            if (status)
            {
                if (optional1ComboBox.SelectedIndex > 0)
                {
                    AlarmGridView.DataSource = patientHandler.patientAlarm(dbConn.getConn(), patientId, selected);
                }
            }
            else
            {
                MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void alarmDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
