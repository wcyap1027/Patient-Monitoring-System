using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Patient_Monitoring_System.Class;

namespace Patient_Monitoring_System
{
    public class CentralStationHandler
    {

        //list centralstation
        public List<CentralStation> getAllCentralStation(MySqlConnection conn)
        {
            List<CentralStation> listCentralStation = new List<CentralStation>();
            string sql = "SELECT * FROM centralstation";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    CentralStation centralStation = new CentralStation();
                    centralStation.Id = (int)myReader.GetValue(0);
                    centralStation.CentralStationName = (string)myReader.GetValue(1);
                    listCentralStation.Add(centralStation);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listCentralStation;
        }

        //retrive bay name
        public string getBayName(MySqlConnection conn, string bayN)
        {
            CentralStation centralStation = new CentralStation();
            string bayName;
            string sql = "SELECT * FROM centralstation where centralStationName='" +bayN+ "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                if (myReader.Read())
                {
                    
                    centralStation.Id = (int)myReader.GetValue(0);
                    centralStation.CentralStationName = (string)myReader.GetValue(1);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            bayName = centralStation.CentralStationName;
            return bayName;
        }
        
        //list all beside id
        public List<Bedside> getAllBedsideMonitor(MySqlConnection conn, string bayN)
        {
            int id = 0;

            List<Bedside> listBedside = new List<Bedside>();
            string sql = "SELECT id FROM centralstation WHERE centralStationName='"+bayN+"'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var qrId = sqlComm.ExecuteScalar();

            if (qrId != null)
            {
                id = Convert.ToInt32(qrId);
            }

            string getAllBedsideSql = "Select * FROM bedsidemonitor WHERE centralStation_id='" + id + "'";
            MySqlCommand comm = new MySqlCommand(getAllBedsideSql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = comm.ExecuteReader();
                while(myReader.Read())
                {
                    Bedside bedside = new Bedside();
                    bedside.Id = (int)myReader.GetValue(0);
                    bedside.Status = (bool)myReader.GetValue(2);
                    listBedside.Add(bedside);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return listBedside;
        }


        //check patient available in beside
        public int checkPatientAvailableInBedside(MySqlConnection conn, int bedsideId)
        {
            int id = 0;

            string sql = "SELECT id FROM patient WHERE bedsideId ='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            var query = sqlComm.ExecuteScalar();

            if(query != null)
            {
                id = Convert.ToInt32(query);
            }
            return id;
        }

        //check which bedside availability for patient
        public int checkBedsideAvailableForPatient(MySqlConnection conn ,int patientId)
        {
            
            int id = 0;
            string sql = "SELECT bedsideId FROM patient WHERE id ='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if(query!= null)
            {
                id = Convert.ToInt32(query);
                   
            }

            return id;
        }

        //retrieve patient value from beside
        public double getMaxValue(MySqlConnection conn, Bedside bedside)
        {
            int id = 0;
            int lastId = 0;
            double bloodpressurevalue = 0.0;

            string sql = "SELECT patient.id FROM patient WHERE bedsideId='" + bedside.Id + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            var qrId = sqlComm.ExecuteScalar();
            if(qrId != null)
            {
                id = Convert.ToInt32(qrId);   
                if(id > 0)
                {
                    string sqlmaxId = "SELECT MAX(ID) FROM bloodpressure WHERE patient_id='" + id + "'";
                    MySqlCommand sqlComm2 = new MySqlCommand(sqlmaxId, conn);

                    var maxId = sqlComm2.ExecuteScalar();
                    if (maxId != null)
                    {
                        lastId = Convert.ToInt32(maxId);
                        string sqlMaxBP = "SELECT bloodPressureValue FROM bloodpressure WHERE patient_id='" + id + "' AND id='" + lastId + "'";
                        MySqlCommand sqlComm3 = new MySqlCommand(sqlMaxBP, conn);

                        var lastBloodPressureValue = sqlComm3.ExecuteScalar();

                        if (lastBloodPressureValue != null)
                        {
                            bloodpressurevalue = Convert.ToDouble(lastBloodPressureValue);
                        }
                    }
                    else
                    {
                        bloodpressurevalue = 0.0;
                    }

                }
            }

            return bloodpressurevalue;
        }


        //fetch centralstation name
        public void FetchCentralStationName(ComboBox selectedcomboBox)
        {
            selectedcomboBox.Items.Add("--Select ID--");

            selectedcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            CentralStationHandler centralStationHand = new CentralStationHandler();
            List<CentralStation> listCentralStation = new List<CentralStation>();
            listCentralStation = centralStationHand.getAllCentralStation(dbC.getConn());
            for (int i = 0; i < listCentralStation.Count; i++)
            {
                selectedcomboBox.Items.Add(listCentralStation[i].CentralStationName);
            }
        }
    }
}
