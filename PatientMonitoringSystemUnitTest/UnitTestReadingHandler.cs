using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestReadingHandler
    {
        [TestMethod]
        public void AddReadingHandler()
        {
            //connect database
            DBConnector dbC = new DBConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);
            ReadingHandler rhd = new ReadingHandler();
            Reading readingclass = new Reading();
            Assert.IsInstanceOfType(readingclass, typeof(object));

            //int patientId = 1008;
            //readingclass.MinBloodPressure = 65;
            //readingclass.MaxBloodPressure = 125;
            //readingclass.MinTemperature = 65;
            //readingclass.MaxTemperature = 125;
            //readingclass.MinPulse = 65;
            //readingclass.MaxPulse = 125;
            //readingclass.MinBreathing = 65;
            //readingclass.MaxBreathing = 125;
            //int resp2 = rhd.addNewReading(dbC.getConn(), readingclass, patientId);
            //Assert.IsNotNull(resp2);

            //int patientId = 1002;
            //bool resp2 = rhd.checkExistsReading(dbC.getConn(), patientId);
            //Assert.IsNotNull(resp);

            //int patientId = 1001;
            //int resp2 = rhd.updateReading(dbC.getConn(), readingclass, patientId);
            //Assert.IsNotNull(resp);

            //int patientId = 1001;
            //Reading _ = rhd.getReading(dbC.getConn(), patientId);

            //double value = 65;
            //int resp2 = rhd.getIdAlarmTrigger(dbC.getConn(), value);
        }
    }
}
