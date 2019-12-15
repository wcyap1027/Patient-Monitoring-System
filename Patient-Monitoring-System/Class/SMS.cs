using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System.Class
{
    public class SMS
    {
        private int id;
        private int bedsideId;
        private string description, staffId;
        private DateTime dateTimeSent;

        public int BedsideId { get => bedsideId; set => bedsideId = value; }
        public string StaffId { get => staffId; set => staffId = value; }
        public string Description { get => description; set => description = value; }
        public DateTime DateTimeSent { get => dateTimeSent; set => dateTimeSent = value; }
        public int Id { get => id; set => id = value; }
    }
}
