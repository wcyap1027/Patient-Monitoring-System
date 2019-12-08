using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Patient_Monitoring_System.Class;

namespace Patient_Monitoring_System.Handler
{
    public class BedsideHandler
    {
        public List<Bedside> getAllBedside(MySqlConnection conn)
        {
            List<Bedside> listBedside = new List<Bedside>();
            string sql = "SELECT * FROM bedsidemonitor";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    Bedside bedside = new Bedside();
                    bedside.Id = (int)myReader.GetValue(0);
                    bedside.CentralStationId = (int)myReader.GetValue(1);
                    bedside.Status = (bool)myReader.GetValue(2);

                    listBedside.Add(bedside);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listBedside;
        }

        public void FetchBedsideId(ComboBox selectedcomboBox, bool status)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            List<Bedside> listBedside = new List<Bedside>();
            listBedside = bedsideHandler.getAllBedside(dbC.getConn());
            for (int i = 0; i < listBedside.Count; i++)
            {
                if(listBedside[i].Status == status)
                {
                    selectedcomboBox.Items.Add(listBedside[i].Id);
                }
                
            }
        }

        public void FetchBedsidePatientId(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            PatientHandler patientHandler = new PatientHandler();
            List<Patient> patientList = new List<Patient>();
            patientList = patientHandler.getAllPatient(dbC.getConn());
            for (int i = 0; i < patientList.Count; i++)
            {
                if((patientList[i].BedsideId == 0))
                {
                    selectedcomboBox.Items.Add(patientList[i].Id);
                }
                
            }
        }

        public void FetchBedsideExistingPatientId(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            PatientHandler patientHandler = new PatientHandler();
            List<Patient> patientList = new List<Patient>();
            patientList = patientHandler.getAllPatient(dbC.getConn());
            for (int i = 0; i < patientList.Count; i++)
            {
                if ((patientList[i].BedsideId != 0))
                {
                    selectedcomboBox.Items.Add(patientList[i].Id);
                }

            }
        }

        public int assignBedside(MySqlConnection conn, int bedsideId, int patientId)
        {
            string sql = "UPDATE patient SET bedsideId='" + bedsideId + "' WHERE id='" + patientId + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);

            return updateComm.ExecuteNonQuery();
        }

        public int updateStatus(MySqlConnection conn, int bedsideId)
        {
            int status = 1;
            string sql = "UPDATE bedsidemonitor SET status='" + status + "' WHERE id='" + bedsideId + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);
            return updateComm.ExecuteNonQuery();
        }

        public bool checkExistBedside(MySqlConnection conn, int selectedId)
        {
            bool status = false;
            int id = 0;
            string sql = "SELECT bedsideId FROM patient WHERE bedsideId='" + selectedId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                id = Convert.ToInt32(query);
            }

            if(id != 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        public Patient getSpecificPatientInBedside(MySqlConnection conn, int selectedId)
        {
            Patient oldPatient = new Patient();
            string sql = "SELECT * FROM patient WHERE bedsideId= '" + selectedId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                if (myReader.Read())
                {

                    oldPatient.Id = (int)myReader.GetValue(0);
                    oldPatient.Nric = (long)myReader.GetValue(1);
                    oldPatient.FullName = (string)myReader.GetValue(2);
                    oldPatient.Address = (string)myReader.GetValue(3);
                    oldPatient.Email = (string)myReader.GetValue(4);
                    oldPatient.Gender = (string)myReader.GetValue(5);
                    oldPatient.Phone = (int)myReader.GetValue(6);
                    oldPatient.Age = (int)myReader.GetValue(7);
                    oldPatient.RegisterDateTime = (DateTime)myReader.GetValue(8);
                   oldPatient.BedsideId = (int)myReader.GetValue(9);
                    
                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return oldPatient;
        }

        public bool continueBedside(MySqlConnection conn, int bedsideId, int patientId)
        {
            bool continueStatus;
            string sql = "SELECT id, bedsideId FROM patient WHERE id='" + patientId + "' AND bedsideId= '" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if(query != null)
            {
                continueStatus = true;
            }
            else
            {
                continueStatus = false;
            }

            return continueStatus;
        }

        public int updateAlarmStatus(MySqlConnection conn, int bedsideId, int alarmStatus)
        {
            string sql = "UPDATE bedsidemonitor SET alarmStatus='" + alarmStatus + "' WHERE id='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int updateAlarmZeroStatus(MySqlConnection conn, int bedsideId, int alarmStatus)
        {
            string sql = "UPDATE bedsidemonitor SET alarmZeroStatus='" + alarmStatus + "' WHERE id='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int SelectAlarmStatusBedside(MySqlConnection conn, int bedsideId)
        {
            int status = 0;
            string sql = "SELECT alarmStatus FROM bedsidemonitor WHERE id='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                status = Convert.ToInt32(query);
            }

            return status;
        }

        public int SelectAlarmZeroStatusBedside(MySqlConnection conn, int bedsideId)
        {
            int status = 0;
            string sql = "SELECT alarmZeroStatus FROM bedsidemonitor WHERE id='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (query != null)
            {
                status = Convert.ToInt32(query);
            }

            return status;
        }
    }
}
