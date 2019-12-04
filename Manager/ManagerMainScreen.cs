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

        private void readingBtn_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            panel3.Show();
            DbConnector dBConn = new DbConnector();
            dBConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            patientHandler.FetchId(patientIDcb);
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

            int patientId = int.Parse(patientIDcomboBox.Text);

            bool status = patientHandler.checkPatientID(dbConn.getConn(), patientId);

            if (status)
            {
                readingGridView.DataSource = patientHandler.getSpecificPatientList(dbConn.getConn(), patientIDcomboBox.Text);
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
            option1ComboBox.Items.Add("Blood Pressure");
            option1ComboBox.Items.Add("Pulse Rate");
            option1ComboBox.Items.Add("Temperature");
            option1ComboBox.Items.Add("Breathing Rate");

            var item = this.option1ComboBox.GetItemText(this.option1ComboBox.SelectedItem);
            MessageBox.Show(item);
        }
    }
}
