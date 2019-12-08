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
        private string nurseid;
        private string fName;
        private string lName;
        private Boolean dutystatus;

        public DateTime Date { get => date; set => date = value; }
        public string Nurseid { get => nurseid; set => nurseid = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public bool Dutystatus { get => dutystatus; set => dutystatus = value; }
    }
}
