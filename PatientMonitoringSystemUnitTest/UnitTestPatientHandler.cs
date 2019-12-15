﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;


namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestPatientHandler
    {
        [TestMethod]
        public void TestPatient()
        {
            //connect database
            DBConnector dbC = new DBConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);
            Patient patient1 = new Patient();
            Assert.IsInstanceOfType(patient1, typeof(object));

            //patient1.FullName = "Jason";
            //patient1.Nric = 123456789123;
            //patient1.Address = "13, Jalan Kepong Perdana";
            //patient1.Email = "jason@gmail.com";
            //patient1.Gender = "Male";
            //patient1.Phone = 0123435761;
            //patient1.Age = 17;

            //int resp2 = PatientHandler.Instance.addNewPatient(dbC.getConn(), patient1);
            //Assert.IsNotNull(resp2);


        }
    }
}
