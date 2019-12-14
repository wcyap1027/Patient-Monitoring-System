using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Patient_Monitoring_System.Class;

namespace Patient_Monitoring_System.Handler
{
    public class SMSHandler
    {
        public int addSMS(MySqlConnection conn, SMS sms)
        {
            string sql = "INSERT into smslog (bedsideId, staffId, description, dateTimeSent) VALUES ('" + sms.BedsideId + "', '" + sms.StaffId + "', '" + sms.Description + "', '"+sms.DateTimeSent.ToString("yyyy-MM-dd HH:mm:ss")+"')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public int getLastId(MySqlConnection conn)
        {
            int id = 0;
            string sql = "SELECT MAX(ID) FROM smslog";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            var query = sqlComm.ExecuteScalar();

            if(!DBNull.Value.Equals(query))
            {
                id = Convert.ToInt32(query);
            }

            return id;
        }

        public SMS getSMSLog(MySqlConnection conn, int lastId)
        {
            string sql = "SELECT * FROM smslog WHERE id ='" + lastId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            SMS sms = new SMS();
            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();

                if (myReader.Read())
                {
                    sms.Id = (int)myReader.GetValue(0);
                    sms.BedsideId = (int)myReader.GetValue(1);
                    sms.StaffId = (string)myReader.GetValue(2);
                    sms.Description = (string)myReader.GetValue(3);
                    sms.DateTimeSent = (DateTime)myReader.GetValue(4);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return sms;
        }

        public List<MedicalStaff> getMedicalStaff(MySqlConnection conn, int bedsideId)
        {
            List<MedicalStaff> listMedicalStaff = new List<MedicalStaff>();

            string sql = "SELECT medicalStaff_id FROM medicalstaff WHERE currentBedsideId ='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();

                while (myReader.Read())
                {
                    MedicalStaff ms = new MedicalStaff();
                    ms.MedicalStafID = (string)myReader.GetValue(0);
                    listMedicalStaff.Add(ms);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return listMedicalStaff;
        }

        public List<MedicalStaff> getMedicalStaffId(MySqlConnection conn, int bedsideId)
        {
            string sql = "SELECT medicalStaff_id FROM medicalstaff WHERE currentBedsideId ='" + bedsideId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            List<MedicalStaff> medicalStaffs = new List<MedicalStaff>();
            try
            {
                MySqlDataReader myReader;
                myReader = sqlComm.ExecuteReader();

                while (myReader.Read())
                {
                    MedicalStaff ms = new MedicalStaff();
                    ms.MedicalStafID = (string)myReader.GetValue(2);
                    medicalStaffs.Add(ms);
                }
                myReader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return medicalStaffs;
        }
    }
}
