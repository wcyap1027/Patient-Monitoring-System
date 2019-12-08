using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class StaffSchedule : Form
    {
        public StaffSchedule()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMainScreen mainScreen = new ManagerMainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }

   

        private void StaffSchedule_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Date");
            dt.Columns.Add("Nurse ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");

            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            StaffSchedulerHandler scheduleHnd = new StaffSchedulerHandler();
            dataOnDutyGridView.DataSource = scheduleHnd.getOnDutySchedule(dbConn.getConn());
            dataOffDutyGridView.DataSource = scheduleHnd.getOffDutySchedule(dbConn.getConn());
        }

      
    }
}
