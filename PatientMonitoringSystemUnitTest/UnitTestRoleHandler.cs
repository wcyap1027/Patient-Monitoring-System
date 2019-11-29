using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;

namespace PatientMonitoringSystemUnitTest
{
    [TestClass]
    public class UnitTestRoleHandler
    {
        [TestMethod]
        public void TestRoleHandler()
        {
            DBConnector dbC = new DBConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);
            Role role = new Role();
            Assert.IsInstanceOfType(role, typeof(object));

            //role.Represent = "N";
            //role.Postion = "Nurse";

            //role.Represent = "C";
            //role.Postion = "Consultant";

            //role.Represent = "MG";
            //role.Postion = "Management";

            //role.Represent = "MS";
            //role.Postion = "Medical Staff";

            //RoleHandler roleHandler = new RoleHandler();

            //int resp2 = roleHandler.addNewRole(dbC.getConn(), role);
            //Assert.IsNotNull(resp2);

        }
    }
}
