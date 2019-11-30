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
            PulseRate PulseRate = new PulseRate();
            Assert.IsInstanceOfType(PulseRate, typeof(object));
        }
    }
}
