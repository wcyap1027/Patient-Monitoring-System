using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System.Handler
{
    public class PulseRateHandler
    {
        public int addNewPulseRate(MySqlConnection conn, PulseRate pulseRate, int patientId)
        {
            string sql = "INSERT into pulserate( patient_id, pulseRateValue, pulseRateTime, pulseRateDate)" + "VALUES('" + patientId + "', '" + pulseRate.PulseRateValue + "', '" + pulseRate.PulseRateTime.ToString("HH:mm:ss") + "', '" + pulseRate.PulseRateDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }
    }
}
