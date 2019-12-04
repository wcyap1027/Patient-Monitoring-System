using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(usernameT.Text))
            //{
            //    MessageBox.Show("Please enter username");
            //    return;
            //}

            //if (string.IsNullOrEmpty(passwordT.Text))
            //{
            //    MessageBox.Show("Please enter password");
            //    return;
            //}

            //if ((usernameT.Text == "monitor") && (passwordT.Text == "123456"))
            //{
            //    this.Hide();
            //    ManagerMainScreen mainScreen = new ManagerMainScreen();
            //    mainScreen.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password");
            //    usernameT.Text = "";
            //    passwordT.Text = "";
            //}
            ManagerMainScreen mainScreen = new ManagerMainScreen();
            mainScreen.Show();
            this.Close();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameT.Text = "";
            passwordT.Text = "";
        }
    }
}
