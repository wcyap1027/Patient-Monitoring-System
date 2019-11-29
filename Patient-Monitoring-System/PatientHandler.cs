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
        private static PatientHandler instance;
        private DataTable dt = new DataTable();

        private PatientHandler()
        {
            //
        }

        public static PatientHandler Instance 
        {
            get
            {
                if(instance == null)
                {
                    instance = new PatientHandler();
                }
                return instance;
            }
 
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
            string sql = "SELECT * FROM patient LIMIT 100";
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

    }
}
