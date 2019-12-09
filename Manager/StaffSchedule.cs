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

namespace Manager
{
    public partial class StaffSchedule : Form
    {
        public StaffSchedule()
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            InitializeComponent();
            StaffSchedulerHandler schedulerHandler = new StaffSchedulerHandler();
            dataOffDutyGridView.DataSource = schedulerHandler.getAllScheduleStatus(dbConn.getConn(), 0);
            schedulerHandler.FetchStaffId(staffIDcomboBox);
            //PatientHandler patientHandler = new PatientHandler();
            //dataOffDutyGridView.DataSource = patientHandler.getAllPatient(dbConn.getConn());
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
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            //StaffSchedulerHandler scheduleHnd = new StaffSchedulerHandler();
            //dataOnDutyGridView.DataSource = scheduleHnd.getDuty(dbConn.getConn(), 1);
            //dataOffDutyGridView.DataSource = scheduleHnd.getDutySchedule(dbConn.getConn(), 0);
        }

      
    }
}
