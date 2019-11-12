using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestDBConnect_LokeChunMent
    {
        [TestMethod]
        public void TestDatabase_LokeChunMent()
        {
            DBConnect_LokeChunMent dBc = new DBConnect_LokeChunMent();
            string resp = dBc.connect();
            Assert.AreEqual("Done", resp);
        }
    }
}
