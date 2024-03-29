﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System.Handler;
using Patient_Monitoring_System.Screen;

namespace Patient_Monitoring_System
{
    public partial class Login : Form
    {
        //set static field after login
        public static string userIdStatic;
        public static string userDepartment;
        public Login()
        {
            InitializeComponent();
            //fill combobox
            setDepartment();
            
        }

        //login
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (departmentComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select department");
                return;
            }

            if (usernameTextBox.Text == "Enter your user id")
            {
                MessageBox.Show("Please enter username");
                return;
            }

            if (passwordTextBox.Text == "Enter password")
            {
                MessageBox.Show("Please enter password");
                return;
            }



            DBConnector dbC = new DBConnector();
            dbC.connect();
            UserHandler userHandler = new UserHandler();
            bool login = userHandler.proceedLogin(dbC.getConn(), departmentComboBox.SelectedItem.ToString().ToLower(), usernameTextBox.Text, passwordTextBox.Text);

            if (login)
            {
                bool status = userHandler.changeLoginStatus(dbC.getConn(), usernameTextBox.Text, login, departmentComboBox.SelectedItem.ToString());

                if (status)
                {
                    userIdStatic = usernameTextBox.Text;
                    userDepartment = departmentComboBox.SelectedItem.ToString().ToLower();
                    MainScreen mainscreen = new MainScreen();
                    mainscreen.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password");
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }

            //MainScreen mainscreen = new MainScreen();
            //mainscreen.Show();
            //Close();

        }

        //reset all field
        private void resetBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "Enter your user id";
            passwordTextBox.Text = "Enter password";
        }

        //create placeholder for user id
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Enter your user id")
            {
                usernameTextBox.Text = "";
                usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "")
            {
                usernameTextBox.Text = "Enter your user id";
                usernameTextBox.ForeColor = Color.Silver;
            }
        }

        //create placeholder for password
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = "Enter password";
                passwordTextBox.ForeColor = Color.Silver;
                passwordTextBox.PasswordChar = '\0';
            }
        }

        //fill combobox by taking database value
        private void setDepartment()
        {
            departmentComboBox.Items.Clear();
            departmentComboBox.Items.Add("--Select Department--");
            departmentComboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            RoleHandler roleHandler = new RoleHandler();
            List<Role> rolesList = new List<Role>();
            rolesList = roleHandler.getAllRole(dbC.getConn());
            for (int i = 0; i < rolesList.Count; i++)
            {
                departmentComboBox.Items.Add(rolesList[i].Position);
            }
        }
        
        //register/deregister button
        private void registerDeregisterBtn_Click(object sender, EventArgs e)
        {
            RegisterDeregisterScreen registerDeregisterScreen = new RegisterDeregisterScreen();
            registerDeregisterScreen.Show();
        }

        
    }
}
