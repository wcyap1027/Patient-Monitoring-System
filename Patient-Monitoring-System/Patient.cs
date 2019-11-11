using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMonitoringSystem
{
    class Patient : User
    {
        //string
        private string patient_id, patient_fullname, patient_email, patient_address, pic;

        //int
        private int patient_nric, patient_phonenumber, patient_emergencycontactnumber;

        //double
        private double patient_bloodpressure, patient_breathingrate, patient_pulserate, patient_temperature;

        public string PatientID
        {
            get { return patient_id; }
            set { patient_id = value; }
        }

        public string PatientFullname
        {
            get { return patient_fullname; }
            set { patient_fullname = value; }
        }

        public string PatientEmail
        {
            get { return patient_email; }
            set { patient_email = value; }
        }

        public string PatientAddress
        {
            get { return patient_address; }
            set { patient_address = value; }
        }

        public string NamePic
        {
            get { return pic; }
            set { pic = value; }
        }

        public int PatientNRIC
        {
            get { return patient_nric; }
            set { patient_nric = value; }
        }

        public int PatientPhoneNumber
        {
            get { return patient_phonenumber; }
            set { patient_phonenumber = value; }
        }

        public int PatientEmergencyContactNumber
        {
            get { return patient_emergencycontactnumber; }
            set { patient_emergencycontactnumber = value; }
        }

        public double PatientBloodPressure
        {
            get { return patient_bloodpressure; }
            set { patient_bloodpressure = value; }
        }

        public double PatientBreathingRate
        {
            get { return patient_breathingrate; }
            set { patient_breathingrate = value; }
        }

        public double PatientPulseRate
        {
            get { return patient_pulserate; }
            set { patient_pulserate = value; }
        }

        public double PatientTemperature
        {
            get { return patient_temperature; }
            set { patient_temperature = value; }
        }
    }
}
