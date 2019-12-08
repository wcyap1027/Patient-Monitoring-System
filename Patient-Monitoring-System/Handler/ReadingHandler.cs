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
            string sql = "UPDATE reading SET minValueBloodPressure='" + reading.MinBloodPressure + "', maxValueBloodPressure= '" + reading.MaxBloodPressure + "', minValueTemperature='" + reading.MinTemperature + "', maxValueTemperature='" + reading.MaxTemperature + "', minValueBreathingRate='" + reading.MinBreathing + "', maxValueBreathingRate='" + reading.MaxBreathing + "', minValuePulseRate='" + reading.MinPulse + "', maxValuePulseRate='" + reading.MaxPulse + "' WHERE patient_id='" + patientId + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);

            return updateComm.ExecuteNonQuery();
        }

        

        public Reading getReading(MySqlConnection conn, int patientId)
        {
            string sql = "SELECT * FROM reading WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            Reading reading = new Reading();
            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                if (myReader.Read())
                {
                    
                    reading.MinBloodPressure = (double)myReader.GetValue(2);
                    reading.MaxBloodPressure = (double)myReader.GetValue(3);
                    reading.MinTemperature = (double)myReader.GetValue(4);
                    reading.MaxTemperature = (double)myReader.GetValue(5);
                    reading.MinBreathing = (double)myReader.GetValue(6);
                    reading.MaxBreathing = (double)myReader.GetValue(7);
                    reading.MinPulse = (double)myReader.GetValue(8);
                    reading.MaxPulse = (double)myReader.GetValue(9);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return reading;
        }

        public int getIdAlarmTrigger(MySqlConnection conn, double value)
        {
            int id = 0;
            string sql = "SELECT id FROM reading WHERE minValueBloodPressure= '" + value + "' OR maxValueBloodPressure= '" + value + "' OR minValueTemperature='" + value + "' OR maxValueTemperature='" + value + "' OR minValueBreathingRate='" + value + "' OR maxValueBreathingRate='" + value + "' OR minValuePulseRate='" + value + "' OR maxValuePulseRate='" + value + "'";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }
    }
}
