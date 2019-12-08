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
using Patient_Monitoring_System.Class;

namespace Patient_Monitoring_System.Screen
{
    public partial class BedsideScreen : Form
    {
        private List<Bedside> listBedside = new List<Bedside>();
        private static int patientIdStatic;
        public BedsideScreen()
        {
            InitializeComponent();
            setCentralStationId();
        }

        public void setAssignPatientId()
        {
            assignPatientIdcomboBox.Visible = true;
            assignBedsideIdBtn.Visible = true;
            BedsideHandler bedsideHandler = new BedsideHandler();
            bedsideHandler.FetchBedsidePatientId(assignPatientIdcomboBox);
        }

        public void setBedsideIdCentral()
        {
            
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            CentralStationHandler centralStationHandler = new CentralStationHandler();
            listBedside = centralStationHandler.getAllBedsideMonitor(dBConn.getConn(), centralStationIdcomboBox.SelectedItem.ToString());
            centralbedsideIdcomboBox.Enabled = true;
            centralbedsideIdcomboBox.Items.Add("--Select Bedside ID--");
            centralbedsideIdcomboBox.SelectedIndex = 0;
            for(int i = 0; i < listBedside.Count; i++)
            {
                centralbedsideIdcomboBox.Items.Add(listBedside[i].Id);
            }
        }

        public void setCentralStationId()
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            CentralStationHandler centralStationHandler = new CentralStationHandler();
            List<CentralStation> listcentral = new List<CentralStation>();
            listcentral = centralStationHandler.getAllCentralStation(dBConn.getConn());
            centralStationIdcomboBox.Items.Add("--Select Central Station--");
            centralStationIdcomboBox.SelectedIndex = 0;
            for(int i = 0; i < listcentral.Count; i++)
            {
                centralStationIdcomboBox.Items.Add(listcentral[i].CentralStationName);
            }
        }

        private void centralStationIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(centralStationIdcomboBox.SelectedIndex > 0)
            {
                setBedsideIdCentral();
            }
        }

        private void centralbedsideIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(centralbedsideIdcomboBox.SelectedIndex > 0)
            {
                int index = centralbedsideIdcomboBox.SelectedIndex;
                if (listBedside[index].Status)
                {
                    DBConnector dBConn = new DBConnector();
                    dBConn.connect();
                    centralBedsideStatus.Text = "ONLINE";
                    centralBedsideStatus.ForeColor = Color.Green;
                    BedsideHandler bedsideHandler = new BedsideHandler();
                    bool status = bedsideHandler.checkExistBedside(dBConn.getConn(), listBedside[index].Id);

                    if (status)
                    {
                        assignPatientIdcomboBox.Visible = false;
                        assignBedsideIdBtn.Visible = false;
                        readingPanel.Show();
                        Patient patient = bedsideHandler.getSpecificPatientInBedside(dBConn.getConn(), listBedside[index].Id);
                        patientIdStatic = patient.Id;
                        centralPatientIdLabel.Text = patient.Id.ToString();
                        centralPatientIdLabel.ForeColor = Color.Black;
                        centralPatientNameLabel.Text = patient.FullName;
                        ReadingHandler readingHandler = new ReadingHandler();
                        bool statusReading = readingHandler.checkExistsReading(dBConn.getConn(), patient.Id);

                        if (statusReading)
                        {
                            Reading reading = readingHandler.getReading(dBConn.getConn(), patient.Id);
                            minBP.Text = reading.MinBloodPressure.ToString();
                            maxBP.Text = reading.MaxBloodPressure.ToString();
                            minBR.Text = reading.MinBreathing.ToString();
                            maxBR.Text = reading.MaxBreathing.ToString();
                            minPR.Text = reading.MinPulse.ToString();
                            maxPR.Text = reading.MaxPulse.ToString();
                            minTemp.Text = reading.MinTemperature.ToString();
                            maxTemp.Text = reading.MaxTemperature.ToString();
                            minBPtextBox.Text = reading.MinBloodPressure.ToString();
                            maxBPtextBox.Text = reading.MaxBloodPressure.ToString();
                            minBRtextBox.Text = reading.MinBreathing.ToString();
                            maxBRtextBox.Text = reading.MaxBreathing.ToString();
                            minPRtextBox.Text = reading.MinPulse.ToString();
                            maxPRtextBox.Text = reading.MaxPulse.ToString();
                            minTemptextBox.Text = reading.MinTemperature.ToString();
                            maxTemptextBox.Text = reading.MaxTemperature.ToString();
                        }
                    }
                  
                }
                else
                {
                    readingPanel.Hide();
                    centralBedsideStatus.Text = "OFFLINE";
                    centralBedsideStatus.ForeColor = Color.Red;
                    centralPatientIdLabel.Text = "No Assigned Patient ID";
                    centralPatientIdLabel.ForeColor = Color.Red;
                    centralPatientNameLabel.Text = "--";
                    minBP.Text = "--";
                    maxBP.Text = "--";
                    minBR.Text = "--";
                    maxBR.Text = "--";
                    minPR.Text = "--";
                    maxPR.Text = "--";
                    minTemp.Text = "--";
                    maxTemp.Text = "--";
                    minBPtextBox.Text = "";
                    maxBPtextBox.Text = "";
                    minBRtextBox.Text = "";
                    maxBRtextBox.Text = "";
                    minPRtextBox.Text = "";
                    maxPRtextBox.Text = "";
                    minTemptextBox.Text = "";
                    maxTemptextBox.Text = "";

                    
                }

                if (centralPatientIdLabel.Text == "No Assigned Patient ID")
                {
                    setAssignPatientId();
                }


            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Hide();
            cancelBtn.Show();
            updateBtn.Show();
            minBP.Hide();
            maxBP.Hide();
            minBR.Hide();
            maxBR.Hide();
            minPR.Hide();
            maxPR.Hide();
            minTemp.Hide();
            maxTemp.Hide();
            minBPtextBox.Show();
            maxBPtextBox.Show();
            minBRtextBox.Show();
            maxBRtextBox.Show();
            minPRtextBox.Show();
            maxPRtextBox.Show();
            minTemptextBox.Show();
            maxTemptextBox.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            editBtn.Show();
            updateBtn.Hide();
            cancelBtn.Hide();
            minBP.Show();
            maxBP.Show();
            minBR.Show();
            maxBR.Show();
            minPR.Show();
            maxPR.Show();
            minTemp.Show();
            maxTemp.Show();
            minBPtextBox.Hide();
            maxBPtextBox.Hide();
            minBRtextBox.Hide();
            maxBRtextBox.Hide();
            minPRtextBox.Hide();
            maxPRtextBox.Hide();
            minTemptextBox.Hide();
            maxTemptextBox.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            ReadingHandler readingHandler = new ReadingHandler();
            Reading reading = new Reading();
            reading.MinBloodPressure = double.Parse(minBPtextBox.Text);
            reading.MaxBloodPressure = double.Parse(maxBPtextBox.Text);
            reading.MinPulse = double.Parse(minPRtextBox.Text);
            reading.MaxPulse = double.Parse(maxPRtextBox.Text);
            reading.MinTemperature = double.Parse(minTemptextBox.Text);
            reading.MaxTemperature = double.Parse(maxTemptextBox.Text);
            reading.MinBreathing = double.Parse(minBRtextBox.Text);
            reading.MaxBreathing = double.Parse(maxBRtextBox.Text);
            int updateResult = readingHandler.updateReading(dBConn.getConn(), reading, patientIdStatic);

            if(updateResult == 1)
            {
                minBP.Text = minBPtextBox.Text;
                maxBP.Text = maxBPtextBox.Text;
                minBR.Text = minBRtextBox.Text;
                maxBR.Text = maxBRtextBox.Text;
                minPR.Text = minPRtextBox.Text;
                maxPR.Text = maxPRtextBox.Text;
                minTemp.Text = minTemptextBox.Text;
                maxTemp.Text = maxTemptextBox.Text;
                updateBtn.Hide();
                cancelBtn.Hide();
                minBP.Show();
                maxBP.Show();
                minBR.Show();
                maxBR.Show();
                minPR.Show();
                maxPR.Show();
                minTemp.Show();
                maxTemp.Show();
                minBPtextBox.Hide();
                maxBPtextBox.Hide();
                minBRtextBox.Hide();
                maxBRtextBox.Hide();
                minPRtextBox.Hide();
                maxPRtextBox.Hide();
                minTemptextBox.Hide();
                maxTemptextBox.Hide();
                MessageBox.Show("Update Successfully", "Update Reading", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Update Failed", "Update Reading", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
