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
        //insert new pulse rate
        public int addNewPulseRate(MySqlConnection conn, PulseRate pulseRate, int patientId)
        {
            string sql = "INSERT into pulserate( patient_id, pulseRateValue, pulseRateTime, pulseRateDate)" + "VALUES('" + patientId + "', '" + pulseRate.PulseRateValue + "', '" + pulseRate.PulseRateTime.ToString("HH:mm:ss") + "', '" + pulseRate.PulseRateDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }

        //get last id for pulse rate
        public int getLastIdPulseRate(MySqlConnection conn, int patientId)
        {
            int id = 0;
            string sql = "SELECT MAX(ID) FROM pulserate WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        //get last pulse rate
        public double getLastPulseRate(MySqlConnection conn, int patientId, int lastId)
        {
            double maxPR = 0.0;
            string sql = "SELECT pulseRateValue FROM pulserate WHERE patient_id='" + patientId + "' AND id='" + lastId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                maxPR = Convert.ToDouble(query);
            }

            return maxPR;
        }
    }
}
