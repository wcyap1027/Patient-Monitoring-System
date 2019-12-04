using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Patient_Monitoring_System.Handler
{
    public class ReadingHandler
    {
        public int addNewReading(MySqlConnection conn, Reading reading, int patientId)
        {
            string sql = "INSERT into reading( patient_id, minValueBloodPressure, maxValueBloodPressure, minValueTemperature,maxValueTemperature, minValueBreathingRate, maxValueBreathingRate, minValuePulseRate, maxValuePulseRate)" + "VALUES('" + patientId + "', '" + reading.MinBloodPressure + "', '" + reading.MaxBloodPressure + "', '" + reading.MinTemperature + "', '"+reading.MaxTemperature+"','"+reading.MinBreathing+"','"+reading.MaxBreathing+"', '"+reading.MinPulse+"','"+reading.MaxPulse+"')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public bool checkExistsReading(MySqlConnection conn, int patientId)
        {
            bool status = false;
            string sql = "SELECT * FROM reading WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        public int updateReading(MySqlConnection conn, Reading reading, int patientId)
        {
            string sql = "UPDATE reading SET minValueBloodPressure='" + reading.MinBloodPressure + "', maxValueBloodPressure= '" + reading.MaxBloodPressure + "', minValueTemperature='" + reading.MinTemperature + "', maxValueTemperature='" + reading.MaxTemperature + "', minValueBreathingRate='" + reading.MaxBreathing + "', maxValueBreathingRate='" + reading.MinBreathing + "', minValuePulseRate='" + reading.MinPulse + "', maxValuePulseRate='" + reading.MaxPulse + "' WHERE patient_id='" + patientId + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);

            return updateComm.ExecuteNonQuery();
        }
    }
}
