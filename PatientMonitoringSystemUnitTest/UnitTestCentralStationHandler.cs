using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestCentralStationHandler
    {
        [TestMethod]
        public void TestMethod1()
        {
            DBConnector dBc = new DBConnector();
            string result = dBc.connect();
            Assert.AreEqual("Done", result);
            CentralStationHandler cshd = new CentralStationHandler();

            CentralStation cs = new CentralStation();
            Assert.IsInstanceOfType(cs, typeof(object));

            //List<CentralStation> centralstation = new List<CentralStation>();
            
        }
    }
}
