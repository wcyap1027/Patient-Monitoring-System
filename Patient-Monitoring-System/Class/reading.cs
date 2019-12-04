using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Reading
    {
        private string reading_id;
        private double minBloodPressure;
        private double maxBloodPressure;
        private double minTemperature;
        private double maxTemperature;
        private double minPulse;
        private double maxPulse;
        private double minBreathing;
        private double maxBreathing;

        public string Reading_id { get => reading_id; set => reading_id = value; }
        public double MinBloodPressure { get => minBloodPressure; set => minBloodPressure = value; }
        public double MaxBloodPressure { get => maxBloodPressure; set => maxBloodPressure = value; }
        public double MinTemperature { get => minTemperature; set => minTemperature = value; }
        public double MaxTemperature { get => maxTemperature; set => maxTemperature = value; }
        public double MinPulse { get => minPulse; set => minPulse = value; }
        public double MaxPulse { get => maxPulse; set => maxPulse = value; }
        public double MinBreathing { get => minBreathing; set => minBreathing = value; }
        public double MaxBreathing { get => maxBreathing; set => maxBreathing = value; }
    }
}
