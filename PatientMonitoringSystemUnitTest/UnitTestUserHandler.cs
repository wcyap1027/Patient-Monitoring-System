using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;
namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestUserHandler
    {
        //[TestMethod]
        //public void addNewUser()
        //{
        //    DBConnector dbC = new DBConnector();
        //    string resp = dbC.connect();
        //    Assert.AreEqual("Done", resp);

        //    Nurse nurse = new Nurse();
        //    Assert.IsInstanceOfType(nurse, typeof(object));

        //    nurse.RoleRepresentative = "N";
        //    nurse.Password = "123456";
        //    nurse.LoginStatus = false;
        //    nurse.DateTimeRegister = new DateTime(2019, 10, 25, 0, 0, 0);
        //    nurse.DateTimeLogin = new DateTime(2019, 10, 25, 0, 0, 0);
        //    nurse.DateTimeLogOut = new DateTime(2019, 10, 25, 0, 0, 0);

        //    nurse.FirstName = "Amy";
        //    nurse.LastName = "Wong";
        //    nurse.Address = "Jalan Loke Yew";
        //    nurse.Email = "amywong@gmail.com";
        //    nurse.Phone = 0132456789;
        //    nurse.NRIC1 = 123456789012;

        //    UserHandler userHandler = new UserHandler();

        //    int resp2 = userHandler.createNewNurse(dbC.getConn(), nurse);
        //    Assert.IsNotNull(resp2);

        //    int resp2 = userHandler.addNewNurse(dbC.getConn(), nurse);
        //    Assert.IsNotNull(resp2);

        //    int resp2 = userHandler.addNewNurse(dbC.getConn(), nurse);
        //    Assert.IsNotNull(resp2);
        //}

        //[TestMethod]
        //public void TestRegisterMedicalStaff()
        //{
        //    DBConnector dbConn = new DBConnector();
        //    dbConn.connect();

        //    UserHandler userHandler = new UserHandler();
        //    bool resp2 = userHandler.proceedLogin(dbConn.getConn(), "medical staff", "MS00001", "4567890");
        //    Assert.AreEqual(true, resp2);
        //    bool resp3 = userHandler.updateWorkStatus(dbConn.getConn(), "Register", "MS00001", "medical staff");
        //    if (resp2)
        //    {
        //        Assert.AreEqual(true, resp3);
        //    }
        //    else
        //    {
        //        resp3 = false;
        //        Assert.AreEqual(true, resp3);
        //    }
        //}

        //[TestMethod]
        //public void TestDeRegisterMedicalStaff()
        //{
        //    DBConnector dbConn = new DBConnector();
        //    dbConn.connect();

        //    UserHandler userHandler = new UserHandler();
        //    bool resp2 = userHandler.proceedLogin(dbConn.getConn(), "medical staff", "MS00001", "4567890");
        //    Assert.AreEqual(true, resp2);
        //    bool resp3 = userHandler.updateWorkStatus(dbConn.getConn(), "Deregister", "MS00001", "medical staff");
        //    if (resp2)
        //    {
        //        Assert.AreEqual(true, resp3);
        //    }
        //    else
        //    {
        //        resp3 = false;
        //        Assert.AreEqual(true, resp3);
        //    }
        //}

        //[TestMethod]
        //public void TestRegisterConsultant()
        //{
        //    DBConnector dbConn = new DBConnector();
        //    dbConn.connect();

        //    UserHandler userHandler = new UserHandler();
        //    bool resp2 = userHandler.proceedLogin(dbConn.getConn(), "consultant", "C10001", "3456789");
        //    Assert.AreEqual(true, resp2);
        //    bool resp3 = userHandler.updateWorkStatus(dbConn.getConn(), "Register", "C10001", "consultant");
        //    if (resp2)
        //    {
        //        Assert.AreEqual(true, resp3);
        //    }
        //    else
        //    {
        //        resp3 = false;
        //        Assert.AreEqual(true, resp3);
        //    }
        //}

        [TestMethod]
        public void TestDeRegisterConsultant()
        {
            DBConnector dbConn = new DBConnector();
            dbConn.connect();

            UserHandler userHandler = new UserHandler();
            bool resp2 = userHandler.proceedLogin(dbConn.getConn(), "consultant", "C10001", "3456789");
            Assert.AreEqual(true, resp2);
            bool resp3 = userHandler.updateWorkStatus(dbConn.getConn(), "Deregister", "C10001", "consultant");
            if (resp2)
            {
                Assert.AreEqual(true, resp3);
            }
            else
            {
                resp3 = false;
                Assert.AreEqual(true, resp3);
            }
        }
    }
}
