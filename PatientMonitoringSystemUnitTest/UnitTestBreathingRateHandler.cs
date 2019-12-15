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

            BreathingRate br = new BreathingRate();
            Assert.IsInstanceOfType(br, typeof(object));

            //int patientId = 1001;
            //br.BreathingRateValue = 14;
            //br.BreathingRateTime = new DateTime(05, 06, 15);
            //br.BreathingRateDate = new DateTime(09, 12, 2019);
            //int resp2 = brhd.addNewBreathingRate(dBc.getConn(), br, patientId);

            //int patientId = 1008;
            //int resp2 = brhd.getLastIdBreathingRate(dBc.getConn(), patientId);

            //int patientId = 1008;
            //int lastId = 8;
            //double resp2 = brhd.getLastBreathingRate(dBc.getConn(), patientId, lastId);
        }
    }
}
