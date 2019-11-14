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
            //DBConnect_LokeChunMent dBc = new DBConnect_LokeChunMent();
            //string result = dBc.connect();
            //Assert.AreEqual("Done", result);

            // alarm object
            Alarm alarm = new Alarm();
            Assert.IsInstanceOfType(alarm, typeof(object));

            //alarmhandler object
        }
    }
}
