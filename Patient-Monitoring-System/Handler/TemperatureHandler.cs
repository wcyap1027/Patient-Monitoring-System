using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Patient_Monitoring_System.Handler
{
    public class TemperatureHandler
    {
        //add new temperature
        public int addNewTemperature(MySqlConnection conn, Temperature temperature, int patientId)
        {
            string sql = "INSERT into temperature( patient_id, temperatureValue, temperatureTime, temperatureDate)" + "VALUES('" + patientId + "', '" + temperature.TemperatureValue + "', '" + temperature.TemperatureTime.ToString("HH:mm:ss") + "', '" + temperature.TemperatureDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }

        //get last id for temperature
        public int getLastIdTemperature(MySqlConnection conn, int patientId)
        {
            int id = 0;
            string sql = "SELECT MAX(ID) FROM temperature WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        //get last temperature value
        public double getLastTemperature(MySqlConnection conn, int patientId, int lastId)
        {
            double maxtemp = 0.0;
            string sql = "SELECT temperatureValue FROM temperature WHERE patient_id='" + patientId + "' AND id='" + lastId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                maxtemp = Convert.ToDouble(query);
            }

            return maxtemp;
        }
    }
}
