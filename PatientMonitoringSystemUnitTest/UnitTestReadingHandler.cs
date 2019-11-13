using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestReadingHandler
    {
        [TestMethod]
        public void AddReadingHandler()
        {
            reading readingclass = new reading();
            Assert.IsInstanceOfType(readingclass, typeof(object));
        }
    }
}
