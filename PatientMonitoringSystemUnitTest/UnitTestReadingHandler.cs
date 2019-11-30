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
            Reading readingclass = new Reading();
            Assert.IsInstanceOfType(readingclass, typeof(object));
        }
    }
}
