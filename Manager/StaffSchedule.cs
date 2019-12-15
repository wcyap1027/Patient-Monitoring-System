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
            DBConnector dbConn = new DBConnector();
            dbConn.connect();
            InitializeComponent();
            StaffSchedulerHandler schedulerHandler = new StaffSchedulerHandler();
            dataOnDutyGridView.DataSource = schedulerHandler.getOnScheduleStatus(dbConn.getConn(), 0);
            dataOffDutyGridView.DataSource = schedulerHandler.getOffScheduleStatus(dbConn.getConn(), 0);
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

        private void staffIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnector dbCon = new DBConnector();
            dbCon.connect();

            if(staffIDcomboBox.SelectedIndex != 0)
            {
                StaffSchedulerHandler staffhnd = new StaffSchedulerHandler();
                Schedule newschedule = new Schedule();
                newschedule = staffhnd.getSpecificSchedule(dbCon.getConn(), staffIDcomboBox.SelectedItem.ToString());
                firstNameTextBox.Text = newschedule.FirstName.ToString();
                lastNameTextBox.Text = newschedule.LastName.ToString();
                dateBox.Text = newschedule.TodayDate.ToString();

                if(newschedule.DutyStatus == "On")
                {
                    dutyStatusBox.Text = "On";
                    dataOnDutyGridView.DataSource = staffhnd.getOnScheduleStatus(dbCon.getConn(), 0);
                    dataOffDutyGridView.DataSource = staffhnd.getOffScheduleStatus(dbCon.getConn(), 0);
                }
                else
                {
                    dutyStatusBox.Text = "Off";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(staffIDcomboBox.Text))
            {
                MessageBox.Show("Please enter a valid staff id");
                return;
            }

            if(string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid first name");
                return;
            }

            if(string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid last name");
                return;
            }

            Schedule schedule = new Schedule();
            schedule.StaffId = staffIDcomboBox.SelectedItem.ToString();

            schedule.TodayDate = dateBox.Value;
            schedule.DutyStatus = dutyStatusBox.Text;

            DBConnector dbCon = new DBConnector();
            dbCon.connect();
            StaffSchedulerHandler staffhnd = new StaffSchedulerHandler();
            int result = staffhnd.updateSchedule(dbCon.getConn(), schedule, staffIDcomboBox.SelectedItem.ToString());
            if(result == 1)
            {
                MessageBox.Show("Update Successfully");
                dataOnDutyGridView.DataSource = staffhnd.getOnScheduleStatus(dbCon.getConn(), 0);
                dataOffDutyGridView.DataSource = staffhnd.getOffScheduleStatus(dbCon.getConn(), 0);


            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateBox.Text = "";
            staffIDcomboBox.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerMainScreen mngScreen = new ManagerMainScreen();
            this.Hide();
            mngScreen.ShowDialog();
            this.Close();
        }
    }
}
