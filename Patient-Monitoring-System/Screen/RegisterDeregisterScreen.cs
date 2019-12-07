using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System.Handler;

namespace Patient_Monitoring_System.Screen
{
    public partial class RegisterDeregisterScreen : Form
    {
        public RegisterDeregisterScreen()
        {
            InitializeComponent();
            setRegisterDepartment();
            setRegisterType();
        }

        //set register type
        public void setRegisterType()
        {
            registerTypecomboBox.Items.Add("--Select Type--");
            registerTypecomboBox.Items.Add("Register");
            registerTypecomboBox.Items.Add("Deregister");
            registerTypecomboBox.SelectedIndex = 0;
        }

        //set department data from database
        public void setRegisterDepartment()
        {
            registerDepartmentcomboBox.Items.Add("--Select Department--");
            registerDepartmentcomboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            RoleHandler roleHandler = new RoleHandler();
            List<Role> rolesList = new List<Role>();
            rolesList = roleHandler.getAllRole(dbC.getConn());
            for (int i = 0; i < rolesList.Count; i++)
            {
                registerDepartmentcomboBox.Items.Add(rolesList[i].Position);
            }
        }

        //make button changes when user select different index
        private void registerTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(registerTypecomboBox.SelectedIndex == 0)
            {
                registerbtn.Hide();
                deRegisterbtn.Hide();
            }
            else if(registerTypecomboBox.SelectedIndex == 1)
            {
                registerbtn.Show();
                deRegisterbtn.Hide();
            }
            else if(registerTypecomboBox.SelectedIndex == 2)
            {
                registerbtn.Hide();
                deRegisterbtn.Show();
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            //validate department value
            if (registerDepartmentcomboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter your department before registering", "Select Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate userid value
            if (string.IsNullOrEmpty(userIdtextBox.Text))
            {
                MessageBox.Show("Please enter your user id before registering", "Enter User id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate password value
            if (string.IsNullOrEmpty(passwordtextBox.Text))
            {
                MessageBox.Show("Please enter your password before registering", "Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check user whether he exist in database
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            LoginHandler loginHandler = new LoginHandler();
            UserHandler userHandler = new UserHandler();
            bool status = loginHandler.proceedLogin(dBConn.getConn(), registerDepartmentcomboBox.SelectedItem.ToString(), userIdtextBox.Text, passwordtextBox.Text);

            if (status)
            {
                //update registering status
                bool updateStatus = userHandler.updateWorkStatus(dBConn.getConn(), registerTypecomboBox.SelectedItem.ToString(), userIdtextBox.Text, registerDepartmentcomboBox.SelectedItem.ToString());
                if (updateStatus)
                {
                    MessageBox.Show("Registering Successfully", "Registering", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Registering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Registering Failed, Invalid user Id or password", "Registering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deRegisterbtn_Click(object sender, EventArgs e)
        {
            //validate department value
            if(registerDepartmentcomboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please enter your department before deregistering", "Select Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate userid value
            if (string.IsNullOrEmpty(userIdtextBox.Text))
            {
                MessageBox.Show("Please enter your user id before deregistering", "Enter User id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate password value
            if (string.IsNullOrEmpty(passwordtextBox.Text))
            {
                MessageBox.Show("Please enter your password before deregistering", "Enter Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //check user whether he exist in database 
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            LoginHandler loginHandler = new LoginHandler();
            UserHandler userHandler = new UserHandler();
            bool status = loginHandler.proceedLogin(dBConn.getConn(), registerDepartmentcomboBox.SelectedItem.ToString(), userIdtextBox.Text, passwordtextBox.Text);

            if (status)
            {
                //update deregistering status
                bool updateStatus = userHandler.updateWorkStatus(dBConn.getConn(), registerTypecomboBox.SelectedItem.ToString(), userIdtextBox.Text, registerDepartmentcomboBox.SelectedItem.ToString());
                if (updateStatus)
                {
                    MessageBox.Show("Deregistering Successfully", "Registering", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Deregistering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Deregistering Failed, Invalid user Id or password", "Deregistering", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
