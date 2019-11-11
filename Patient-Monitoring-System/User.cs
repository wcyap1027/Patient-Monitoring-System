using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitoringSystem
{
    class User
    {
        //string
        private string userid, password, role;

        //bool
        private bool loginStatus;

        //datetime
        private DateTime dateTimeRegister, dateTimeLogin, dateTimeLogOut;

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool LoginStatus
        {
            get { return loginStatus; }
            set { loginStatus = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public DateTime DateTimeRegister
        {
            get { return dateTimeRegister; }
            set { dateTimeRegister = value; }
        }

        public DateTime DateTimeLogin
        {
            get { return dateTimeLogin; }
            set { dateTimeLogin = value; }
        }

        public DateTime DateTimeLogOut
        {
            get { return dateTimeLogOut; }
            set { dateTimeLogOut = value; }
        }

        public void VerifyLogin(bool loginStatus)
        {
            bool login = true;

            if (loginStatus == true)
            {
                login = true;
            }
            else
            {
                login = false;
            }
        }
    }
}
