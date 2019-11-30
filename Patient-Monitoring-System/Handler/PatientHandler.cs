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
            string sql = "INSERT into patient( fullName, NRIC, address, email, gender, phone, age, bedsideId)" + "VALUES('" + patient.FullName + "', '" + patient.Nric + "', '" + patient.Address + "', '" + patient.Email + "', '" + patient.Gender + "', '" + patient.Phone + "', '" + patient.Age + "', '"+patient.BedsideId+"')";
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
                    sPatient.BedsideId = (int)myReader.GetValue(8);
                    
                    
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

        public Patient getSpecificPatient(MySqlConnection conn, string selectedId)
        {
            int userId = int.Parse(selectedId);
            Patient oldPatient = new Patient();
            string sql = "SELECT * FROM patient WHERE id= '" + userId + "'";
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
                    if (myReader.GetValue(8) == null)
                    {
                        oldPatient.BedsideId = 0;
                    }

                    
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

        public int updatePatientData(MySqlConnection conn, Patient patient)
        {
            string sql = "UPDATE patient SET NRIC='" + patient.Nric + "', fullName= '"+patient.FullName+"', address='" + patient.Address + "', email='"+patient.Email +"', gender='"+patient.Gender+"', phone='"+patient.Phone+"', age='"+patient.Age+"', bedsideId='" + patient.BedsideId+"' WHERE id='" + patient.Id + "'";
            MySqlCommand updateComm = new MySqlCommand(sql, conn);

            return updateComm.ExecuteNonQuery();
            
        }

        public int deletePatientData(MySqlConnection conn, int id)
        {
            string sql = "DELETE FROM patient WHERE id= '" + id + "'";
            MySqlCommand deleteComm = new MySqlCommand(sql, conn);
            return deleteComm.ExecuteNonQuery();
        }

        //public int alterTable(MySqlConnection conn, int id)
        //{
        //    string sql = "ALTER TABLE patient AUTO INCREMENT= '" + id + "'";
        //    MySqlCommand alterCommand = new MySqlCommand(sql, conn);
        //    return alterCommand.ExecuteNonQuery();
        //}

        public void FetchId(ComboBox selectedcomboBox)
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
                selectedcomboBox.Items.Add(patientList[i].Id);
            }
        }
    }
}
