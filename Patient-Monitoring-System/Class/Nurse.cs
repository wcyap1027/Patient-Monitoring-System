using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Nurse : User
    {
        private int userAccountId, phone;
        private string nurseId, firstName, lastName, address, email;
        private long NRIC;

        public int UserAccountId { get => userAccountId; set => userAccountId = value; }
        public int Phone { get => phone; set => phone = value; }
        public string NurseId { get => nurseId; set => nurseId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public long NRIC1 { get => NRIC; set => NRIC = value; }
    }
}