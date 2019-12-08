using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System.Class;
using Patient_Monitoring_System.Handler;


namespace Patient_Monitoring_System
{
    public partial class central_station_screen : Form
    {
        private static int counter = 0;
        private List<Label> listLabelBedsideNumber = new List<Label>();
        private List<Label> listLabelBedsideStatus = new List<Label>();
        private List<Label> listLabelBPValue = new List<Label>();
        private List<Bedside> listbedsides = new List<Bedside>();
        private List<BloodPressure> listBP = new List<BloodPressure>();
        public central_station_screen()
        {
            InitializeComponent();   
        }

        

        private void central_station_screen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
                
                centralStationNameComboBox.Visible = true;
                bayName.Visible = false;
            }
            else
            {
                if(e.KeyCode == Keys.F)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    TopMost = true;
                    centralStationNameComboBox.Visible = false;
                    bayName.Visible = true;
                }
            }
        }


        private void central_station_screen_Load(object sender, EventArgs e)
        {
            CentralStationHandler centralStationHand = new CentralStationHandler();
            centralStationHand.FetchCentralStationName(centralStationNameComboBox);
            bayName.Visible = false;
        }

        private void centralStationNameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(centralStationNameComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select valid Central Station Name");
                return;
            }

            if(centralStationNameComboBox.SelectedIndex > 0)
            {
                
                //add bedsideNumber to list
                listLabelBedsideNumber.Add(bedsideNumber1);
                listLabelBedsideNumber.Add(bedsideNumber2);
                listLabelBedsideNumber.Add(bedsideNumber3);
                listLabelBedsideNumber.Add(bedsideNumber4);
                listLabelBedsideNumber.Add(bedsideNumber5);
                listLabelBedsideNumber.Add(bedsideNumber6);
                listLabelBedsideNumber.Add(bedsideNumber7);
                listLabelBedsideNumber.Add(bedsideNumber8);

                //add bedsidestatus to list
                listLabelBedsideStatus.Add(bedsideStatus1);
                listLabelBedsideStatus.Add(bedsideStatus2);
                listLabelBedsideStatus.Add(bedsideStatus3);
                listLabelBedsideStatus.Add(bedsideStatus4);
                listLabelBedsideStatus.Add(bedsideStatus5);
                listLabelBedsideStatus.Add(bedsideStatus6);
                listLabelBedsideStatus.Add(bedsideStatus7);
                listLabelBedsideStatus.Add(bedsideStatus8);

                //add bloodPressure value to list
                listLabelBPValue.Add(bloodPressureValue1);
                listLabelBPValue.Add(bloodPressureValue2);
                listLabelBPValue.Add(bloodPressureValue3);
                listLabelBPValue.Add(bloodPressureValue4);
                listLabelBPValue.Add(bloodPressureValue5);
                listLabelBPValue.Add(bloodPressureValue6);
                listLabelBPValue.Add(bloodPressureValue7);
                listLabelBPValue.Add(bloodPressureValue8);

                
                CentralStationHandler csHandler = new CentralStationHandler();
                DBConnector dBc = new DBConnector();
                dBc.connect();
                //bayName.Text = centralStationNameComboBox.SelectedItem.ToString();
                listbedsides = csHandler.getAllBedsideMonitor(dBc.getConn(), centralStationNameComboBox.SelectedItem.ToString());

                for (int i = 0; i < listbedsides.Count; i++)
                {
                    listLabelBedsideNumber[i].Text = listbedsides[i].Id.ToString();
                    if (listbedsides[i].Status == true)
                    {
                        listLabelBedsideStatus[i].Text = "ONLINE";
                        listLabelBedsideStatus[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        listLabelBedsideStatus[i].Text = "OFFLINE";
                        listLabelBedsideStatus[i].ForeColor = Color.Red;
                    }

                }
                InitDataTimerBedside8();


            }
        }

        public void InitDataTimerBedside8()
        {
            dataTimerBedside8 = new System.Windows.Forms.Timer();
            dataTimerBedside8.Tick += new EventHandler(dataTimerBedside8_Tick);
            dataTimerBedside8.Interval = 1000;
            dataTimerBedside8.Start();
        }

       
        private void dataTimerBedside8_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[7].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[7].Text == "ONLINE")
            {
                //get last blood pressure
                int lastIdBP = bloodPressureHandler.getLastIdBloodPressure(dBc.getConn(), patientId);
                double lastBP = bloodPressureHandler.getLastBloodPressure(dBc.getConn(), patientId, lastIdBP);

                //get last breathing rate
                int lastIdBR = breathingRateHandler.getLastIdBreathingRate(dBc.getConn(), patientId);
                double lastBR = breathingRateHandler.getLastBreathingRate(dBc.getConn(), patientId, lastIdBR);

                //get last pulserate
                int lastIdPR = pulseRateHandler.getLastIdPulseRate(dBc.getConn(), patientId);
                double lastPR = pulseRateHandler.getLastPulseRate(dBc.getConn(), patientId, lastIdPR);

                //get last temperature
                int lastIdTemp = temperatureHandler.getLastIdTemperature(dBc.getConn(), patientId);
                double lastTemp = temperatureHandler.getLastTemperature(dBc.getConn(), patientId, lastIdTemp);

                bloodPressureValue8.Text = lastBP.ToString();
                breathingRateValue8.Text = lastBR.ToString();
                pulseRateValue8.Text = lastPR.ToString();
                temperatureValue8.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue8.Text = "--";
                breathingRateValue8.Text = "--";
                pulseRateValue8.Text = "--";
                temperatureValue8.Text = "--";
            }
        }
    }
}
