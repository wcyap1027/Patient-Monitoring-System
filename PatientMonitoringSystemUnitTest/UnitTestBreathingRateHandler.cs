using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestBreathingRateHandler
    {
        [TestMethod]
        public void TestBreathingRateHandler()
        {
            BreathingRate BreathingRate = new BreathingRate();
            Assert.IsInstanceOfType(BreathingRate, typeof(object));
        }
    }
}
