using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class MedicalStaff : User
    {
        private string id, fullname, email, address;
        private int nric, phoneNumber;

        public string MedicalStafID
        {
            get { return id; }
            set { id = value; }
        }

        public string MedicalStaffFullName
        {
            get { return fullname; }
            set { fullname = value; }
        }

        public string MedicalStaffEmail
        {
            get { return email; }
            set { email = value; }
        }

        public string MedicalStaffAddress
        {
            get { return address; }
            set { address = value; }
        }

        public int MedicalStaffNRIC
        {
            get { return nric; }
            set { nric = value; }
        }

        public int MedicalStaffPhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public void MedicalStaffRegister()
        {

        }
    }
}
