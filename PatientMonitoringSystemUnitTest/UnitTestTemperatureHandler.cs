using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestTemperatureHandler
    {
        [TestMethod]
        public void TestTemperatureHandler()
        {
            Temperature Temperature = new Temperature();
            Assert.IsInstanceOfType(Temperature, typeof(object));
        }
    }
}
