using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Patient_Monitoring_System.Handler
{
    public class BreathingRateHandler
    {
        public int addNewBreathingRate(MySqlConnection conn, BreathingRate breathingRate, int patientId)
        {
            string sql = "INSERT into breathingrate( patient_id, breathingRateValue, breathingRateTime, breathingRateDate)" + "VALUES('" + patientId + "', '" + breathingRate.BreathingRateValue + "', '" + breathingRate.BreathingRateTime.ToString("HH:mm:ss") + "', '" + breathingRate.BreathingRateDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }
    }
}
