using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedsideSystem
{
    public partial class BedsideLogin : Form
    {
        string id;
        public BedsideLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DbConnector dbCon = new DbConnector();


            if (string.IsNullOrEmpty(patientIDTextBox.Text))
            {
                MessageBox.Show("Please enter a correct patient ID", "Invalid key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(patientIDTextBox.Text != "")
            {
                dbCon.connect();
                string query = "SELECT * FROM patient where id ='" + patientIDTextBox.Text+"'";
                MySqlDataReader row;
                MySqlCommand sqlComm = new MySqlCommand(query, dbCon.getConn());
                row = sqlComm.ExecuteReader();
                if(row.HasRows)
                {
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid patient ID. Please try again", "Patient Not In Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            patientIDTextBox.Text = "";
        }
    }
}
