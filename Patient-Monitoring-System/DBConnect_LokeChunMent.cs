using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System
{
    public class DBConnect_LokeChunMent
    {
        MySqlConnection conn;

        public string connect()
        {
            //connection string include 
            //server name
            //user name
            //database name
            //port
            //password
            string connstr = "server=localhost;user=admin;database=patientmonitoringdb;port=3306;password=admin123";
            
            //assign connection string to variable conn
            conn = new MySqlConnection(connstr);
            try
            {
                //open connection of database
                conn.Open();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return "Done";
        }

        public MySqlConnection getConn()
        {
            return conn;
        }
    }
}
