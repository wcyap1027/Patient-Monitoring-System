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

        }

        private void readingBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();

            if (string.IsNullOrEmpty(patientIDTextBox.Text))
            {
                MessageBox.Show("Please enter a correct patient ID", "Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (patientIDTextBox.Text != "")
            {
                dbConn.connect();
                PatientHandler patientHandler = new PatientHandler();
                string query = "SELECT * FROM patient where id = '" + patientIDTextBox.Text+"'";
                MySqlDataReader row;
                MySqlCommand sqlComm = new MySqlCommand(query, dbConn.getConn());
                row = sqlComm.ExecuteReader();
                if (row.HasRows)
                {
                    patientInformation patientInfo = new patientInformation();
                    patientInfo.Id = int.Parse(patientIDTextBox.Text);

                    PatientInformationHandler patientHnd = new PatientInformationHandler();
                    int recordCnt = patientHnd.displayPatientInfo(dbConn.getConn(), patientInfo);
                    MessageBox.Show(recordCnt + " record has been inserted!! ");
                    patientGridView.DataSource = patientHnd.getAllPatient(dbConn.getConn());
                    

                }
                else
                {
                    MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            patientIDTextBox.Text = "";
        }
    }
}
