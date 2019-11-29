using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System
{
    public class CentralStationHandler
    {
        public string getBayName(MySqlConnection conn, string bayN)
        {
            CentralStation centralStation = new CentralStation();
            string bayName;
            string sql = "SELECT * FROM centralstation where centralStationName='" +bayN+ "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                if (myReader.Read())
                {
                    
                    centralStation.Id = (int)myReader.GetValue(0);
                    centralStation.CentralStationName = (string)myReader.GetValue(1);
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            bayName = centralStation.CentralStationName;
            return bayName;


        }
    }
}
