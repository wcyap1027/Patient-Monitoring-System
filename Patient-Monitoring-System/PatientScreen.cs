using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Monitoring_System
{
    public partial class PatientScreen : Form
    {
        public PatientScreen()
        {
            InitializeComponent();
            genderComboBox.SelectedIndex = 0;
            DBConnector dBconn = new DBConnector();
            dBconn.connect();


            PatientHandler patientHandler = new PatientHandler();
            patientGridView.DataSource = patientHandler.getAllPatient(dBconn.getConn());
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            //DBConnector dBconn = new DBConnector();
            //dBconn.connect();
            //PatientHandler patientHandler = new PatientHandler();
            //if(searchtextBox.Text != "")
            //{
            //    patientGridView.DataSource = patientHandler.searchPatientData(dBconn.getConn(), searchtextBox.Text);
            //}
           
            
        }


        private void PatientScreen_Load(object sender, EventArgs e)
        {
            viewControlPanel.Width = 879;
            viewControlPanel.Height = 365;
            viewControlPanel.Location = new Point(5, 195);
            addRecordPanel.Width = 879;
            addRecordPanel.Height = 365;
            addRecordPanel.Location = new Point(5, 195);
            updateRecordPanel.Width = 879;
            updateRecordPanel.Height = 365;
            updateRecordPanel.Location = new Point(5, 195);
            DBConnector dBconn = new DBConnector();
            dBconn.connect();

            PatientHandler patientHandler = new PatientHandler();
            patientGridView.DataSource = patientHandler.getAllPatient(dBconn.getConn());

            viewControlPanel.Show();
            addRecordPanel.Hide();
            updateRecordPanel.Hide();

        }

        private void viewRecordBtn_Click(object sender, EventArgs e)
        {
            DBConnector dBconn = new DBConnector();
            dBconn.connect();

            PatientHandler patientHandler = new PatientHandler();
            patientGridView.DataSource = patientHandler.getAllPatient(dBconn.getConn());
            viewControlPanel.Show();
            addRecordPanel.Hide();
            updateRecordPanel.Hide();
        }

        private void addRecordBtn_Click(object sender, EventArgs e)
        {
            DBConnector dBconn = new DBConnector();
            dBconn.connect();
            PatientHandler patientHandler = new PatientHandler();
            patientIdTextBox.Text = patientHandler.getLastRecordID(dBconn.getConn());
            genderComboBox.SelectedIndex = 0;
            
            viewControlPanel.Hide();
            addRecordPanel.Show();
            updateRecordPanel.Hide();
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullNameTextBox.Text))
            {
                MessageBox.Show("Please enter full name");
                return;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please enter email");
                return;
            }

            if (genderComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select gender");
                return;
            }

            if (string.IsNullOrEmpty(nricTextBox.Text))
            {
                MessageBox.Show("Please enter nric");
                return;
            }

            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Please enter address");
                return;
            }

            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Please enter phone");
                return;
            }

            if (string.IsNullOrEmpty(ageTextBox.Text))
            {
                MessageBox.Show("Please enter age");
                return;
            }

            Patient newPatient = new Patient();

            newPatient.FullName = fullNameTextBox.Text;
            newPatient.Nric = long.Parse(nricTextBox.Text);
            newPatient.Address = addressTextBox.Text;
            newPatient.Email = emailTextBox.Text;
            newPatient.Gender = genderComboBox.SelectedItem.ToString();
            newPatient.Phone = int.Parse(phoneTextBox.Text);
            newPatient.Age = int.Parse(ageTextBox.Text);

            DBConnector dBconn = new DBConnector();
            dBconn.connect();
            PatientHandler patientHandler = new PatientHandler();
            int addResult = patientHandler.addNewPatient(dBconn.getConn(), newPatient);
            
            if(addResult == 1)
            {
                MessageBox.Show("New Patient Record is inserted");
                fullNameTextBox.Text = "";
                nricTextBox.Text = "";
                addressTextBox.Text = "";
                emailTextBox.Text = "";
                genderComboBox.SelectedIndex = 0;
                phoneTextBox.Text = "";
                ageTextBox.Text = "";
            }
        }

        private void resetPatientBtn_Click(object sender, EventArgs e)
        {
            fullNameTextBox.Text = "";
            nricTextBox.Text = "";
            addressTextBox.Text = "";
            emailTextBox.Text = "";
            genderComboBox.SelectedIndex = 0;
            phoneTextBox.Text = "";
            ageTextBox.Text = "";
        }

        private void updateRecordBtn_Click(object sender, EventArgs e)
        {
            FetchId();
            viewControlPanel.Hide();
            addRecordPanel.Hide();
            updateRecordPanel.Show();
            phoneUpdateTextBox.Text = "";
            addressUpdateTextBox.Text = "";
            ageUpdateTextBox.Text = "";
            bedsideIdUpdateTextBox.Text = "";
            nricUpdateTextBox.Text = "";
            fullNameUpdateTextBox.Text = "";
            emailUpdateTextBox.Text = "";
            genderUpdatecomboBox.Items.Clear();

        }

        private void FetchId()
        {
            choosePatientComboBox.Items.Add("--Select ID--");

            choosePatientComboBox.SelectedIndex = 0;
            DBConnector dbC = new DBConnector();
            dbC.connect();
            PatientHandler patientHandler = new PatientHandler();
            List<Patient> patientList = new List<Patient>();
            patientList = patientHandler.getAllPatient(dbC.getConn());
            for (int i = 0; i < patientList.Count; i++)
            {
                choosePatientComboBox.Items.Add(patientList[i].Id);
            }
        }

        private void choosePatientComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(choosePatientComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select valid ID");
                }
                else
                {
                    genderUpdatecomboBox.Items.Add("Male");
                    genderUpdatecomboBox.Items.Add("Female");
                    DBConnector dbC = new DBConnector();
                    dbC.connect();
                    PatientHandler patientHandler = new PatientHandler();
                    List<Patient> patientList = new List<Patient>();
                    patientList = patientHandler.getAllPatient(dbC.getConn());
                    for(int i = 0; i < patientList.Count; i++)
                    {
                        if(choosePatientComboBox.SelectedItem.ToString() == patientList[i].Id.ToString())
                        {
                            nricUpdateTextBox.Text = patientList[i].Nric.ToString();
                            fullNameUpdateTextBox.Text = patientList[i].FullName;
                            emailUpdateTextBox.Text = patientList[i].Email;

                            for(int n = 0; n <genderUpdatecomboBox.Items.Count; n++)
                            {
                                if(patientList[i].Gender == genderUpdatecomboBox.Items[n].ToString())
                                {
                                    genderUpdatecomboBox.SelectedIndex = n;
                                }
                            }

                            phoneUpdateTextBox.Text = patientList[i].Phone.ToString();
                            addressUpdateTextBox.Text = patientList[i].Address;
                            ageUpdateTextBox.Text = patientList[i].Age.ToString();
                            bedsideIdUpdateTextBox.Text = patientList[i].BedsideId;
                            
                        }
                    }
                }
            }
        }
    }
}
