using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestBloodPressureHandler
    {
        [TestMethod]
        public void TestBloodPressureHandler()
        {
            bloodPressure BloodPressure = new blodPressure();
            Assert.IsInstanceOfType(BloodPressure, typeof(object));
        }
    }
}
