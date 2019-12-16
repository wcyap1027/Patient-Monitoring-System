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
            DateTime currentDate = DateTime.Now;
            int patientId = 1001;
            temp.TemperatureValue = 37;
            temp.TemperatureDate = currentDate;
            temp.TemperatureTime = currentDate;
            int resp1 = thd.addNewTemperature(dbC.getConn(), temp, patientId);
            Assert.AreEqual(1, resp1);

           
            int resp2 = thd.getLastIdTemperature(dbC.getConn(), patientId);
            Assert.IsNotNull(resp2);

            int tempId = 321;
            double resp3 = thd.getLastTemperature(dbC.getConn(), patientId, tempId);
            Assert.IsNotNull(resp3);
        }
    }
}
