using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;
namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestBloodPressureHandler
    {
        [TestMethod]
        public void TestBloodPressureHandler()
        {
            //connect database
            DBConnector dBc = new DBConnector();
            string result = dBc.connect();
            Assert.AreEqual("Done", result);
            BloodPressureHandler bphd = new BloodPressureHandler();

            BloodPressure bloodPressure = new BloodPressure();
            Assert.IsInstanceOfType(bloodPressure, typeof(object));

            //int PatientId = 1001;
            //bloodPressure.BloodPressureValue = 120;
            //bloodPressure.BloodPressureTime = new DateTime(03, 05, 19);
            //bloodPressure.BloodPressureDate = new DateTime(12, 05, 19);
            //int resp2 = bphd.addNewBloodPressure(dBc.getConn(), bloodPressure, PatientId);
            //Assert.IsNotNull(resp2);

            //int PatientId = 1001;
            //int resp2 = bphd.getLastIdBloodPressure(dBc.getConn(), PatientId);
            //Assert.IsNotNull(resp2);

            //int PatientId = 1001;
            //int lastId = 132;
            //double resp2 = bphd.getLastBloodPressure(dBc.getConn(), PatientId, lastId);
            //Assert.IsNotNull(resp2);

        }
    }
}
