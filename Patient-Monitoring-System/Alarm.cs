using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Monitoring_System
{
    public class Alarm
    {
        private string id;
        private string alarmLevel;
        private DateTime dateTimeTrigger;
        private DateTime dateTimeMuted;

        public string Id { get => id; set => id = value; }
        public DateTime DateTimeTrigger { get => dateTimeTrigger; set => dateTimeTrigger = value; }
        public DateTime DateTimeMuted { get => dateTimeMuted; set => dateTimeMuted = value; }
        public string AlarmLevel { get => alarmLevel; set => alarmLevel = value; }
    }
}
