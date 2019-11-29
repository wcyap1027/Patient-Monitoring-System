using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System.Handler
{
    public class LoginHandler
    {
        public bool proceedLogin(MySqlConnection conn, string selectedDepartment, string userId, string password)
        {
            string department = selectedDepartment.ToLower();
            bool loginStatus = false;
            if(department == "nurse")
            {
                string sql = "SELECT nurse.nurse_id, user_account.password FROM nurse INNER JOIN user_account on nurse.user_account_id = user_account.id WHERE nurse.nurse_id='"+userId+"'";
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
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                if(department == "consultant")
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
                    if(department == "medical staff")
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
                        if(department == "management")
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

        public bool changeLoginStatus(MySqlConnection conn, string userId, bool status, string selectedDepartment)
        {
            bool loginstatus = false;
            string department = selectedDepartment.ToLower();

            if(department == "nurse")
            {
                string sql = "UPDATE user_account LEFT JOIN nurse ON user_account.id = nurse.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE nurse.nurse_id='" + userId + "'";
                MySqlCommand updateComm = new MySqlCommand(sql, conn);

                int update = updateComm.ExecuteNonQuery();
                if (update >= 0)
                {
                    loginstatus = true;
                }
            }
            else
            {
                if(department == "consultant")
                {
                    string sql = "UPDATE user_account LEFT JOIN consultant ON user_account.id = consultant.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE consultant.consultant_id='" + userId + "'";
                    MySqlCommand updateComm = new MySqlCommand(sql, conn);

                    int update = updateComm.ExecuteNonQuery();
                    if (update >= 0)
                    {
                        loginstatus = true;
                    }
                }
                else
                {
                    if(department == "medical staff")
                    {
                        string sql = "UPDATE user_account LEFT JOIN medicalstaff ON user_account.id = medicalstaff.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE medicalstaff.medicalStaff_id='" + userId + "'";
                        MySqlCommand updateComm = new MySqlCommand(sql, conn);

                        int update = updateComm.ExecuteNonQuery();
                        if (update >= 0)
                        {
                            loginstatus = true;
                        }
                    }
                    else
                    {
                        if(department == "management")
                        {
                            string sql = "UPDATE user_account LEFT JOIN management ON user_account.id = management.user_account_id SET user_account.dateTimeLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE management.management_id='" + userId + "'";
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
    }
}
