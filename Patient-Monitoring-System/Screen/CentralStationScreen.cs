using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Patient_Monitoring_System.Class;
using Patient_Monitoring_System.Handler;


namespace Patient_Monitoring_System
{
    public partial class central_station_screen : Form
    {
        private static bool alarmStatus1 = false;
        private static bool alarmStatus2 = false;
        private static bool alarmStatus3 = false;
        private static bool alarmStatus4 = false;
        private static bool alarmStatus5 = false;
        private static bool alarmStatus6 = false;
        private static bool alarmStatus7 = false;
        private static bool alarmStatus8 = false;
        private List<Label> listLabelBedsideNumber = new List<Label>();
        private List<Label> listLabelBedsideStatus = new List<Label>();
        
        private List<Bedside> listbedsides = new List<Bedside>();
       
        public central_station_screen()
        {
            InitializeComponent();
            backgroundAlarmWorker1.WorkerSupportsCancellation = true;
            backgroundAlarmWorker2.WorkerSupportsCancellation = true;
            backgroundAlarmWorker3.WorkerSupportsCancellation = true;
            backgroundAlarmWorker4.WorkerSupportsCancellation = true;
            backgroundAlarmWorker5.WorkerSupportsCancellation = true;
            backgroundAlarmWorker6.WorkerSupportsCancellation = true;
            backgroundAlarmWorker7.WorkerSupportsCancellation = true;
            backgroundAlarmWorker8.WorkerSupportsCancellation = true;
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
                InitDataTimerBedside1();
                InitTrackAlarmTimerBedside1();
                InitDataTimerBedside2();
                InitTrackAlarmTimerBedside2();
                InitDataTimerBedside3();
                InitTrackAlarmTimerBedside3();
                InitDataTimerBedside4();
                InitTrackAlarmTimerBedside4();
                InitDataTimerBedside5();
                InitTrackAlarmTimerBedside5();
                InitDataTimerBedside6();
                InitTrackAlarmTimerBedside6();
                InitDataTimerBedside7();
                InitTrackAlarmTimerBedside7();
                InitDataTimerBedside8();
                InitTrackAlarmTimerBedside8();
                

            }
        }


        //data timer 1 - 8 =====================================================================
        private void dataTimerBedside1_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[0].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[0].Text == "ONLINE")
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

                bloodPressureValue1.Text = lastBP.ToString();
                breathingRateValue1.Text = lastBR.ToString();
                pulseRateValue1.Text = lastPR.ToString();
                temperatureValue1.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue1.Text = "--";
                breathingRateValue1.Text = "--";
                pulseRateValue1.Text = "--";
                temperatureValue1.Text = "--";
            }
        }
        private void dataTimerBedside2_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[1].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[1].Text == "ONLINE")
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

                bloodPressureValue2.Text = lastBP.ToString();
                breathingRateValue2.Text = lastBR.ToString();
                pulseRateValue2.Text = lastPR.ToString();
                temperatureValue2.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue2.Text = "--";
                breathingRateValue2.Text = "--";
                pulseRateValue2.Text = "--";
                temperatureValue2.Text = "--";
            }
        }

        private void dataTimerBedside3_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[2].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[2].Text == "ONLINE")
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

                bloodPressureValue3.Text = lastBP.ToString();
                breathingRateValue3.Text = lastBR.ToString();
                pulseRateValue3.Text = lastPR.ToString();
                temperatureValue3.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue3.Text = "--";
                breathingRateValue3.Text = "--";
                pulseRateValue3.Text = "--";
                temperatureValue3.Text = "--";
            }
        }

        private void dataTimerBedside4_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[3].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[3].Text == "ONLINE")
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

                bloodPressureValue4.Text = lastBP.ToString();
                breathingRateValue4.Text = lastBR.ToString();
                pulseRateValue4.Text = lastPR.ToString();
                temperatureValue4.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue4.Text = "--";
                breathingRateValue4.Text = "--";
                pulseRateValue4.Text = "--";
                temperatureValue4.Text = "--";
            }
        }


        private void dataTimerBedside5_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[4].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[4].Text == "ONLINE")
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

                bloodPressureValue5.Text = lastBP.ToString();
                breathingRateValue5.Text = lastBR.ToString();
                pulseRateValue5.Text = lastPR.ToString();
                temperatureValue5.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue5.Text = "--";
                breathingRateValue5.Text = "--";
                pulseRateValue5.Text = "--";
                temperatureValue5.Text = "--";
            }
        }

        private void dataTimerBedside6_Tick(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[5].Id);
            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
            PulseRateHandler pulseRateHandler = new PulseRateHandler();
            TemperatureHandler temperatureHandler = new TemperatureHandler();
            if (listLabelBedsideStatus[5].Text == "ONLINE")
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

                bloodPressureValue6.Text = lastBP.ToString();
                breathingRateValue6.Text = lastBR.ToString();
                pulseRateValue6.Text = lastPR.ToString();
                temperatureValue6.Text = lastTemp.ToString();

            }
            else
            {
                bloodPressureValue6.Text = "--";
                breathingRateValue6.Text = "--";
                pulseRateValue6.Text = "--";
                temperatureValue6.Text = "--";
            }
        }

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


        //init data timer bedside 1 - 8 =========================================================
        public void InitDataTimerBedside1()
        {
            dataTimerBedside1 = new System.Windows.Forms.Timer();
            dataTimerBedside1.Tick += new EventHandler(dataTimerBedside1_Tick);
            dataTimerBedside1.Interval = 1000;
            dataTimerBedside1.Start();
        }

        public void InitDataTimerBedside2()
        {
            dataTimerBedside2 = new System.Windows.Forms.Timer();
            dataTimerBedside2.Tick += new EventHandler(dataTimerBedside2_Tick);
            dataTimerBedside2.Interval = 1000;
            dataTimerBedside2.Start();
        }

        public void InitDataTimerBedside3()
        {
            dataTimerBedside3 = new System.Windows.Forms.Timer();
            dataTimerBedside3.Tick += new EventHandler(dataTimerBedside3_Tick);
            dataTimerBedside3.Interval = 1000;
            dataTimerBedside3.Start();
        }

        public void InitDataTimerBedside4()
        {
            dataTimerBedside4 = new System.Windows.Forms.Timer();
            dataTimerBedside4.Tick += new EventHandler(dataTimerBedside4_Tick);
            dataTimerBedside4.Interval = 1000;
            dataTimerBedside4.Start();
        }

        public void InitDataTimerBedside5()
        {
            dataTimerBedside5 = new System.Windows.Forms.Timer();
            dataTimerBedside5.Tick += new EventHandler(dataTimerBedside5_Tick);
            dataTimerBedside5.Interval = 1000;
            dataTimerBedside5.Start();
        }
        public void InitDataTimerBedside6()
        {
            dataTimerBedside6 = new System.Windows.Forms.Timer();
            dataTimerBedside6.Tick += new EventHandler(dataTimerBedside6_Tick);
            dataTimerBedside6.Interval = 1000;
            dataTimerBedside6.Start();
        }

        public void InitDataTimerBedside7()
        {
            dataTimerBedside7 = new System.Windows.Forms.Timer();
            dataTimerBedside7.Tick += new EventHandler(dataTimerBedside7_Tick);
            dataTimerBedside7.Interval = 1000;
            dataTimerBedside7.Start();
        }

        public void InitDataTimerBedside8()
        {
            dataTimerBedside8 = new System.Windows.Forms.Timer();
            dataTimerBedside8.Tick += new EventHandler(dataTimerBedside8_Tick);
            dataTimerBedside8.Interval = 1000;
            dataTimerBedside8.Start();
        }



        //track alarm tick 1 - 8 ==================================================================
        private void trackAlarmTimer1_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[0].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[0].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus1 = true;
                    backgroundAlarmWorker1.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker1.CancelAsync();
            }
        }
        private void trackAlarmTimer2_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[1].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[1].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus2 = true;
                    backgroundAlarmWorker2.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker2.CancelAsync();
            }
        }

        private void trackAlarmTimer3_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[2].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[2].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus3 = true;
                    backgroundAlarmWorker3.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker5.CancelAsync();
            }
        }

        private void trackAlarmTimer4_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[3].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[3].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus5 = true;
                    backgroundAlarmWorker4.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker4.CancelAsync();
            }
        }

        private void trackAlarmTimer5_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[4].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[4].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus5 = true;
                    backgroundAlarmWorker5.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker5.CancelAsync();
            }
        }

        private void trackAlarmTimer6_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[5].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[5].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus6 = true;
                    backgroundAlarmWorker6.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker6.CancelAsync();
            }
        }

        private void trackAlarmTimer7_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[6].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[6].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy || !backgroundAlarmWorker2.IsBusy || !backgroundAlarmWorker3.IsBusy || !backgroundAlarmWorker4.IsBusy ||
                    !backgroundAlarmWorker5.IsBusy || !backgroundAlarmWorker6.IsBusy ||
                    !backgroundAlarmWorker7.IsBusy || !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus7 = true;
                    backgroundAlarmWorker7.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker7.CancelAsync();
            }
        }

        private void trackAlarmTimer8_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmDataStatus = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), listbedsides[7].Id);
            int alarmDataZeroStatus = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[7].Id);

            if ((alarmDataStatus == 1) || (alarmDataZeroStatus == 1))
            {
                if (!backgroundAlarmWorker1.IsBusy && !backgroundAlarmWorker2.IsBusy &&
                    !backgroundAlarmWorker3.IsBusy && !backgroundAlarmWorker4.IsBusy &&
                    !backgroundAlarmWorker5.IsBusy && !backgroundAlarmWorker6.IsBusy &&
                    !backgroundAlarmWorker7.IsBusy && !backgroundAlarmWorker8.IsBusy)
                {
                    alarmStatus8 = true;
                    backgroundAlarmWorker8.RunWorkerAsync();
                }

            }
            else
            {
                backgroundAlarmWorker8.CancelAsync();
            }
        }



        //init track alarm timer 1 - 8 =========================================================
        public void InitTrackAlarmTimerBedside1()
        {
            trackAlarmTimer1 = new System.Windows.Forms.Timer();
            trackAlarmTimer1.Tick += new EventHandler(trackAlarmTimer1_Tick);
            trackAlarmTimer1.Interval = 1000;
            trackAlarmTimer1.Start();
        }

        public void InitTrackAlarmTimerBedside2()
        {
            trackAlarmTimer2 = new System.Windows.Forms.Timer();
            trackAlarmTimer2.Tick += new EventHandler(trackAlarmTimer2_Tick);
            trackAlarmTimer2.Interval = 1000;
            trackAlarmTimer2.Start();
        }

        public void InitTrackAlarmTimerBedside3()
        {
            trackAlarmTimer3 = new System.Windows.Forms.Timer();
            trackAlarmTimer3.Tick += new EventHandler(trackAlarmTimer3_Tick);
            trackAlarmTimer3.Interval = 1000;
            trackAlarmTimer3.Start();
        }

        public void InitTrackAlarmTimerBedside4()
        {
            trackAlarmTimer4 = new System.Windows.Forms.Timer();
            trackAlarmTimer4.Tick += new EventHandler(trackAlarmTimer4_Tick);
            trackAlarmTimer4.Interval = 1000;
            trackAlarmTimer4.Start();
        }

        public void InitTrackAlarmTimerBedside5()
        {
            trackAlarmTimer5 = new System.Windows.Forms.Timer();
            trackAlarmTimer5.Tick += new EventHandler(trackAlarmTimer5_Tick);
            trackAlarmTimer5.Interval = 1000;
            trackAlarmTimer5.Start();
        }

        public void InitTrackAlarmTimerBedside6()
        {
            trackAlarmTimer6 = new System.Windows.Forms.Timer();
            trackAlarmTimer6.Tick += new EventHandler(trackAlarmTimer6_Tick);
            trackAlarmTimer6.Interval = 1000;
            trackAlarmTimer6.Start();
        }

        public void InitTrackAlarmTimerBedside7()
        {
            trackAlarmTimer7 = new System.Windows.Forms.Timer();
            trackAlarmTimer7.Tick += new EventHandler(trackAlarmTimer7_Tick);
            trackAlarmTimer7.Interval = 1000;
            trackAlarmTimer7.Start();
        }

        public void InitTrackAlarmTimerBedside8()
        {
            trackAlarmTimer8 = new System.Windows.Forms.Timer();
            trackAlarmTimer8.Tick += new EventHandler(trackAlarmTimer8_Tick);
            trackAlarmTimer8.Interval = 1000;
            trackAlarmTimer8.Start();
        }



        //button to mute alarm 1-8 ==============================================================
        private void alarmStatusBtn1_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[0].Id);
            int alarmZeroStatus1 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[0].Id);
            if (alarmZeroStatus1 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[0].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundAlarmWorker1.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn1.BackColor = Color.Green;
                    }

                }
            }
        }

        private void alarmStatusBtn2_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[1].Id);
            int alarmZeroStatus2 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[1].Id);
            if (alarmZeroStatus2 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[1].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundAlarmWorker2.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn2.BackColor = Color.Green;
                    }

                }
            }
        }

        private void alarmStatusBtn3_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[2].Id);
            int alarmZeroStatus3 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[2].Id);
            if (alarmZeroStatus3 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[2].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundAlarmWorker3.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn3.BackColor = Color.Green;
                    }

                }
            }
        }

        private void alarmStatusBtn4_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[3].Id);
            int alarmZeroStatus4 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[3].Id);
            if (alarmZeroStatus4 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[3].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundAlarmWorker4.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn3.BackColor = Color.Green;
                    }

                }
            }
        }

        private void alarmStatusBtn5_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[4].Id);
            int alarmZeroStatus5 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[4].Id);
            if (alarmZeroStatus5 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[4].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundAlarmWorker5.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn5.BackColor = Color.Green;
                    }

                }
            }
        }

        private void alarmStatusBtn6_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[5].Id);
            int alarmZeroStatus6 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[5].Id);
            if (alarmZeroStatus6 == 1)
            {
                MessageBox.Show("Cannot Mute Alarm, This bedside reading is trigger 0");
            }
            else
            {
                int updateResult = bedsideHandler.updateAlarmStatus(dBc.getConn(), listbedsides[5].Id, 0);

                if (updateResult == 1)
                {
                    AlarmHandler alarmHandler = new AlarmHandler();
                    int id = alarmHandler.getLastId(dBc.getConn(), patientId);
                    int result = alarmHandler.updateDateTimeMuted(dBc.getConn(), patientId, id);

                    if (result == 1)
                    {
                        backgroundAlarmWorker6.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn6.BackColor = Color.Green;
                    }

                }
            }
        }

        private void alarmStatusBtn7_Click(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmZeroStatus7 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), listbedsides[6].Id);
            CentralStationHandler csHandler = new CentralStationHandler();
            int patientId = csHandler.checkPatientAvailableInBedside(dBc.getConn(), listbedsides[7].Id);
            if (alarmZeroStatus7 == 1)
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
                        backgroundAlarmWorker7.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusBtn7.BackColor = Color.Green;
                    }
                }
            }
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
                        backgroundAlarmWorker8.CancelAsync();
                        MessageBox.Show("Muted Alarm");
                        alarmStatusbtn8.BackColor = Color.Green;
                    }
                    
                }
            }
        }
        
        
        
        //backgroundworker 1- 8 to beep alarm
        private void backgroundAlarmWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn1.BackColor = Color.Red;
            while (alarmStatus1)
            {
                if (backgroundAlarmWorker1.CancellationPending)
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

        private void backgroundAlarmWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn2.BackColor = Color.Red;
            while (alarmStatus2)
            {
                if (backgroundAlarmWorker2.CancellationPending)
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

        private void backgroundAlarmWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn3.BackColor = Color.Red;
            while (alarmStatus3)
            {
                if (backgroundAlarmWorker3.CancellationPending)
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

        private void backgroundAlarmWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn4.BackColor = Color.Red;
            while (alarmStatus4)
            {
                if (backgroundAlarmWorker4.CancellationPending)
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

        private void backgroundAlarmWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn5.BackColor = Color.Red;
            while (alarmStatus5)
            {
                if (backgroundAlarmWorker5.CancellationPending)
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

        private void backgroundAlarmWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn6.BackColor = Color.Red;
            while (alarmStatus6)
            {
                if (backgroundAlarmWorker7.CancellationPending)
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

        private void backgroundAlarmWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusBtn7.BackColor = Color.Red;
            while (alarmStatus7)
            {
                if (backgroundAlarmWorker7.CancellationPending)
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

        private void backgroundAlarmWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmStatusbtn8.BackColor = Color.Red;
            while (alarmStatus8)
            {
                if (backgroundAlarmWorker8.CancellationPending)
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
