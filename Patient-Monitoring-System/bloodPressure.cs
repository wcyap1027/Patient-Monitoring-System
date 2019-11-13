using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
   public class bloodPressure
    {
        private DateTime bloodPressureTime, bloodPressureDate;
        private double bloodPressureValue;

        public DateTime BloodPressureDate
        {
            get { return bloodPressureDate; }
            set { bloodPressureDate = value; }
        }

        public DateTime BloodPressureTime
        {
            get { return bloodPressureTime; }
            set { bloodPressureTime = value; }
        }

        public double BloodPressureValue
        {
            get { return bloodPressureValue; }
            set { bloodPressureValue = value; }
        }
    }
}
