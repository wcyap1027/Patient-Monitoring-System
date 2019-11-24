using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedsideSystem
{
    public class patientList
    {
        private int id;
        private int reading_id;
        private string fullname;
        private int NRIC;
        private string address;
        private string email;
        private string gender;
        private int phone;
        private int age;

        public int Id { get => id; set => id = value; }
        public int Reading_id { get => reading_id; set => reading_id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int NRIC1 { get => NRIC; set => NRIC = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Phone { get => phone; set => phone = value; }
        public int Age { get => age; set => age = value; }
    }
}
