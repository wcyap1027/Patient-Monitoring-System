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
            DateTime currentDateTime = DateTime.Now;
            patient.RegisterDateTime = currentDateTime;
            string sql = "INSERT into patient( fullName, NRIC, address, email, gender, phone, age, registerDateTime, bedsideId)" + "VALUES('" + patient.FullName + "', '" + patient.Nric + "', '" + patient.Address + "', '" + patient.Email + "', '" + patient.Gender + "', '" + patient.Phone + "', '" + patient.Age + "', '" + patient.RegisterDateTime.ToString("yyyy-MM-dd HH:mm:ss") + "' , '" + patient.BedsideId + "')";
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
                    sPatient.RegisterDateTime = (DateTime)myReader.GetValue(8);
                    sPatient.BedsideId = (int)myReader.GetValue(9);
                    
                    
                    listPatient.Add(sPatient);
                }
                myReader.Close();
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

        //check patient id
        public bool checkPatientID(MySqlConnection conn, int patientId)
        {
            bool status = false;
            string sql = "SELECT patient_id FROM bloodpressure WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var qId = sqlComm.ExecuteScalar();

            if(qId != null)
            {
                status = true;
                MessageBox.Show("Exist");
            }
            else
            {
                status = false;
            }

            return status;
        }

        public List<Patient> getSpecificPatientList(MySqlConnection conn, string selectedId)
        {
            int userId = int.Parse(selectedId);
            List<Patient> listpatient = new List<Patient>();
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
                    oldPatient.RegisterDateTime = (DateTime)myReader.GetValue(8);
                    listpatient.Add(oldPatient);


                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listpatient;
        }

        public Patient getSpecificPatient(MySqlConnection conn, int selectedId)
        {
            Patient oldPatient = new Patient();
            string sql = "SELECT * FROM patient WHERE id= '" + selectedId + "'";
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

        public DataTable patientWithOptional(MySqlConnection conn, int patientId, string optional1)
        {
            string columnName = "";
            if(optional1 == "bloodpressure")
            {
                columnName = "bloodPressure";
            }
            else if(optional1 == "pulserate")
            {
                columnName = "pulseRate";
            }
            else if(optional1 == "breathingrate")
            {
                columnName = "breathingRate";
            }
            else if(optional1 == "temperature")
            {
                columnName = "temperature";
            }

            string sql = "SELECT "+ optional1 + ".id, "+ optional1 + "."+columnName+"Value, "+ optional1 + "." + columnName + "Time, " + optional1 + "." + columnName + "Date FROM " + optional1 + " WHERE "+ optional1 + ".patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

        /*public DataTable patientAlarm(MySqlConnection conn, int patientId, ComboBox selectedComboBox)
        {
            
            string sql = "SELECT alarm.id, alarm.alarmLevel, alarm.dateTimeTrigger, alarm.dateTimeMuted, reading.patient_id FROM alarm INNER JOIN reading ON alarm.reading_id = reading.id where reading.patient_id = ;" + patientId;
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlComm);
            DataTable dt = new DataTable();
            mySqlDataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }*/

        //public DataTable patientWith2Optional(MySqlConnection conn, int patientId, string optional1, string optional2)
        //{
        //    string columnName1 = "";
        //    string columnName2 = "";
        //    if (optional1 == "bloodpressure")
        //    {
        //        columnName1 = "bloodPressure";
        //    }
        //    else if (optional1 == "pulserate")
        //    {
        //        columnName1 = "pulseRate";
        //    }
        //    else if (optional1 == "breathingrate")
        //    {
        //        columnName1 = "breathingRate";
        //    }
        //    else if (optional1 == "temperature")
        //    {
        //        columnName1 = "temperature";
        //    }

        //    if (optional2 == "bloodpressure")
        //    {
        //        columnName2 = "bloodPressure";
        //    }
        //    else if (optional2 == "pulserate")
        //    {
        //        columnName2 = "pulseRate";
        //    }
        //    else if (optional2 == "breathingrate")
        //    {
        //        columnName2 = "breathingRate";
        //    }
        //    else if (optional2 == "temperature")
        //    {
        //        columnName2 = "temperature";
        //    }

        //    string sql = "SELECT " + optional1 + "." + columnName1 + "Value, " + optional1 + "." + columnName1 + "Time, " + optional1 + "." + columnName1 + "Date, "+optional2+"."+columnName2+"Value, "+optional2+"."+columnName2+"Time, "+optional2+"."+columnName2+"Date FROM patient INNER JOIN "+optional1+" ON +"+optional1+".patient_id = "+patientId+" INNER JOIN "+optional2+" ON "+optional2+".patient_id= "+patientId+"";
        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);
        //    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlComm);
        //    DataTable dt = new DataTable();
        //    mySqlDataAdapter.Fill(dt);
        //    conn.Close();
        //    return dt;
        //}

    }
}
