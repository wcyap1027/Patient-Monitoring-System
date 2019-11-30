using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Manager
{
    class PatientInformationHandler
    {
        private DataTable dt = new DataTable();

        public int displayPatientInfo(MySqlConnection conn, patientInformation patientss)
        {
            string sql = "SELECT * FROM patient (id, NRIC, fullName, address, email, gender, phone, age, bedsideId) "
                + " VALUES ('" + patientss.Id + "','" + patientss.NRIC + "', " + patientss.Fullname
                + "  , '" + patientss.Address + "','" + patientss.Email + "','" + patientss.Gender + "','" 
                + patientss.PhoneNum + "','" + patientss.Age + "','" + patientss.BedsideId +"')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public DataTable BindSource()
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            MySqlDataAdapter sqlData = new MySqlDataAdapter("SELECT * FROM patient", dbConn.getConn());
            dt.Clear();
            sqlData.Fill(dt);
            dbConn.getConn().Close();

            return dt;
        }

        public List<patientInformation> getAllPatient(MySqlConnection conn)
        {
            List<patientInformation> listpatientInfo = new List<patientInformation>();
            string sql = "SELECT * FROM patient WHERE 1";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    patientInformation patientInfor = new patientInformation();
                    patientInfor.Id = (int)myReader.GetValue(0);
                    patientInfor.NRIC = (int)myReader.GetValue(1);
                    patientInfor.Fullname = (string)myReader.GetValue(2);
                    patientInfor.Address = (string)myReader.GetValue(3);
                    patientInfor.Email = (string)myReader.GetValue(4);
                    patientInfor.Gender = (string)myReader.GetValue(5);
                    patientInfor.PhoneNum = (int)myReader.GetValue(6);
                    patientInfor.Age = (int)myReader.GetValue(7);
                    patientInfor.BedsideId = (int)myReader.GetValue(8);
                    listpatientInfo.Add(patientInfor);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return listpatientInfo;
        }
    }
}
