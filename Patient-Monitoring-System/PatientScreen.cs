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
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            PatientHandler patientHandler = new PatientHandler();
            patientGridView.DataSource = patientHandler.getAllPatient(dBConn.getConn());
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
            deleteRecordPanel.Width = 879;
            deleteRecordPanel.Height = 365;
            deleteRecordPanel.Location = new Point(5, 195);
            DBConnector dBconn = new DBConnector();
            dBconn.connect();

            PatientHandler patientHandler = new PatientHandler();
            patientGridView.DataSource = patientHandler.getAllPatient(dBconn.getConn());

            viewControlPanel.Show();
            addRecordPanel.Hide();
            updateRecordPanel.Hide();
            deleteRecordPanel.Hide();

        }
        //-----------------------------------------------------------Add Record----------------------------------------------------------------------------//
        private void viewRecordBtn_Click(object sender, EventArgs e)
        {
            DBConnector dBconn = new DBConnector();
            dBconn.connect();

            PatientHandler patientHandler = new PatientHandler();
            patientGridView.DataSource = patientHandler.getAllPatient(dBconn.getConn());
            viewControlPanel.Show();
            addRecordPanel.Hide();
            updateRecordPanel.Hide();
            deleteRecordPanel.Hide();
        }
        //-----------------------------------------------------------Add Record----------------------------------------------------------------------------//
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
            deleteRecordPanel.Hide();
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
            newPatient.BedsideId = 0;

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
                patientIdTextBox.Text = patientHandler.getLastRecordID(dBconn.getConn());
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

        //-----------------------------------------------------------Update Record----------------------------------------------------------------------------//
        private void updateRecordBtn_Click(object sender, EventArgs e)
        {
            PatientHandler patientHandler = new PatientHandler();
            closeAllTextBox(fullNameUpdateTextBox, nricUpdateTextBox, emailUpdateTextBox, phoneUpdateTextBox, addressUpdateTextBox, ageUpdateTextBox, bedsideIdUpdateTextBox, choosePatientIDUpdateComboBox, genderUpdatecomboBox);
            patientHandler.FetchId(choosePatientIDUpdateComboBox);
            viewControlPanel.Hide();
            addRecordPanel.Hide();
            updateRecordPanel.Show();
            deleteRecordPanel.Hide();
            

        }

        //use in update record and delete record
        private void closeAllTextBox(TextBox fullName, TextBox nric, TextBox email, TextBox phone, RichTextBox address, TextBox age, TextBox bedsideId,ComboBox choosePatientComboBox, ComboBox genderComboBox)
        {
            fullName.Text = "";
            nric.Text = "";
            phone.Text = "";
            address.Text = "";
            age.Text = "";
            bedsideId.Text = "";
            email.Text = "";
            choosePatientComboBox.Items.Clear();
            genderComboBox.Items.Clear();
            fullName.Enabled = false;
            nric.Enabled = false;
            email.Enabled = false;
            genderComboBox.Enabled = false;
            phone.Enabled = false;
            address.Enabled = false;
            age.Enabled = false;
            bedsideId.Enabled = false;
        }

       
       

        private void choosePatientComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(choosePatientIDUpdateComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select valid ID");
                }
                else
                {
                    nricUpdateTextBox.Enabled = true;
                    fullNameUpdateTextBox.Enabled = true;
                    emailUpdateTextBox.Enabled = true;
                    genderUpdatecomboBox.Enabled = true;
                    phoneUpdateTextBox.Enabled = true;
                    addressUpdateTextBox.Enabled = true;
                    ageUpdateTextBox.Enabled = true;
                    bedsideIdUpdateTextBox.Enabled = true;
                    genderUpdatecomboBox.Items.Add("Male");
                    genderUpdatecomboBox.Items.Add("Female");
                    DBConnector dbC = new DBConnector();
                    dbC.connect();
                    PatientHandler patientHandler = new PatientHandler();
                    List<Patient> patientList = new List<Patient>();
                    patientList = patientHandler.getAllPatient(dbC.getConn());
                    for(int i = 0; i < patientList.Count; i++)
                    {
                        if(choosePatientIDUpdateComboBox.SelectedItem.ToString() == patientList[i].Id.ToString())
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
                            bedsideIdUpdateTextBox.Text = patientList[i].BedsideId.ToString();
                            
                        }
                    }
                }
            }
        }

        private void updatePatientButton_Click(object sender, EventArgs e)
        {
            DBConnector dbC = new DBConnector();
            dbC.connect();
            PatientHandler patientHandler = new PatientHandler();
            Patient oldPatientData = new Patient();
            if(choosePatientIDUpdateComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid ID");
                return;     
            }
            if (nricUpdateTextBox.Enabled == false)
            {
                MessageBox.Show("Please press 'Enter' to generate data first");
                return;
            }
            else
            {
                oldPatientData = patientHandler.getSpecificPatient(dbC.getConn(), choosePatientIDUpdateComboBox.SelectedItem.ToString());
            }

            if ((oldPatientData.Nric.ToString() != nricUpdateTextBox.Text) || (oldPatientData.FullName != fullNameUpdateTextBox.Text) || (oldPatientData.Email != emailUpdateTextBox.Text) || (oldPatientData.Gender != genderUpdatecomboBox.SelectedItem.ToString()) || (oldPatientData.Phone.ToString() != phoneUpdateTextBox.Text) || (oldPatientData.Address != addressUpdateTextBox.Text) || (oldPatientData.Age.ToString() != ageUpdateTextBox.Text) || (oldPatientData.BedsideId.ToString() != bedsideIdUpdateTextBox.Text))
            {
                Patient newPatientData = new Patient();
                newPatientData.Id = int.Parse(choosePatientIDUpdateComboBox.SelectedItem.ToString());
                newPatientData.Nric = long.Parse(nricUpdateTextBox.Text);
                newPatientData.FullName = fullNameUpdateTextBox.Text;
                newPatientData.Email = emailUpdateTextBox.Text;
                newPatientData.Gender = genderUpdatecomboBox.SelectedItem.ToString();
                newPatientData.Phone = int.Parse(phoneUpdateTextBox.Text);
                newPatientData.Address = addressUpdateTextBox.Text;
                newPatientData.Age = int.Parse(ageUpdateTextBox.Text);
                newPatientData.BedsideId = int.Parse(bedsideIdUpdateTextBox.Text);

                int updateResult = patientHandler.updatePatientData(dbC.getConn(), newPatientData);

                if (updateResult == 1)
                {
                    MessageBox.Show("Update Successfully");
                    closeAllTextBox(fullNameUpdateTextBox, nricUpdateTextBox, emailUpdateTextBox, phoneTextBox, addressUpdateTextBox, ageUpdateTextBox, bedsideIdUpdateTextBox, choosePatientIDUpdateComboBox, genderUpdatecomboBox);
                    patientHandler.FetchId(choosePatientIDUpdateComboBox);
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }

            }
            else
            {
                MessageBox.Show("Nothing is changes");

                
            }
            
        }
        //-----------------------------------------------------------Delete Record----------------------------------------------------------------------------//
        private void deleteRecordBtn_Click(object sender, EventArgs e)
        {
            PatientHandler patientHandler = new PatientHandler();
            viewControlPanel.Hide();
            addRecordPanel.Hide();
            updateRecordPanel.Hide();
            deleteRecordPanel.Show();
            closeAllTextBox(fullNameDeleteTextBox, nricDeleteTextBox, emailDeleteTextBox, phoneDeleteTextBox, addressDeleteRichTextBox, ageDeleteTextBox, bedsideIdDeleteTextBox, choosePatientIDDeleteComboBox, genderDeleteComboBox);
            patientHandler.FetchId(choosePatientIDDeleteComboBox);
        }

        private void choosePatientIDDeleteComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (choosePatientIDDeleteComboBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select valid ID");
                }
                else
                {
                    genderDeleteComboBox.Items.Add("Male");
                    genderDeleteComboBox.Items.Add("Female");
                    DBConnector dbC = new DBConnector();
                    dbC.connect();
                    PatientHandler patientHandler = new PatientHandler();
                    List<Patient> patientList = new List<Patient>();
                    patientList = patientHandler.getAllPatient(dbC.getConn());
                    for (int i = 0; i < patientList.Count; i++)
                    {
                        if (choosePatientIDDeleteComboBox.SelectedItem.ToString() == patientList[i].Id.ToString())
                        {
                            nricDeleteTextBox.Text = patientList[i].Nric.ToString();
                            fullNameDeleteTextBox.Text = patientList[i].FullName;
                            emailDeleteTextBox.Text = patientList[i].Email;

                            for (int n = 0; n < genderDeleteComboBox.Items.Count; n++)
                            {
                                if (patientList[i].Gender == genderDeleteComboBox.Items[n].ToString())
                                {
                                    genderDeleteComboBox.SelectedIndex = n;
                                }
                            }

                            phoneDeleteTextBox.Text = patientList[i].Phone.ToString();
                            addressDeleteRichTextBox.Text = patientList[i].Address;
                            ageDeleteTextBox.Text = patientList[i].Age.ToString();
                            bedsideIdDeleteTextBox.Text = patientList[i].BedsideId.ToString();

                        }
                    }
                }
            }
        }

        private void deletePatientRecordBtn_Click(object sender, EventArgs e)
        {

            DBConnector dbC = new DBConnector();
            dbC.connect();
            PatientHandler patientHandler = new PatientHandler();
            Patient oldPatientData = new Patient();
            if (choosePatientIDDeleteComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid ID");
                return;
            }
            if (string.IsNullOrEmpty(nricDeleteTextBox.Text))
            {
                MessageBox.Show("Please press 'Enter' to generate data first");
                return;
            }
            else
            {
                oldPatientData = patientHandler.getSpecificPatient(dbC.getConn(), choosePatientIDDeleteComboBox.SelectedItem.ToString());
            }

            int deleteResult = patientHandler.deletePatientData(dbC.getConn(), oldPatientData.Id);

            if(deleteResult ==1)
            {

                    MessageBox.Show("Delete Record Successfully");
                    closeAllTextBox(fullNameDeleteTextBox, nricDeleteTextBox, emailDeleteTextBox, phoneDeleteTextBox, addressDeleteRichTextBox, ageDeleteTextBox, bedsideIdDeleteTextBox, choosePatientIDDeleteComboBox, genderDeleteComboBox);
                    patientHandler.FetchId(choosePatientIDDeleteComboBox);

            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
