using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    class Manager : User
    {
        //string
        private string manager_id, manager_fullname, manager_email, manager_address;

        //int
        private int manager_nric, manager_phonenumber;

        public string ManagerID
        {
            get { return manager_id; }
            set { manager_id = value; }
        }

        public string ManagerFullName
        {
            get { return manager_fullname; }
            set { manager_fullname = value; }
        }

        public string ManagerEmail
        {
            get { return manager_email; }
            set { manager_email = value; }
        }

        public string ManagerAddress
        {
            get { return manager_address; }
            set { manager_address = value; }
        }

        public int ManagerNRIC
        {
            get { return manager_nric; }
            set { manager_nric = value; }
        }

        public int ManagerPhoneNumber
        {
            get { return manager_nric; }
            set { manager_phonenumber = value; }
        }
    }
}
