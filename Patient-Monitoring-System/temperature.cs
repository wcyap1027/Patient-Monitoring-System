using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Temperature
    {
        private DateTime temperatureTime, temperatureDate;
        private double temperatureValue;

        public DateTime TemperatureDate
        {
            get { return temperatureDate; }
            set { temperatureDate = value; }
        }

        public DateTime TemperatureTime
        {
            get { return temperatureTime; }
            set { temperatureTime = value; }
        }

        public double TemperatureValue
        {
            get { return temperatureValue; }
            set { temperatureValue = value; }
        }
    }
}
