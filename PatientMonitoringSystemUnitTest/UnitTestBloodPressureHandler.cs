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
            DateTime currentDate = DateTime.Now;
            int PatientId = 1001;
            bloodPressure.BloodPressureValue = 120;
            bloodPressure.BloodPressureTime = currentDate;
            bloodPressure.BloodPressureDate = currentDate;
            int resp1 = bphd.addNewBloodPressure(dBc.getConn(), bloodPressure, PatientId);
            Assert.AreEqual(1, resp1);


            //int resp2 = bphd.getLastIdBloodPressure(dBc.getConn(), PatientId);
            //Assert.IsNotNull(resp2);


            //int lastId = 132;
            //double resp3 = bphd.getLastBloodPressure(dBc.getConn(), PatientId, lastId);
            //Assert.IsNotNull(resp3);

        }
    }
}
