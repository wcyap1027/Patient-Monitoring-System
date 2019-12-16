using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestPulseHandler
    {
        [TestMethod]
        public void TestPulseHandler()
        {
            DBConnector dBc = new DBConnector();
            string result = dBc.connect();
            Assert.AreEqual("Done", result);
            PulseRateHandler prhd = new PulseRateHandler();

            PulseRate pr = new PulseRate();
            Assert.IsInstanceOfType(pr, typeof(object));
            DateTime currentDate = DateTime.Now;
            int PatientId = 1001;
            pr.PulseRateValue = 70.0;
            pr.PulseRateDate = currentDate;
            pr.PulseRateTime = currentDate;
            int resp1 = prhd.addNewPulseRate(dBc.getConn(), pr, PatientId);
            Assert.AreEqual(1, resp1);

           
            int resp2 = prhd.getLastIdPulseRate(dBc.getConn(), PatientId);
            Assert.IsNotNull(resp2);

            
            int lastId = 101;
            double resp3 = prhd.getLastPulseRate(dBc.getConn(), PatientId, lastId);
            Assert.IsNotNull(resp3);
        }
    }
}
