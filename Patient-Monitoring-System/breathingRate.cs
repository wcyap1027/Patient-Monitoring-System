using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class breathingRate
    {
        private DateTime breathingRateTime, breathingRateDate;
        private double breathingRateValue;

        public DateTime BreathingRateDate
        {
            get { return breathingRateDate; }
            set { breathingRateDate = value; }
        }

        public DateTime BreathingRateTime
        {
            get { return breathingRateTime; }
            set { breathingRateTime = value; }
        }

        public double BreathingRateValue
        {
            get { return breathingRateValue; }
            set { breathingRateValue = value; }
        }
    }
}
