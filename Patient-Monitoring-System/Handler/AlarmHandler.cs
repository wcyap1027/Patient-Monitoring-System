using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System
{
    public class AlarmHandler
    {
        public int addNewAlarm(MySqlConnection conn, Alarm alarm)
        {
            string sql = "INSERT into alarm( reading_id, specific_id, triggerValue, dateTimeTrigger, dateTimeMuted, remark)" + "VALUES('" + alarm.ReadingId + "', '"+alarm.SpecificId+"','" + alarm.TriggerValue + "', '" + alarm.DateTimeTrigger.ToString("yyyy-MM-dd HH:mm:ss")+ "', '" + alarm.DateTimeMuted.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + alarm.Remark+"')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }

        public bool triggerAlarm(MySqlConnection conn, double value, int readingId, int specificId, string remark)
        {
            bool status = false;
            DateTime currentDateTime = DateTime.Now;
            AlarmHandler alarmHandler = new AlarmHandler();
            Alarm newAlarm = new Alarm();
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

        

       
    }
}
