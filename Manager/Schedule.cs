using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class Schedule
    {
        private DateTime date;
        private int id;
        private string staffid;
        private string fName;
        private string lName;
        private Boolean dutystatus;

        
        public int Id { get => id; set => id = value; }

        public DateTime Date { get => date; set => date = value; }

        public string Staffid { get => staffid; set => staffid = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public bool Dutystatus { get => dutystatus; set => dutystatus = value; }
    }
}
