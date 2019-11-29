using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Role
    {
        //int
        private int id;
        //string
        private string represent, position;

        public Role()
        {
            //
        }

        public Role(string position)
        {
            this.position = position;
        }

        public string Position { get => position; set => position = value; }
        public string Represent { get => represent; set => represent = value; }
    }
}
