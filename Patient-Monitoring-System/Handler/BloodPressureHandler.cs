using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Patient_Monitoring_System.Handler
{
    public class BloodPressureHandler
    {

        //add new bloodpressure values to the patient
        public int addNewBloodPressure(MySqlConnection conn, BloodPressure bloodPressure, int patientId)
        {
            string sql = "INSERT into bloodpressure( patient_id, bloodPressureValue, bloodPressureTime, bloodPressureDate)" + "VALUES('" + patientId + "', '" + bloodPressure.BloodPressureValue + "', '" + bloodPressure.BloodPressureTime.ToString("HH:mm:ss") + "', '" + bloodPressure.BloodPressureDate.ToString("yyyy-MM-dd") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();

        }

        //public bool checkOption(MySqlConnection conn, int userOption)
        //{
        //    bool status = false;
        //    string sql = "SELECT id FROM bloodpressure WHERE id='" + userOption + "'";
        //    MySqlCommand sqlComm = new MySqlCommand(sql, conn);

        //    var qId = sqlComm.ExecuteScalar();

        //    if (qId != null)
        //    {
        //        status = true;
        //        MessageBox.Show("Exist");
        //    }
        //    else
        //    {
        //        status = false;
        //    }

        //    return status;
        //}

        public List<BloodPressure> getSpecificBloodPressureList(MySqlConnection conn, string optionId)
        {
            int bpId = int.Parse(optionId);
            List<BloodPressure> listbloodpressure = new List<BloodPressure>();
            Patient patientinfo = new Patient();
            BloodPressure bloodpressurereading = new BloodPressure();
            string sql = "SELECT * FROM bloodpressure WHERE id= '" + bpId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();
                if (myReader.Read())
                {

                    bloodpressurereading.BloodPressureDate = (DateTime)myReader.GetValue(0);
                    bloodpressurereading.BloodPressureTime = (DateTime)myReader.GetValue(1);
                    bloodpressurereading.BloodPressureValue = (int)myReader.GetValue(2);

                    if (myReader.GetValue(2) == null)
                    {
                        bloodpressurereading.BloodPressureId = 0;
                    }
                    listbloodpressure.Add(bloodpressurereading);


                }
                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }

            return listbloodpressure;
        }

        public int getLastIdBloodPressure(MySqlConnection conn, int patientId)
        {
            int id = 0;
            string sql = "SELECT MAX(ID) FROM bloodpressure WHERE patient_id='" + patientId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if(!(query is DBNull))
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        public double getLastBloodPressure(MySqlConnection conn, int patientId, int lastId)
        {
            double maxBP = 0.0;
            string sql = "SELECT bloodPressureValue FROM bloodpressure WHERE patient_id='" + patientId + "' AND id='"+lastId+"'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if (!(query is DBNull))
            {
                maxBP = Convert.ToDouble(query);
            }

            return maxBP;
        }
    }
}
