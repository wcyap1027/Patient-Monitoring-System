using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Patient_Monitoring_System
{
    public class AlarmHandler
    {
        public int addNewAlarm(MySqlConnection conn, Alarm alarm)
        {
            string sql = "INSERT into alarm( patient_id,reading_id, specific_id, triggerValue, dateTimeTrigger, dateTimeMuted, remark)" + "VALUES('"+alarm.PatientId+"','" + alarm.ReadingId + "', '"+alarm.SpecificId+"','" + alarm.TriggerValue + "', '" + alarm.DateTimeTrigger.ToString("yyyy-MM-dd HH:mm:ss")+ "', '" + alarm.DateTimeMuted.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + alarm.Remark+"')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }

        public bool triggerAlarm(MySqlConnection conn, double value, int patientId, int readingId, int specificId, string remark)
        {
            bool status = false;
            DateTime currentDateTime = DateTime.Now;
            AlarmHandler alarmHandler = new AlarmHandler();
            Alarm newAlarm = new Alarm();
            newAlarm.PatientId = patientId;
            newAlarm.ReadingId = readingId;
            newAlarm.SpecificId = specificId;
            newAlarm.TriggerValue = value;
            newAlarm.DateTimeTrigger = currentDateTime;
            newAlarm.DateTimeMuted = new DateTime(1001,1,1,0,0,0);
            newAlarm.Remark = remark;
            int result = alarmHandler.addNewAlarm(conn, newAlarm);

            if(result == 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        public int getSpecificId(MySqlConnection conn, double value, string readingtype)
        {
            int id = 0;
            string columnName = "";
            if(readingtype == "bloodpressure")
            {
                columnName = "bloodPressureValue";
            }
            else if(readingtype == "breathingrate")
            {
                columnName = "breathingRateValue";
            }
            else if(readingtype == "pulserate")
            {
                columnName = "pulseRateValue";
            }
            else if(readingtype == "temperature")
            {
                columnName = "temperatureValue";
            }
            string sql = "SELECT id FROM "+readingtype+" WHERE "+columnName+"='" + value + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        public int getLastId(MySqlConnection conn, int patientId)
        {
            int id = 0;

            string sql = "SELECT MAX(ID) FROM alarm WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        public int updateDateTimeMuted(MySqlConnection conn, int patientId, int maxId)
        {
            DateTime currentDate = DateTime.Now;
            string sql = "UPDATE alarm SET dateTimeMuted='" + currentDate.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE patient_id='" + patientId + "' AND id='" + maxId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        //example
        public int assignPatient(MySqlConnection conn, int alarmId, int patientId)
        {
            string sql = "UPDATE alarm SET patientId ='" + patientId + "' WHERE id='" + alarmId + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);

            return updateComm.ExecuteNonQuery();
        }

        //example
        public int updateStatus(MySqlConnection conn, int patientId)
        {
            int status = 1;
            string sql = "UPDATE alarm SET status='" + status + "' WHERE id='" + patientId + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);
            return updateComm.ExecuteNonQuery();
        }

        //example
        public List<Alarm> getAllAlarm(MySqlConnection conn)
        {
            List<Alarm> listAlarm = new List<Alarm>();
            string sql = "SELECT * FROM alarm";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    Alarm alarms = new Alarm ();
                    alarms.SpecificId = (int)myReader.GetValue(0);
                    alarms.ReadingId = (int)myReader.GetValue(1);
                    alarms.PatientId = (int)myReader.GetValue(2);
                    alarms.DateTimeTrigger = (DateTime)myReader.GetValue(3);
                    alarms.DateTimeMuted = (DateTime)myReader.GetValue(4);
                    alarms.TriggerValue = (int)myReader.GetValue(5);
                    alarms.Remark = (string)myReader.GetValue(6);

                    listAlarm.Add(alarms);
                }
                myReader.Close();
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listAlarm;
        }
        //example
        public void FetchPatientAlarmId(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            AlarmHandler alarmhd = new AlarmHandler();
            List<Alarm> alarmList = new List<Alarm>();
            alarmList = alarmhd.getAllAlarm(dbC.getConn());
            for (int i = 0; i < alarmList.Count; i++)
            {
                if ((alarmList[i].PatientId == 0))
                {
                    selectedcomboBox.Items.Add(alarmList[i].SpecificId);
                }

            }
        }
    }
}
