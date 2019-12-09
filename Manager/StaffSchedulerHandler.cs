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

        public List<Schedule> getOnDutySchedule(MySqlConnection conn)
        {
            List<Schedule> listSchedule = new List<Schedule>();
            string sql = "SELECT * FROM schedule WHERE dutyStatus ='" + 1 +"'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while(myReader.Read())
                {
                    Schedule schedule1 = new Schedule();
                    schedule1.Id = (int)myReader.GetValue(0);
                    schedule1.Staffid = (string)myReader.GetValue(1);
                    schedule1.Date = (DateTime)myReader.GetValue(2);
                    schedule1.FName = (string)myReader.GetValue(3);
                    schedule1.LName = (string)myReader.GetValue(4);
                    schedule1.Dutystatus = (bool)myReader.GetValue(5);
                    listSchedule.Add(schedule1);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listSchedule;
        }

       

        public List<Schedule> getDutySchedule(MySqlConnection conn, int status)
        {
            List<Schedule> listSchedule = new List<Schedule>();
            string sql = "SELECT * FROM schedule WHERE dutyStatus ='" + status + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while(myReader.Read())
                {
                    Schedule schedule2 = new Schedule();
                    schedule2.Id = (int)myReader.GetValue(0);
                    schedule2.Staffid = (string)myReader.GetValue(1);
                    schedule2.FName = (string)myReader.GetValue(2);
                    schedule2.LName = (string)myReader.GetValue(3);
                    schedule2.Date = (DateTime)myReader.GetValue(4);
                    schedule2.Dutystatus = (bool)myReader.GetValue(5);
                    listSchedule.Add(schedule2);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listSchedule;
        }

        public void FetchStafftId(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            PatientHandler patientHandler = new PatientHandler();
            List<Patient> patientList = new List<Patient>();
            patientList = patientHandler.getAllPatient(dbC.getConn());
            for (int i = 0; i < patientList.Count; i++)
            {
                if ((patientList[i].BedsideId == 0))
                {
                    selectedcomboBox.Items.Add(patientList[i].Id);
                }

            }
        }

        public Schedule getSpecificStaffDetails(MySqlConnection conn, int selectedId)
        {
            Schedule oldschedules = new Schedule();
            string sql = "SELECT * FROM schedule WHERE staff_id = '" + selectedId + "'";
            MySqlCommand sqllComm = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader myReader;
                myReader = sqllComm.ExecuteReader();
                if(myReader.Read())
                {
                    oldschedules.Id = (int)myReader.GetValue(0);
                    oldschedules.Date = (DateTime)myReader.GetValue(1);
                    oldschedules.Staffid = (string)myReader.GetValue(2);
                    oldschedules.FName = (string)myReader.GetValue(3);
                    oldschedules.LName = (string)myReader.GetValue(4);
                    oldschedules.Dutystatus = (bool)myReader.GetValue(5);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return oldschedules;
        }
    }
}
