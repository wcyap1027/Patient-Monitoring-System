using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestDBConnector
    {
        [TestMethod]
        public void TestDatabase_LokeChunMent()
        {
            DBConnector dBc = new DBConnector();
            string resp = dBc.connect();
            Assert.AreEqual("Done", resp);
        }
    }
}
