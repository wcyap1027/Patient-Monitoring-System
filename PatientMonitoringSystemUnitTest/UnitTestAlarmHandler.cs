using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestAlarmHandler
    {
        [TestMethod]
        public void TestAddAlarm()
        {
            //connect database
            DBConnector dBc = new DBConnector();
            string result = dBc.connect();
            Assert.AreEqual("Done", result);
            AlarmHandler alarmhd = new AlarmHandler();

            // alarm object
            Alarm alarm = new Alarm();
            //Assert.IsInstanceOfType(alarm, typeof(object));
            //alarm.PatientId = 1001;
            //alarm.ReadingId = 3;
            //alarm.SpecificId = 2;
            //alarm.TriggerValue = 68;
            //alarm.DateTimeTrigger = new DateTime(2019, 5, 26, 12, 50, 12);
            //alarm.DateTimeMuted = new DateTime(2019, 5, 26, 12, 54, 10);
            //alarm.Remark = "patient ok";
            //int resp2 = alarmhd.addNewAlarm(dBc.getConn(), alarm);
            //Assert.IsNotNull(resp2);

            //Assert.IsInstanceOfType(alarm, typeof(object));
            //double value = 20;
            //int patientId = 1004;
            //int readingId = 1;
            //int specificId = 2;
            //string remark = "patient ok";            

            //bool resp2 = alarmhd.triggerAlarm(dBc.getConn(), value, patientId, readingId, specificId, remark);

            //Assert.IsInstanceOfType(alarm, typeof(object));
            //double value = 2;
            //string readingtype = "temperature";
            //int resp2 = alarmhd.getSpecificId(dBc.getConn(), value, readingtype);

            //Assert.IsInstanceOfType(alarm, typeof(object));
            //int patientId = 1001;
            //int resp2 = alarmhd.getLastId(dBc.getConn(), patientId);

            //int patientId = 1004;
            //int maxId = 584;
            //int resp2 = alarmhd.updateDateTimeMuted(dBc.getConn(), patientId, maxId);
            //Assert.IsNotNull(resp2);
            ////alarmhandler object
        }
    }
}
