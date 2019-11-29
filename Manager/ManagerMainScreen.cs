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
using System.Data.SqlClient;

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

        private void resetBtn_Click(object sender, EventArgs e)
        {
            patientNRICT.Text = "";
        }

        private void patientNRICT_TextChanged(object sender, EventArgs e)
        {

        }

        private void csvReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void staffScheduleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffSchedule staffSchedule = new StaffSchedule();
            staffSchedule.ShowDialog();
            this.Close();
        }

        private void staffReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffReport staffReport = new StaffReport();
            staffReport.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
