using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manager;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddSchedule()
        {
            DbConnector dbCon = new DbConnector();
            string result = dbCon.connect();
            Assert.AreEqual("Done", result);
            StaffSchedulerHandler staffhnd = new StaffSchedulerHandler();

            Schedule schedule = new Schedule(); 
        }
    }
}
