using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestTemperatureHandler
    {
        [TestMethod]
        public void TestTemperatureHandler()
        {
            //connect database
            DBConnector dbC = new DBConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);
            TemperatureHandler thd = new TemperatureHandler();
            Temperature temp = new Temperature();
            Assert.IsInstanceOfType(temp, typeof(object));

            //int patientId = 1001;
            //temp.TemperatureValue = 37;
            //temp.TemperatureDate = new DateTime(10, 12, 2019);
            //temp.TemperatureTime = new DateTime(08, 15, 12);
            //int resp2 = thd.addNewTemperature(dbC.getConn(), temp, patientId);
            //Assert.IsNotNull(resp2);

            //int patientId = 1008;
            //int resp2 = thd.getLastIdTemperature(dbC.getConn(), patientId);
            //Assert.IsNotNull(resp2);

            //int patientId = 1008;
            //int tempId = 321;
            //double resp2 = thd.getLastTemperature(dbC.getConn(), patientId, tempId);
            //Assert.IsNotNull(resp2);
        }
    }
}
