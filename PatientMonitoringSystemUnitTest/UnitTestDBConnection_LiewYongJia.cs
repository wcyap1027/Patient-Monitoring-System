using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDB()
        {
            DBConnection_LiewYongJia dbClass = new DBConnection_LiewYongJia();
            string resp = dbConnect.connection();
            Assert.AreEqual("Connect success", resp);
        }
    }
}
