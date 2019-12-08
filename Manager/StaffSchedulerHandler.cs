using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sql = "SELECT * FROM schedule WHERE dutystatus =" + 1;
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while(myReader.Read())
                {
                    Schedule schedule1 = new Schedule();
                    schedule1.Date = (DateTime)myReader.GetValue(0);
                    schedule1.Nurseid = (string)myReader.GetValue(1);
                    schedule1.FName = (string)myReader.GetValue(2);
                    schedule1.LName = (string)myReader.GetValue(3);
                    schedule1.Dutystatus = (bool)myReader.GetValue(4);
                    listSchedule.Add(schedule1);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listSchedule;
        }

        public List<Schedule> getOffDutySchedule(MySqlConnection conn)
        {
            List<Schedule> listSchedule = new List<Schedule>();
            string sql = "SELECT * FROM schedule where dutystatus =" + 0;
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while(myReader.Read())
                {
                    Schedule schedule2 = new Schedule();
                    schedule2.Date = (DateTime)myReader.GetValue(0);
                    schedule2.Nurseid = (string)myReader.GetValue(1);
                    schedule2.FName = (string)myReader.GetValue(2);
                    schedule2.LName = (string)myReader.GetValue(3);
                    schedule2.Dutystatus = (bool)myReader.GetValue(4);
                    listSchedule.Add(schedule2);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listSchedule;
        }
    }
}
