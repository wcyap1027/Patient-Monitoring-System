using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestBreathingRateHandler
    {
        [TestMethod]
        public void TestBreathingRateHandler()
        {
            //connect database
            DBConnector dBc = new DBConnector();
            string result = dBc.connect();
            Assert.AreEqual("Done", result);
            BreathingRateHandler brhd = new BreathingRateHandler();
            DateTime currentDate = DateTime.Now;
            BreathingRate br = new BreathingRate();
            Assert.IsInstanceOfType(br, typeof(object));

            int patientId = 1001;
            br.BreathingRateValue = 14;
            br.BreathingRateTime = currentDate;
            br.BreathingRateDate = currentDate;
            int resp1 = brhd.addNewBreathingRate(dBc.getConn(), br, patientId);
            Assert.AreEqual(1, resp1);
            
            int resp2 = brhd.getLastIdBreathingRate(dBc.getConn(), patientId);
            Assert.IsNotNull(resp2);
            
            int lastId = 8;
            double resp3 = brhd.getLastBreathingRate(dBc.getConn(), patientId, lastId);
            Assert.IsNotNull(resp3);
        }
    }
}
