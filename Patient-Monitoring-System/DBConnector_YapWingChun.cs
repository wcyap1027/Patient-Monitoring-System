﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Patient_Monitoring_System
{


    public class DBConnector_YapWingChun
    {
        MySqlConnection conn;

        public string connection()
        {
            string hostname = "server=localhost;user=admin;database=patientmonitoringdb;port=3306;password=admin123";
            conn = new MySqlConnection(hostname);

            try
            {
                conn.Open();
            }
            catch(Exception e)
            {
                return e.ToString();
            }

            return "Connected Succesfully!";
        }
        

        
        public MySqlConnection getConn()
        {
            return conn;
        }
    }
}
