using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class PulseRate
    {
        private DateTime pulseRateTime, pulseRateDate;
        private double pulseRateValue;

        public DateTime PulseRateDate
        {
            get { return pulseRateDate; }
            set { pulseRateDate = value; }
        }

        public DateTime PulseRateTime
        {
            get { return pulseRateTime; }
            set { pulseRateTime = value; }
        }

        public double PulseRateValue
        {
            get { return pulseRateValue; }
            set { pulseRateValue = value; }
        }
    }
}
