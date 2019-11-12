using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
