﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Patient
    {
        private string fullName, address, email, gender;
        private long identityCard;
        private int id, phone, age, bedsideId;
        private DateTime registerDateTime;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        
        public int Phone { get => phone; set => phone = value; }
        public int Age { get => age; set => age = value; }
        public int BedsideId { get => bedsideId; set => bedsideId = value; }
        public DateTime RegisterDateTime { get => registerDateTime; set => registerDateTime = value; }
        public long IdentityCard { get => identityCard; set => identityCard = value; }
    }
}
