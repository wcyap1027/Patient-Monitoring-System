using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class CentralStation
    {
        private int id;
        private string centralStationName;

        public int Id { get => id; set => id = value; }
        public string CentralStationName { get => centralStationName; set => centralStationName = value; }
    }
}
