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

        // validate login
        public bool proceedLogin(MySqlConnection conn, string department, string userId, string password)
        {
            bool loginStatus = false;
            if (department == "nurse")
            {
                string sql = "SELECT nurse.nurse_id, user_account.password FROM nurse INNER JOIN user_account on nurse.user_account_id = user_account.id WHERE nurse.nurse_id='" + userId + "'";
                MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                try
                {
                    MySqlDataReader myReader;
                    myReader = sqlComm.ExecuteReader();
                    if (myReader.Read())
                    {
                        string dbPass = (string)myReader.GetString("password");

                        if (dbPass == password)
                        {
                            loginStatus = true;
                            myReader.Close();
                        }
                        else
                        {
                            loginStatus = false;
                        }

                    }


                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                if (department == "consultant")
                {
                    string sql = "SELECT consultant.consultant_id, user_account.password FROM consultant INNER JOIN user_account on consultant.user_account_id = user_account.id WHERE consultant.consultant_id='" + userId + "'";
                    MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                    try
                    {
                        MySqlDataReader myReader;
                        myReader = sqlComm.ExecuteReader();

                        if (myReader.Read())
                        {
                            string dbPass = (string)myReader.GetString("password");

                            if (dbPass == password)
                            {
                                loginStatus = true;
                                myReader.Close();
                            }
                            else
                            {
                                loginStatus = false;
                            }

                        }


                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        Console.WriteLine(e.ToString());
                    }
                }
                else
                {
                    if (department == "medical staff")
                    {
                        string sql = "SELECT medicalstaff.medicalStaff_id, user_account.password FROM medicalstaff INNER JOIN user_account on medicalstaff.user_account_id = user_account.id WHERE medicalstaff.medicalStaff_id='" + userId + "'";
                        MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                        try
                        {
                            MySqlDataReader myReader;
                            myReader = sqlComm.ExecuteReader();
                            if (myReader.Read())
                            {
                                string dbPass = (string)myReader.GetString("password");
                                if (dbPass == password)
                                {
                                    loginStatus = true;
                                    myReader.Close();
                                }
                                else
                                {
                                    loginStatus = false;
                                }

                            }


                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                            Console.WriteLine(e.ToString());
                        }
                    }
                    else
                    {
                        if (department == "management")
                        {
                            string sql = "SELECT management.management_id, user_account.password FROM management INNER JOIN user_account ON management.user_account_id = user_account.id WHERE management.management_id='" + userId + "'";
                            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                            try
                            {
                                MySqlDataReader myReader;
                                myReader = sqlComm.ExecuteReader();
                                if (myReader.Read())
                                {
                                    string dbPass = (string)myReader.GetString("password");

                                    if (dbPass == password)
                                    {
                                        loginStatus = true;
                                        myReader.Close();
                                    }
                                    else
                                    {
                                        loginStatus = false;
                                    }

                                }


                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.ToString());
                                Console.WriteLine(e.ToString());
                            }
                        }
                    }
                }
            }
            return loginStatus;
        }

        //change loginStatus after login
        public bool changeLoginStatus(MySqlConnection conn, string userId, bool status, string selectedDepartment)
        {
            bool loginstatus = false;
            string department = selectedDepartment.ToLower();
            int statusLogin = 1;
            if (department == "nurse")
            {
                string sql = "UPDATE user_account LEFT JOIN nurse ON user_account.id = nurse.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', user_account.loginStatus='"+statusLogin + "' WHERE nurse.nurse_id='" + userId + "'";
                MySqlCommand updateComm = new MySqlCommand(sql, conn);

                int update = updateComm.ExecuteNonQuery();
                if (update == 1)
                {
                    loginstatus = true;
                }
            }
            else
            {
                if (department == "consultant")
                {
                    string sql = "UPDATE user_account LEFT JOIN consultant ON user_account.id = consultant.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', user_account.loginStatus='" + statusLogin + "' WHERE consultant.consultant_id='" + userId + "'";
                    MySqlCommand updateComm = new MySqlCommand(sql, conn);

                    int update = updateComm.ExecuteNonQuery();
                    if (update >= 0)
                    {
                        loginstatus = true;
                    }
                }
                else
                {
                    if (department == "medical staff")
                    {
                        string sql = "UPDATE user_account LEFT JOIN medicalstaff ON user_account.id = medicalstaff.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', user_account.loginStatus='" + statusLogin + "' WHERE medicalstaff.medicalStaff_id='" + userId + "'";
                        MySqlCommand updateComm = new MySqlCommand(sql, conn);

                        int update = updateComm.ExecuteNonQuery();
                        if (update >= 0)
                        {
                            loginstatus = true;
                        }
                    }
                    else
                    {
                        if (department == "management")
                        {
                            string sql = "UPDATE user_account LEFT JOIN management ON user_account.id = management.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', user_account.loginStatus='" + statusLogin + "' WHERE management.management_id='" + userId + "'";
                            MySqlCommand updateComm = new MySqlCommand(sql, conn);

                            int update = updateComm.ExecuteNonQuery();
                            if (update >= 0)
                            {
                                loginstatus = true;
                            }
                        }
                    }
                }
            }



            return loginstatus;
        }

        //update user work status
        public bool updateWorkStatus(MySqlConnection conn, string type, string userId, string selectedDepartment)
        {
            int registerStatus = 1;
            int deregisterStatus = 0;
            bool loginstatus = false;
            string department = selectedDepartment.ToLower();
            if(type == "Register")
            {
                if (department == "nurse")
                {
                    string sql = "UPDATE nurse SET nurse.work_status='" + registerStatus + "' WHERE nurse.nurse_id='" + userId + "'";
                    MySqlCommand updateComm = new MySqlCommand(sql, conn);

                    int update = updateComm.ExecuteNonQuery();
                    if (update == 1)
                    {
                        loginstatus = true;
                    }
                }
                else
                {
                    if (department == "consultant")
                    {
                        string sql = "UPDATE consultant SET consultant.work_status='" + registerStatus + "' WHERE consultant.consultant_id='" + userId + "'";
                        MySqlCommand updateComm = new MySqlCommand(sql, conn);

                        int update = updateComm.ExecuteNonQuery();
                        if (update >= 0)
                        {
                            loginstatus = true;
                        }
                    }
                    else
                    {
                        if (department == "medical staff")
                        {
                            string sql = "UPDATE medicalstaff SET medicalstaff.work_status='" + registerStatus + "' WHERE medicalstaff.medicalStaff_id='" + userId + "'";
                            MySqlCommand updateComm = new MySqlCommand(sql, conn);

                            int update = updateComm.ExecuteNonQuery();
                            if (update >= 0)
                            {
                                loginstatus = true;
                            }
                        }
                        else
                        {
                            if (department == "management")
                            {
                                string sql = "UPDATE management SET management.work_status='" + registerStatus + "' WHERE management.management_id='" + userId + "'";
                                MySqlCommand updateComm = new MySqlCommand(sql, conn);

                                int update = updateComm.ExecuteNonQuery();
                                if (update >= 0)
                                {
                                    loginstatus = true;
                                }
                            }
                        }
                    }
                }
            }
            else if(type == "Deregister")
            {
                if (department == "nurse")
                {
                    string sql = "UPDATE nurse SET nurse.work_status='" + deregisterStatus + "' WHERE nurse.nurse_id='" + userId + "'";
                    MySqlCommand updateComm = new MySqlCommand(sql, conn);

                    int update = updateComm.ExecuteNonQuery();
                    if (update == 1)
                    {
                        loginstatus = true;
                    }
                }
                else
                {
                    if (department == "consultant")
                    {
                        string sql = "UPDATE consultant SET consultant.work_status='" + deregisterStatus + "' WHERE consultant.consultant_id='" + userId + "'";
                        MySqlCommand updateComm = new MySqlCommand(sql, conn);

                        int update = updateComm.ExecuteNonQuery();
                        if (update >= 0)
                        {
                            loginstatus = true;
                        }
                    }
                    else
                    {
                        if (department == "medical staff")
                        {
                            string sql = "UPDATE medicalstaff SET medicalstaff.work_status='" + deregisterStatus + "' WHERE medicalstaff.medicalStaff_id='" + userId + "'";
                            MySqlCommand updateComm = new MySqlCommand(sql, conn);

                            int update = updateComm.ExecuteNonQuery();
                            if (update >= 0)
                            {
                                loginstatus = true;
                            }
                        }
                        else
                        {
                            if (department == "management")
                            {
                                string sql = "UPDATE management SET management.work_status='" + deregisterStatus + "' WHERE management.management_id='" + userId + "'";
                                MySqlCommand updateComm = new MySqlCommand(sql, conn);

                                int update = updateComm.ExecuteNonQuery();
                                if (update >= 0)
                                {
                                    loginstatus = true;
                                }
                            }
                        }
                    }
                }
            }
            
            return loginstatus;
        }

        //find user id using staff id
        public int FindUserId(MySqlConnection conn, string department, string userId)
        {
            int id = 0;
            if (department == "nurse")
            {
                string sql = "SELECT user_account.id FROM nurse INNER JOIN user_account on nurse.user_account_id = user_account.id WHERE nurse.nurse_id='" + userId + "'";
                MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                var query = sqlComm.ExecuteScalar();

                if (query != null)
                {
                    id = Convert.ToInt32(query);
                }
            }
            else if (department == "medical staff")
            {
                string sql = "SELECT user_account.id FROM medicalstaff INNER JOIN user_account on medicalstaff.user_account_id = user_account.id WHERE medicalstaff.medicalStaff_id='" + userId + "'";
                MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                var query = sqlComm.ExecuteScalar();

                if (query != null)
                {
                    id = Convert.ToInt32(query);
                }
            }
            else if (department == "management")
            {
                string sql = "SELECT user_account.id FROM management INNER JOIN user_account on management.user_account_id = user_account.id WHERE management.management_id='" + userId + "'";
                MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                var query = sqlComm.ExecuteScalar();

                if (query != null)
                {
                    id = Convert.ToInt32(query);
                }
            }
            else if (department == "consultant")
            {
                string sql = "SELECT user_account.id FROM consultant INNER JOIN user_account on consultant.user_account_id = user_account.id WHERE consultant.consultant_id='" + userId + "'";
                MySqlCommand sqlComm = new MySqlCommand(sql, conn);

                var query = sqlComm.ExecuteScalar();

                if (query != null)
                {
                    id = Convert.ToInt32(query);
                }
            }

            return id;
        }

        //log out
        public bool Logout(MySqlConnection conn, int userId)
        {
            bool status = false;
            int statusLogin = 0;
            DateTime currentDateTime = DateTime.Now;
            string sql = "UPDATE user_account SET user_account.dateTimeLogOut='" + currentDateTime.ToString("yyyy-MM-dd HH:mm:ss") + "', user_account.loginStatus='" + statusLogin + "' WHERE id='" + userId + "'";
            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            int update = sqlComm.ExecuteNonQuery();

            if (update == 1)
            {
                status = true;
            }
            else
            {
                status = false;
            }



            return status;
        }
    }
}
