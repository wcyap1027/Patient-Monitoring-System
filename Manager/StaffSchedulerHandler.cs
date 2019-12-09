using MySql.Data.MySqlClient;
using Patient_Monitoring_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public class StaffSchedulerHandler
    {
        private DataTable dt = new DataTable();

        public DataTable BindSource()
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            MySqlDataAdapter sqlData = new MySqlDataAdapter("SELECT * FROM schedule", dbConn.getConn());
            dt.Clear();
            sqlData.Fill(dt);
            dbConn.getConn().Close();

            return dt;
        }

        public void FetchStaffId(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            StaffSchedulerHandler scheduleHandler = new StaffSchedulerHandler();
            List<Schedule> listSchedule = new List<Schedule>();
            listSchedule = scheduleHandler.getAllSchedule(dbC.getConn());
            for (int i = 0; i < listSchedule.Count; i++)
            {
                
                selectedcomboBox.Items.Add(listSchedule[i].StaffId);
            }
        }

        public List<Schedule> getAllSchedule(MySqlConnection conn)
        {
            List<Schedule> listSchedule = new List<Schedule>();
            string sql = "SELECT * FROM schedule";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    Schedule schedule = new Schedule();
                    schedule.Id = (int)myReader.GetValue(0);
                    schedule.StaffId = (string)myReader.GetValue(1);
                    schedule.FirstName = (string)myReader.GetValue(2);
                    schedule.LastName = (string)myReader.GetValue(3);
                    schedule.TodayDate = (DateTime)myReader.GetValue(4);
                    schedule.DutyStatus = (bool)myReader.GetValue(5);



                    listSchedule.Add(schedule);
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listSchedule;
        }


        public List<Schedule> getAllScheduleStatus(MySqlConnection conn, int dutyStatus)
        {
            List<Schedule> listSchedule = new List<Schedule>();
            string sql = "SELECT * FROM schedule WHERE dutyStatus='"+dutyStatus+"'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    Schedule schedule = new Schedule();
                    schedule.Id = (int)myReader.GetValue(0);
                    schedule.StaffId = (string)myReader.GetValue(1);
                    schedule.FirstName = (string)myReader.GetValue(2);
                    schedule.LastName = (string)myReader.GetValue(3);
                    schedule.TodayDate = (DateTime)myReader.GetValue(4);
                    schedule.DutyStatus = (bool)myReader.GetValue(5);



                    listSchedule.Add(schedule);
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listSchedule;
        }

        public DataTable getDuty(MySqlConnection conn, int status)
        {
            string sql = "SELECT * FROM schedule WHERE dutyStatus='" + status + "'";
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            conn.Close();

            return dt;
        }

        
    }
}
