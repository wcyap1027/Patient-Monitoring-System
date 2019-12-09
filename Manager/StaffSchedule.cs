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

            

            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            StaffSchedulerHandler scheduleHnd = new StaffSchedulerHandler();
            List<Schedule> listSchedules = new List<Schedule>();
            listSchedules = scheduleHnd.getDutySchedule(dbConn.getConn(), 0);
            dataOnDutyGridView.DataSource = scheduleHnd.getDutySchedule(dbConn.getConn(), 1);
            //dataOffDutyGridView.DataSource = listSchedules;
            datatestGridView1.DataSource = listSchedules;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StaffSchedulerHandler scheduleHandler = new StaffSchedulerHandler();
            DbConnector dbC = new DbConnector();
            dbC.connect();
            if (StaffIDcomboBox.SelectedIndex != 0)
            {
                Schedule existSchedule = scheduleHandler.getSpecificStaffDetails(dbC.getConn(), int.Parse(StaffIDcomboBox.SelectedItem.ToString()));
                firstNameTextBox.Text = existSchedule.FName.ToString();
                lastNameTextBox.Text = existSchedule.LName.ToString();
                todayDate.Text = existSchedule.Date.ToString();
            }
        }
    }
}
