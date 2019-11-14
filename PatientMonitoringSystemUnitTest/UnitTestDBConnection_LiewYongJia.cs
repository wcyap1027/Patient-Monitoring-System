using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestDBConnection_LiewYongJia
    {
        [TestMethod]
        public void TestDB()
        {
            DBConnection_LiewYongJia dbConnect = new DBConnection_LiewYongJia();
            string resp = dbConnect.connection();
            Assert.AreEqual("Connect success", resp);
        }
    }
}
