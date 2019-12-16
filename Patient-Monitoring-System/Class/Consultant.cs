using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System.Class
{
    public class Consultant
    {
        private string id, firstName, lastName, email, address;
        private int phoneNumber;
        private long identityCard;

        public string Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public long IdentityCard { get => identityCard; set => identityCard = value; }
    }
}
