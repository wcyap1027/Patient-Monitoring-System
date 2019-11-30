using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System.Class
{
    public class Bedside
    {
        private int id;
        private int centralStationId;
        private bool status;

        public int Id { get => id; set => id = value; }
        public int CentralStationId { get => centralStationId; set => centralStationId = value; }
        public bool Status { get => status; set => status = value; }
    }
}
