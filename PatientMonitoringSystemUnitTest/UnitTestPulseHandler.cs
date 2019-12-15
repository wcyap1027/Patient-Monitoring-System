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

            //int PatientId = 1001;
            //pr.PulseRateValue = 70.0;
            //pr.PulseRateDate = new DateTime(15, 12, 2019);
            //pr.PulseRateTime = new DateTime(03, 15, 30);
            //int resp2 = prhd.addNewPulseRate(dBc.getConn(), pr, PatientId);
            //Assert.IsNotNull(resp2);

            //int PatientId = 1001;
            //int resp2 = prhd.getLastIdPulseRate(dBc.getConn(), PatientId);
            //Assert.IsNotNull(resp2);

            //int PatientId = 1001;
            //int lastId = 101;
            //double resp2 = prhd.getLastPulseRate(dBc.getConn(), PatientId, lastId);
            //Assert.IsNotNull(resp2);
        }
    }
}
