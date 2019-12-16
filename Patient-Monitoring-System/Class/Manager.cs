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
        private string id, firstName, lastName, email, address;

        //long
        private long identityCard;
        private int phone;

        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public long IdentityCard { get => identityCard; set => identityCard = value; }
        public int Phone { get => phone; set => phone = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
