using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestDBConnect_YapWingChun
    {
        [TestMethod]
        public void TestAddDB()
        {
            DBConnector_YapWingChun dbConnect = new DBConnector_YapWingChun();
            string resp = dbConnect.connection();
            Assert.AreEqual("Connect success", resp);

        }
    }
}
