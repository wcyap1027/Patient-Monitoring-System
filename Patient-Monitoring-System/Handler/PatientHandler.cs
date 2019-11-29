using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Patient_Monitoring_System
{
    public class PatientHandler
    {
        
       

        public PatientHandler()
        {
            //
        }

       

        public int addNewPatient(MySqlConnection conn, Patient patient)
        {
            string sql = "INSERT into patient( fullName, NRIC, address, email, gender, phone, age)" + "VALUES('" + patient.FullName + "', '" + patient.Nric + "', '" + patient.Address + "', '" + patient.Email + "', '" + patient.Gender + "', '" + patient.Phone + "', '" + patient.Age + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }

        public List<Patient> getAllPatient(MySqlConnection conn)
        {
            List<Patient> listPatient = new List<Patient>();
            string sql = "SELECT * FROM patient";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                while (myReader.Read())
                {
                    Patient sPatient = new Patient();
                    sPatient.Id = (int)myReader.GetValue(0);
                    sPatient.Nric = (long)myReader.GetValue(1);
                    sPatient.FullName = (string)myReader.GetValue(2);
                    sPatient.Address = (string)myReader.GetValue(3);
                    sPatient.Email = (string)myReader.GetValue(4);
                    sPatient.Gender = (string)myReader.GetValue(5);
                    sPatient.Phone = (int)myReader.GetValue(6);
                    sPatient.Age = (int)myReader.GetValue(7);
                    if(myReader.GetValue(8) == null)
                    {
                        sPatient.BedsideId = "null";
                    }
                    
                    listPatient.Add(sPatient);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listPatient;
        }

        //public DataTable searchPatientData(MySqlConnection conn, object searchText)
        //{
     
        //    //string sql = "SELECT * FROM patient where id LIKE '"+Convert.ToInt32(fullName)+ "%' OR fullName LIKE '" + fullName+ "%' OR NRIC LIKE '" + Convert.ToInt32(fullName)+ "%' OR address LIKE '" + fullName+ "%' OR email  LIKE '" + fullName+ "%' OR gender LIKE '" + fullName+ "%' OR phone LIKE '" + Convert.ToInt32(fullName)+ "%' OR age LIKE '" + fullName+ "%' OR bedsideId LIKE '" + Convert.ToInt32(fullName)+"%'";

        //    int queryInt;
            

        //    //string sql = "SELECT * FROM patient where id LIKE '" + queryInt + "%' OR fullName LIKE '" + queryString + "%'";
        //    DBConnector dBConn = new DBConnector();
        //    dBConn.connect();
        //    MySqlDataAdapter sqlData = new MySqlDataAdapter(sql, dBConn.getConn());
        //    DataTable table = new DataTable();
        //    sqlData.Fill(table);
        //    dBConn.getConn().Close();

        //    return table;
        //}

        public DataTable BindSource()
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            MySqlDataAdapter sqlData = new MySqlDataAdapter("SELECT * FROM patient", dBConn.getConn());
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dBConn.getConn().Close();

            return table;
        }

        public DataTable searchData(string value)
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            string searchQuery = "SELECT * FROM patient where fullName='" + value + "'";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(searchQuery, dBConn.getConn());
            DataTable table = new DataTable();
            sqlData.Fill(table);

            return table;
        }

        

        public string getLastRecordID(MySqlConnection conn)
        {
            int id = 0;
            int aId = 1;

            string sql = "SELECT MAX(ID) FROM patient";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var qrId = sqlComm.ExecuteScalar();

            if (qrId != null)
            {
                id = Convert.ToInt32(qrId);
            }

            string lastId = (aId + id).ToString();

            return lastId;
        }
    }
}
