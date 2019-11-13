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
            temperature Temperature = new temperature();
            Assert.IsInstanceOfType(Temperature, typeof(object));
        }
    }
}
