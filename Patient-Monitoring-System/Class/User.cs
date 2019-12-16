using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class User
    {
        //int
        private int id;

        //string
        private string  password, roleRepresentative;

        //bool
        private bool loginStatus;

        //datetime
        private DateTime dateTimeRegister, dateTimeLogin, dateTimeLogOut;

        
        public string Password { get => password; set => password = value; }
        public string RoleRepresentative { get => roleRepresentative; set => roleRepresentative = value; }
        public bool LoginStatus { get => loginStatus; set => loginStatus = value; }
        public DateTime DateTimeRegister { get => dateTimeRegister; set => dateTimeRegister = value; }
        public DateTime DateTimeLogin { get => dateTimeLogin; set => dateTimeLogin = value; }
        public DateTime DateTimeLogOut { get => dateTimeLogOut; set => dateTimeLogOut = value; }
        public int Id { get => id; set => id = value; }
    }
}
