using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class patientInformation
    {
        private int id;
        private int nric;
        private string fullName;
        private string address;
        private string email;
        private string gender;
        private int phoneNum;
        private int age;
        private int bedsideId;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int NRIC
        {
            get { return nric; }
            set { nric = value; }
        }

        public string Fullname
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int BedsideId
        {
            get { return bedsideId; }
            set { bedsideId = value; }
        }
    }
}
