using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class Schedule
    {
        private int id;
        private string staffId;
        private string firstName, lastName;
        private DateTime todayDate;
        private bool dutyStatus;

        public int Id { get => id; set => id = value; }
        public string StaffId { get => staffId; set => staffId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime TodayDate { get => todayDate; set => todayDate = value; }
        public bool DutyStatus { get => dutyStatus; set => dutyStatus = value; }
    }
}
