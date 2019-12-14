using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Class;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestSMSHandler
    {
        [TestMethod]
        public void TestMethodAddSMS()
        {
            DBConnector dbC = new DBConnector();
            dbC.connect();


            //SMS sms = new SMS();
            //DateTime currentDateTime = DateTime.Now;
            //sms.BedsideId = 8;
            //sms.StaffId = "MS00010";
            //sms.Description = "Bedside 8 is trigger alarm";
            //sms.DateTimeSent = currentDateTime;
            //SMSHandler sMSHandler = new SMSHandler();
            //int resp = sMSHandler.addSMS(dbC.getConn(), sms);
            //Assert.IsNotNull(resp);
        }

        public void TestMethodFindID()
        {
            DBConnector dbC = new DBConnector();
            dbC.connect();

            SMSHandler sMSHandler = new SMSHandler();
            int

        }
    }
}
