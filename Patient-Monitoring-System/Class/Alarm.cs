using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Alarm
    {
        private int patientId;
        private int readingId;
        private int specificId;
        private double triggerValue;
        private DateTime dateTimeTrigger;
        private DateTime dateTimeMuted;
        private string remark;
       
        public double TriggerValue { get => triggerValue; set => triggerValue = value; }
        public DateTime DateTimeTrigger { get => dateTimeTrigger; set => dateTimeTrigger = value; }
        public DateTime DateTimeMuted { get => dateTimeMuted; set => dateTimeMuted = value; }
        public string Remark { get => remark; set => remark = value; }
        public int ReadingId { get => readingId; set => readingId = value; }
        public int SpecificId { get => specificId; set => specificId = value; }
        public int PatientId { get => patientId; set => patientId = value; }
    }
}
