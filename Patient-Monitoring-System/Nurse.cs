using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitoringSystem
{
    class Nurse : User
    {
        //string 
        private string nurse_id, nurse_fullname, nurse_email, nurse_address;

        //int
        private int nurse_nric, nurse_phonenumber;

        public string NurseID
        {
            get { return nurse_id; }
            set { nurse_id = value; }
        }

        public string NurseFullName
        {
            get { return nurse_fullname; }
            set { nurse_fullname = value; }
        }

        public string NurseEmail
        {
            get { return nurse_email; }
            set { nurse_email = value; }
        }

        public string NurseAddress
        {
            get { return nurse_address; }
            set { nurse_address = value; }
        }

        public int NurseNRIC
        {
            get { return nurse_nric; }
            set { nurse_nric = value; }
        }

        public int NursePhoneNumber
        {
            get { return nurse_phonenumber; }
            set { nurse_phonenumber = value; }
        }
    }
}
