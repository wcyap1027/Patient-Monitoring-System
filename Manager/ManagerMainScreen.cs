using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Manager
{   
    public partial class ManagerMainScreen : Form
    {
        public ManagerMainScreen()
        {
            InitializeComponent();
        }

        private void ManagerMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            patientNRICT.Text = "";
        }

        private void patientNRICT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void csvReportBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(patientNRICT.Text))
            {
                MessageBox.Show("Please enter patient's IC number");
                return;
            }

            DbConnector dbcon = new DbConnector();
            dbcon.connect();



           
            }

        }
    }
}
