using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestRoleHandler
    {
        [TestMethod]
        public void TestRoleHandler()
        {
            role Role = new role();
            Assert.IsInstanceOfType(Role, typeof(object));
        }
    }
}
