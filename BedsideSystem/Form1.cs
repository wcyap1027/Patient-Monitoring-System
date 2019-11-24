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
        public BedsideLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DbConnector dbCon = new DbConnector();


            if (string.IsNullOrEmpty(patientIDTextBox.Text))
            {
                MessageBox.Show("Please enter a correct patient ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(patientIDTextBox.Text != null)
            {
                try
                {
                    dbCon.connect();
                    string query = "SELECT id FROM patient WHERE id=" + patientIDTextBox;
                }
                catch(Exception e)
                {

                }
            }
        }
    }
}
