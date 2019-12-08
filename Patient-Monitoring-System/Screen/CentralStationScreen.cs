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
        private static bool alarmStatus = false;
        private List<Label> listLabelBedsideNumber = new List<Label>();
        private List<Label> listLabelBedsideStatus = new List<Label>();
        
        private List<Bedside> listbedsides = new List<Bedside>();
       
        public central_station_screen()
        {
            InitializeComponent();
            backgroundWorkerAlarm.WorkerSupportsCancellation = true;
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

               
                CentralStationHandler csHandler = new CentralStationHandler();
                DBConnector dBc = new DBConnector();
                dBc.connect();
                
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
                InitTrackAlarmTimerBedside8();
                InitDataTimerBedside7();
                InitTrackAlarmTimerBedside7();

            }
        }












        //bedside 7
        private void dataTimerBedside7_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[6].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[6].Text == "ONLINE")
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

                bloodPressureValue7.Text = lastBP.ToString();
                breathingRateValue7.Text = lastBR.ToString();
                pulseRateValue7.Text = lastPR.ToString();
                temperatureValue7.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue7.Text = "--";
                breathingRateValue7.Text = "--";
                pulseRateValue7.Text = "--";
                temperatureValue7.Text = "--";
            }
        }

        public void InitDataTimerBedside7()
        {
            dataTimerBedside7 = new System.Windows.Forms.Timer();
            dataTimerBedside7.Tick += new EventHandler(dataTimerBedside7_Tick);
            dataTimerBedside7.Interval = 1000;
            dataTimerBedside7.Start();
        }

        private void trackAlarmTimer7_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmStatus7 = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[6].Id);
            int alarmZeroStatus7 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[6].Id);

            if ((alarmStatus7 == 1) || (alarmZeroStatus7 == 1))
            {
                if (!backgroundWorkerAlarm.IsBusy)
                {
                    alarmStatus = true;
                    backgroundWorkerAlarm.RunWorkerAsync();
                }

            }
            else
            {
                backgroundWorkerAlarm.CancelAsync();
            }
        }

        public void InitTrackAlarmTimerBedside7()
        {
            trackAlarmTimer7 = new System.Windows.Forms.Timer();
            trackAlarmTimer7.Tick += new EventHandler(trackAlarmTimer8_Tick);
            trackAlarmTimer7.Interval = 1000;
            trackAlarmTimer7.Start();
        }
        private void alarmStatusBtn7_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmZeroStatus8 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[6].Id);
            if (alarmZeroStatus8 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[7].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundWorkerAlarm.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusbtn8.BackColor = Color.Green;
                    }
                }
            }
        }


        //bedside 8
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
        public void InitDataTimerBedside8()
        {
            dataTimerBedside8 = new System.Windows.Forms.Timer();
            dataTimerBedside8.Tick += new EventHandler(dataTimerBedside8_Tick);
            dataTimerBedside8.Interval = 1000;
            dataTimerBedside8.Start();
        }

        private void trackAlarmTimer8_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmStatus8 = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[7].Id);
            int alarmZeroStatus8 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[7].Id);

            if ((alarmStatus8 == 1) || (alarmZeroStatus8 == 1))
            {
                if (!backgroundWorkerAlarm.IsBusy)
                {
                    alarmStatus = true;
                    backgroundWorkerAlarm.RunWorkerAsync();
                }

            }
            else
            {
                backgroundWorkerAlarm.CancelAsync();
            }
        }

        public void InitTrackAlarmTimerBedside8()
        {
            trackAlarmTimer8 = new System.Windows.Forms.Timer();
            trackAlarmTimer8.Tick += new EventHandler(trackAlarmTimer8_Tick);
            trackAlarmTimer8.Interval = 1000;
            trackAlarmTimer8.Start();
        }
        private void alarmStatusbtn8_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[7].Id);
            //int alarmStatus8 = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[7].Id);
            int alarmZeroStatus8 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[7].Id);
            if (alarmZeroStatus8 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[7].Id, 0);
               
                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if(result == 1)
                    {
                        backgroundWorkerAlarm.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusbtn8.BackColor = Color.Green;
                    }
                    
                }
            }
        }
        private void backgroundWorkerAlarm_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusbtn8.BackColor = Color.Red;
            while (alarmStatus)
            {
                if (backgroundWorkerAlarm.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Console.Beep();
                }

            }
        }

        
    }
}
