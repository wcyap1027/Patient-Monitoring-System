using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System.Handler
{
    public class BloodPressureHandler
    {
        public int addNewBloodPressure(MySqlConnection conn, BloodPressure bloodPressure, int patientId)
        {
            string sql = "INSERT into bloodpressure( patient_id, bloodPressureValue, bloodPressureTime, bloodPressureDate)" + "VALUES('" + patientId + "', '" + bloodPressure.BloodPressureValue + "', '" + bloodPressure.BloodPressureTime.ToString("HH:mm:ss") + "', '" + bloodPressure.BloodPressureDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }
    }
}
