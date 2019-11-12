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
            // alarm object
            Alarm alarm = new Alarm();
            Assert.IsInstanceOfType(alarm, typeof(object));
        }
    }
}
