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
        public int addNewTemperature(MySqlConnection conn, Temperature temperature, int patientId)
        {
            string sql = "INSERT into temperature( patient_id, temperatureValue, temperatureTime, temperatureDate)" + "VALUES('" + patientId + "', '" + temperature.TemperatureValue + "', '" + temperature.TemperatureTime.ToString("HH:mm:ss") + "', '" + temperature.TemperatureDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }
    }
}
