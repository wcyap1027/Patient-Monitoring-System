using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Patient_Monitoring_System.Handler
{
    public class BloodPressureHandler
    {

        //add new bloodpressure values to the patient
        public int addNewBloodPressure(MySqlConnection conn, BloodPressure bloodPressure, int patientId)
        {
            string sql = "INSERT into bloodpressure( patient_id, bloodPressureValue, bloodPressureTime, bloodPressureDate)" + "VALUES('" + patientId + "', '" + bloodPressure.BloodPressureValue + "', '" + bloodPressure.BloodPressureTime.ToString("HH:mm:ss") + "', '" + bloodPressure.BloodPressureDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }
        
        //get last id blood pressure
        public int getLastIdBloodPressure(MySqlConnection conn, int patientId)
        {
            int id = 0;
            string sql = "SELECT MAX(ID) FROM bloodpressure WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if(!(query is DBNull))
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        //get latest value blood pressure
        public double getLastBloodPressure(MySqlConnection conn, int patientId, int lastId)
        {
            double maxBP = 0.0;
            string sql = "SELECT bloodPressureValue FROM bloodpressure WHERE patient_id='" + patientId + "' AND id='"+lastId+"'";
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
