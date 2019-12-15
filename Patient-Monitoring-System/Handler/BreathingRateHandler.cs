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
        //insert new breathing rate items to the patient
        public int addNewBreathingRate(MySqlConnection conn, BreathingRate breathingRate, int patientId)
        {
            string sql = "INSERT into breathingrate( patient_id, breathingRateValue, breathingRateTime, breathingRateDate)" + "VALUES('" + patientId + "', '" + breathingRate.BreathingRateValue + "', '" + breathingRate.BreathingRateTime.ToString("HH:mm:ss") + "', '" + breathingRate.BreathingRateDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }
        //get last id for breathing rate
        public int getLastIdBreathingRate(MySqlConnection conn, int patientId)
        {
            int id = 0;
            string sql = "SELECT MAX(ID) FROM breathingrate WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        //get last breathing rate
        public double getLastBreathingRate(MySqlConnection conn, int patientId, int lastId)
        {
            double maxBP = 0.0;
            string sql = "SELECT breathingRateValue FROM breathingrate WHERE patient_id='" + patientId + "' AND id='" + lastId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                maxBP = Convert.ToDouble(query);
            }

            return maxBP;
        }
    }
}
