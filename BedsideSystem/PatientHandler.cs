using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedsideSystem
{
   public class PatientHandler
    {
        public int patientList(MySqlConnection conn, patientList patientlist)
        {
            string sql = "SELECT FROM patient(id, reading_id, fullName, NRIC, address, email, gender, phone, age)";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            return sqlComm.ExecuteNonQuery();
        }
    }
}
