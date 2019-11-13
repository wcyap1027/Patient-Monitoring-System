using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestPulseHandler
    {
        [TestMethod]
        public void TestPulseHandler()
        {
            pulseRate PulseRate = new pulseRate();
            Assert.IsInstanceOfType(PulseRate, typeof(object));
        }
    }
}
