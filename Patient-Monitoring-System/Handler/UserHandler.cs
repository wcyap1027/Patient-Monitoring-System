﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Patient_Monitoring_System.Handler
{
    public class UserHandler
    {
        public int addNewNurse(MySqlConnection conn, Nurse nurse)
        {
            int lastId = 0;
            string role_represent ="";
            string lastIdNurse = "";
            string finalId;
            string sql = "INSERT into user_account( role_representative, password, loginStatus, dateTimeRegister, dateTimeLogin, dateTimeLogOut)" + "VALUES('" + nurse.RoleRepresentative + "', '" + nurse.Password + "', '" + nurse.LoginStatus + "', '" + nurse.DateTimeRegister.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + nurse.DateTimeLogin.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + nurse.DateTimeLogOut.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            int result = sqlComm.ExecuteNonQuery();

            if(result != 0)
            {
                string queryWithMAXID = "SELECT MAX(ID) FROM user_account";
                MySqlCommand sqlComm2 = new MySqlCommand(queryWithMAXID, conn);

                var qrId = sqlComm2.ExecuteScalar();

                if (qrId != null)
                {
                    lastId = Convert.ToInt32(qrId);
                }

                string insertsql = "INSERT into nurse( user_account_id, first_name, last_name, NRIC, address, email, phone)" + "VALUES('" + lastId + "', '" + nurse.FirstName + "', '" + nurse.LastName + "', '" + nurse.NRIC1 + "', '" + nurse.Address + "', '" + nurse.Email + "', '" + nurse.Phone + "')";
                MySqlCommand insertComm = new MySqlCommand(insertsql, conn);
                int result2 = insertComm.ExecuteNonQuery();

                if(result2 != 0)
                {
                   
                    string queryWithRole = "SELECT role_representative FROM user_account where id = '" + lastId + "'";
                    MySqlCommand sqlComm3 = new MySqlCommand(queryWithRole, conn);
                    var qrRole = sqlComm3.ExecuteScalar();

                    
                    if(qrRole != null)
                    {
                        role_represent = Convert.ToString(qrRole);
                    }

                    string queryMaxid = "SELECT MAX(ID) FROM nurse";
                    MySqlCommand sqlComm4 = new MySqlCommand(queryMaxid, conn);
                    var qrNurseId = sqlComm4.ExecuteScalar();
                    if (qrNurseId != null)
                    {
                        lastIdNurse = Convert.ToString(qrNurseId);
                    }
                    
                }
            }
            finalId = role_represent + lastIdNurse;
            string insertSql = "INSERT into nurse( nurse_id)" + "VALUES('" + finalId + "')";
            MySqlCommand insertComm2 = new MySqlCommand(insertSql, conn);
            return insertComm2.ExecuteNonQuery();
        }
    }
}