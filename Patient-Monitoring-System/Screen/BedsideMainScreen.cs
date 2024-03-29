﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System;
using rtChart;
using Patient_Monitoring_System.Handler;
using Patient_Monitoring_System.Class;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;

namespace BedsideSystem
{
    public partial class BedsideMainScreen : Form
    {
        public static int smsTrigger = 1;
        public static bool run = true;
        public static bool beepStatus = false;
        public static bool alarmZeroStatus = false;
        public static bool alarmReadingStatus = false;
        public static int counterBP = 0;
        public static int counterPR = 0;
        public static int counterBR = 0;
        public static int counterTemp = 0;
        public static List<BloodPressure> listbloodPressure = new List<BloodPressure>();
        public static List<BreathingRate> listbreathingRate = new List<BreathingRate>();
        public static List<PulseRate> listPulseRate = new List<PulseRate>();
        public static List<Temperature> listTemperature = new List<Temperature>();
        public static List<double> listDouble = new List<double>();
        public static SoundPlayer beep = new SoundPlayer();
        public static SoundPlayer alarmZero = new SoundPlayer();
        public static SoundPlayer alarmReading = new SoundPlayer();
        public BedsideMainScreen()
        {
            InitializeComponent();
            getAllReading();
            backgroundWorkerBeep.WorkerSupportsCancellation = true;
            backgroundWorkerAlarmReading.WorkerSupportsCancellation = true;
            backgroundWorkerAlarmZero.WorkerSupportsCancellation = true;
            InitTrackReading();
        }

        private async void readTemperatureData()
        {
            kayChart dataChart = new kayChart(temperatureLineGraph, 60);
            dataChart.serieName = "Temperature";
            string path = "../../../Patient-Monitoring-System/data files/temperatureCSV.csv";
            string line;

            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while(line != null)
                {
                    string[] columns = line.Split(',');
                    foreach(string column in columns)
                    {
                        if (run)
                        {
                            double value = double.Parse(column);
                            //add each value to database *DONT Delete*
                            DateTime currentDate = DateTime.Now;
                            DateTime currentTime = DateTime.Now;
                            DBConnector dBConn = new DBConnector();
                            dBConn.connect();
                            Temperature newTemperature = new Temperature();
                            newTemperature.TemperatureValue = value;
                            newTemperature.TemperatureDate = currentDate;
                            newTemperature.TemperatureTime = currentTime;
                            TemperatureHandler temperatureHandler = new TemperatureHandler();
                            ReadingHandler readingHandler = new ReadingHandler();
                            int result = temperatureHandler.addNewTemperature(dBConn.getConn(), newTemperature, BedsideLoginScreen.bedside_patient_id);

                            if (result != 1)
                            {
                                MessageBox.Show("Insert Data failed");
                            }  
                           
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value == 0)
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                temperatureLineGraph.Series["Temperature"].Color = Color.Red;
                                temperatureCurrentValue.ForeColor = Color.Red;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmZeroStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);

                                alarmZeroStatus = true;
                                AlarmHandler alarmHandler = new AlarmHandler();
                                int specificId = alarmHandler.getSpecificId(dBConn.getConn(), value, "temperature");

                                if (specificId > 0)
                                {
                                    bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id,0, specificId, "Temperature");
                                    if (triggerStatus)
                                    {
                                        listTemperature.Add(newTemperature);
                                    }
                                }


                            }
                            else
                            if (value >= double.Parse(maxTemperatureLabel.Text) || value <= double.Parse(minTemperatureLabel.Text))
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                temperatureLineGraph.Series["Temperature"].Color = Color.Yellow;
                                temperatureCurrentValue.ForeColor = Color.Yellow;

                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);

                                alarmReadingStatus = true;
                                int id = readingHandler.getIdAlarmTrigger(dBConn.getConn(), value);

                                if (id > 0)
                                {
                                    AlarmHandler alarmHandler = new AlarmHandler();
                                    bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id,id, 0, "Temperature");
                                    if (triggerStatus)
                                    {
                                        listTemperature.Add(newTemperature);
                                    }
                                }

                            }
                            else
                            {
                                temperatureLineGraph.Series["Temperature"].Color = Color.Green;
                                temperatureCurrentValue.ForeColor = Color.Green;
                            }
                            temperatureCurrentValue.Text = value.ToString() + "°C";
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                        
                    line = sr.ReadLine();
                }
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private async void readBloodPressureData()
        {
            kayChart dataChart = new kayChart(bloodPressureLineGraph, 60);
            dataChart.serieName = "Blood Pressure";
            string path = "../../../Patient-Monitoring-System/data files/bloodPressureCSV.csv";
       
            string line;

            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] columns = line.Split(',');
                    foreach (string column in columns)
                    {
                        if (run)
                        {
                            ReadingHandler readingHandler = new ReadingHandler();
                            double value = double.Parse(column);
                            //add each value to database *DONT Delete*
                            DateTime currentDate = DateTime.Now;
                            DateTime currentTime = DateTime.Now;
                            DBConnector dBConn = new DBConnector();
                            dBConn.connect();
                            BloodPressure bloodPressureData = new BloodPressure();
                            bloodPressureData.BloodPressureValue = value;
                            bloodPressureData.BloodPressureDate = currentDate;
                            bloodPressureData.BloodPressureTime = currentTime;
                            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
                            int result = bloodPressureHandler.addNewBloodPressure(dBConn.getConn(), bloodPressureData, BedsideLoginScreen.bedside_patient_id);

                            if (result != 1)
                            {
                                MessageBox.Show("Insert Data failed");
                            }
                            

                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value == 0)
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Red;
                                bloodPressureCurrentValue.ForeColor = Color.Red;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmZeroStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);


                                alarmZeroStatus = true;
                                AlarmHandler alarmHandler = new AlarmHandler();
                                int specificId = alarmHandler.getSpecificId(dBConn.getConn(), value, "bloodpressure");

                                if (specificId > 0)
                                {
                                    bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id, 0, specificId, "Blood Pressure");
                                    if (triggerStatus)
                                    {
                                        listbloodPressure.Add(bloodPressureData);
                                    }
                                }
                            }
                            else
                            if (value >= double.Parse(maxBloodPressureLabel.Text) || value <= double.Parse(minBloodPressureLabel.Text))
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Yellow;
                                bloodPressureCurrentValue.ForeColor = Color.Yellow;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);


                                alarmReadingStatus = true;
                                int id = readingHandler.getIdAlarmTrigger(dBConn.getConn(), value);

                                if (id > 0)
                                {
                                    AlarmHandler alarmHandler = new AlarmHandler();
                                    bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id,id, 0, "Blood Pressure");

                                    if (triggerStatus)
                                    {
                                        listbloodPressure.Add(bloodPressureData);
                                    }
                                }
                            }
                            else
                            {
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Green;
                                bloodPressureCurrentValue.ForeColor = Color.Green;
                               
                            }

                            bloodPressureCurrentValue.Text = value.ToString() + "/80";
                        }
                        else
                        {
                            break;
                        }
                    }

                    line = sr.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private async void readPulseRateData()
        {
            kayChart dataChart = new kayChart(pulseRateLineGraph, 60);
            dataChart.serieName = "Pulse Rate";
            string path = "../../../Patient-Monitoring-System/data files/pulseRateCSV.csv";
            string line;

            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] columns = line.Split(',');
                    foreach (string column in columns)
                    {
                        if (run)
                        {
                            double value = double.Parse(column);
                            //add each value to database *DONT Delete*
                            DateTime currentDate = DateTime.Now;
                            DateTime currentTime = DateTime.Now;
                            DBConnector dBConn = new DBConnector();
                            dBConn.connect();
                            PulseRate pulseRateData = new PulseRate();
                            pulseRateData.PulseRateValue = value;
                            pulseRateData.PulseRateDate = currentDate;
                            pulseRateData.PulseRateTime = currentTime;
                            PulseRateHandler pulseRateHandler = new PulseRateHandler();
                            ReadingHandler readingHandler = new ReadingHandler();
                            int result = pulseRateHandler.addNewPulseRate(dBConn.getConn(), pulseRateData, BedsideLoginScreen.bedside_patient_id);

                            if (result != 1)
                            {
                                MessageBox.Show("Insert Data failed");   
                            }
                            
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value == 0)
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                pulseRateLineGraph.Series["Pulse Rate"].Color = Color.Red;
                                pulseRateCurrentValue.ForeColor = Color.Red;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmZeroStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);

                                alarmZeroStatus = true;
                                AlarmHandler alarmHandler = new AlarmHandler();
                                int specificId = alarmHandler.getSpecificId(dBConn.getConn(), value, "pulserate");

                                if (specificId > 0)
                                {
                                    bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value,BedsideLoginScreen.bedside_patient_id, 0, specificId, "Pulse Rate");
                                    if (triggerStatus)
                                    {
                                        listPulseRate.Add(pulseRateData);
                                    }
                                }
                            }
                            else
                            if (value >= double.Parse(maxPulseRateLabel.Text) || (value <= double.Parse(minPulseRateLabel.Text)))
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                pulseRateLineGraph.Series["Pulse Rate"].Color = Color.Yellow;
                                pulseRateCurrentValue.ForeColor = Color.Yellow;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);


                                alarmReadingStatus = true;
                                int id = readingHandler.getIdAlarmTrigger(dBConn.getConn(), value);

                                if (id > 0)
                                {
                                    AlarmHandler alarmHandler = new AlarmHandler();
                                    bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id,id, 0, "Pulse Rate");

                                    if (triggerStatus)
                                    {
                                        listPulseRate.Add(pulseRateData);
                                    }
                                }
                            }
                            else
                            {
                                pulseRateLineGraph.Series["Pulse Rate"].Color = Color.Green;
                                pulseRateCurrentValue.ForeColor = Color.Green;
                               
                            }
                            
                            pulseRateCurrentValue.Text = value.ToString() + "/min";
                            
                        }
                        else
                        {
                            break;
                        }



                    }

                    line = sr.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private async void readBreathingRateData()
        {
            kayChart dataChart = new kayChart(breathingRateLineGraph, 60);
            dataChart.serieName = "Breathing Rate";
            string path = "../../../Patient-Monitoring-System/data files/breathingRateCSV.csv";
            string line;

            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] columns = line.Split(',');
                    foreach (string column in columns)
                    {
                        if (run)
                        {

                            double value = double.Parse(column);
                            //add each value to database *DONT Delete*
                            DateTime currentDate = DateTime.Now;
                            DateTime currentTime = DateTime.Now;
                            DBConnector dBConn = new DBConnector();
                            dBConn.connect();
                            BreathingRate newBreathingRate = new BreathingRate();
                            newBreathingRate.BreathingRateValue = value;
                            newBreathingRate.BreathingRateDate = currentDate;
                            newBreathingRate.BreathingRateTime = currentTime;
                            BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
                            ReadingHandler readingHandler = new ReadingHandler();
                            int result = breathingRateHandler.addNewBreathingRate(dBConn.getConn(), newBreathingRate, BedsideLoginScreen.bedside_patient_id);

                            if (result != 1)
                            {
                                MessageBox.Show("Insert Data failed");
                            }
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                           

                            if (value == 0)
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }

                                breathingRateLineGraph.Series["Breathing Rate"].Color = Color.Red;
                                breathingRateCurrentValue.ForeColor = Color.Red;
                                
                                alarmZeroStatus = true;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmZeroStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);

                                if(alarmResult == 1)
                                {
                                    AlarmHandler alarmHandler = new AlarmHandler();
                                    int specificId = alarmHandler.getSpecificId(dBConn.getConn(), value, "breathingrate");

                                    if (specificId > 0)
                                    {
                                        bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id, 0, specificId, "Breathing Rate");
                                        if (triggerStatus)
                                        {
                                            listbreathingRate.Add(newBreathingRate);
                                        }
                                    }
                                }
                                


                               
                                


                            }
                            else
                            if (value >= double.Parse(maxBreathingRateLabel.Text) || value <= double.Parse(minBreathingRateLabel.Text))
                            {
                                if (smsTrigger == 1)
                                {
                                    if (!backgroundWorkerSendSMS.IsBusy)
                                    {
                                        backgroundWorkerSendSMS.RunWorkerAsync();
                                    }
                                }
                                breathingRateLineGraph.Series["Breathing Rate"].Color = Color.Yellow;
                                breathingRateCurrentValue.ForeColor = Color.Yellow;
                                
                                alarmReadingStatus = true;
                                BedsideHandler bedsideHandler = new BedsideHandler();
                                int alarmResult = bedsideHandler.updateAlarmStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 1);

                                if(alarmResult == 1)
                                {
                                    int id = readingHandler.getIdAlarmTrigger(dBConn.getConn(), value);

                                    if (id > 0)
                                    {
                                        AlarmHandler alarmHandler = new AlarmHandler();
                                        bool triggerStatus = alarmHandler.triggerAlarm(dBConn.getConn(), value, BedsideLoginScreen.bedside_patient_id, id, 0, "Breathing Rate");

                                        if (triggerStatus)
                                        {
                                            listbreathingRate.Add(newBreathingRate);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                breathingRateLineGraph.Series["Breathing Rate"].Color = Color.Green;
                                breathingRateCurrentValue.ForeColor = Color.Green;
                               
                            }
                            
                            breathingRateCurrentValue.Text = value.ToString() + "/min";
                            
                        }
                        else
                        {
                            break;
                        }
                    }

                    line = sr.ReadLine();
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if ((minBloodPressureLabel.Text == "--") && (maxBloodPressureLabel.Text == "--") && (minBreathingRateLabel.Text == "--") && (maxBreathingRateLabel.Text == "--") && (minPulseRateLabel.Text == "--") && (maxPulseRateLabel.Text == "--") && (minTemperatureLabel.Text == "--") && (maxTemperatureLabel.Text == "--"))
            {
                MessageBox.Show("Please go to Details to set up the minimum and maximum reading", "Start Bedside Monitor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            run = true;
            haltButton.Visible = true;
            startBtn.Visible = false;

            //renew the line graph
            bloodPressureLineGraph.Series.Clear();
            breathingRateLineGraph.Series.Clear();
            pulseRateLineGraph.Series.Clear();
            temperatureLineGraph.Series.Clear();
            var seriesBloodPressure = new Series
            {
                Name = "Blood Pressure",
                BorderWidth = 5,
                ChartType = SeriesChartType.Spline
            };
            var seriesPulseRate = new Series
            {
                Name = "Pulse Rate",
                BorderWidth = 5,
                ChartType = SeriesChartType.Spline
            };
            var seriesBreathingRate = new Series
            {
                Name = "Breathing Rate",
                BorderWidth = 5,
                ChartType = SeriesChartType.Spline
            };
            var seriesTemperature = new Series
            {
                Name = "Temperature",
                BorderWidth = 5,
                ChartType = SeriesChartType.Spline
            };

            bloodPressureLineGraph.Series.Add(seriesBloodPressure);
            breathingRateLineGraph.Series.Add(seriesBreathingRate);
            pulseRateLineGraph.Series.Add(seriesPulseRate);
            temperatureLineGraph.Series.Add(seriesTemperature);
            //--------------------------------------------------------//

            //start spline chart and read data
            readBloodPressureData();
            readPulseRateData();
            readTemperatureData();
            readBreathingRateData();
            beepStatus = true;
            backgroundWorkerBeep.RunWorkerAsync(1500);
            InitTrackAlarm();

        }

        public void getAllReading()
        {
            Reading patientReading = new Reading();
            ReadingHandler readingHandler = new ReadingHandler();
            DBConnector dbConn = new DBConnector();
            dbConn.connect();
            bool status = readingHandler.checkExistsReading(dbConn.getConn(), BedsideLoginScreen.bedside_patient_id);

            if (status)
            {
                patientReading = readingHandler.getReading(dbConn.getConn(), BedsideLoginScreen.bedside_patient_id);
                minBloodPressureLabel.Text = patientReading.MinBloodPressure.ToString();
                maxBloodPressureLabel.Text = patientReading.MaxBloodPressure.ToString();
                minBreathingRateLabel.Text = patientReading.MinBreathing.ToString();
                maxBreathingRateLabel.Text = patientReading.MaxBreathing.ToString();
                minPulseRateLabel.Text = patientReading.MinPulse.ToString();
                maxPulseRateLabel.Text = patientReading.MaxPulse.ToString();
                minTemperatureLabel.Text = patientReading.MinTemperature.ToString();
                maxTemperatureLabel.Text = patientReading.MaxTemperature.ToString();
            }
            else
            {
                minBloodPressureLabel.Text = "--";
                maxBloodPressureLabel.Text = "--";
                minBreathingRateLabel.Text = "--";
                maxBreathingRateLabel.Text = "--";
                minPulseRateLabel.Text = "--";
                maxPulseRateLabel.Text = "--";
                minTemperatureLabel.Text = "--";
                maxTemperatureLabel.Text = "--";
            }
        }

        private void BedsideMainScreen_Load(object sender, EventArgs e)
        {
            getAllReading();
            //backgroundWorkerBeep.WorkerSupportsCancellation = true;
            //backgroundWorkerAlarmReading.WorkerSupportsCancellation = true;
            //backgroundWorkerAlarmZero.WorkerSupportsCancellation = true;
        }

        private void backgroundWorkerBeep_DoWork(object sender, DoWorkEventArgs e)
        {
            
            beep.SoundLocation = "../../../Patient-Monitoring-System/Sound/beep.wav";
            while (beepStatus)
            {
                if (backgroundWorkerBeep.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(1500);
                    beep.PlaySync();
                }
                
            }
            
        }   

        private void haltButton_Click(object sender, EventArgs e)
        {
            smsTrigger = 1;
            startBtn.Visible = true;
            haltButton.Visible = false;
            run = false;
            beepStatus = false;     
        }
        

        private void backgroundWorkerAlarmZero_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmZero.SoundLocation = "../../../Patient-Monitoring-System/Sound/beep.wav";
            
            while (alarmZeroStatus)
            {
                if (backgroundWorkerAlarmZero.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Console.Beep(2000, 2000);
                }
            }
        }

        private void backgroundWorkerAlarmReading_DoWork(object sender, DoWorkEventArgs e)
        {
            alarmReading.SoundLocation = "../../../Patient-Monitoring-System/Sound/alarm.wav";
            while (alarmReadingStatus)
            {
                if (backgroundWorkerAlarmReading.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Console.Beep(1000,1000);  
                }
                
            }
        }

        private void muteAlarmBtn_Click(object sender, EventArgs e)
        {
            smsTrigger = 1;
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            AlarmHandler alarmHandler = new AlarmHandler();
            int id = alarmHandler.getLastId(dBConn.getConn(), BedsideLoginScreen.bedside_patient_id);
            int result = alarmHandler.updateDateTimeMuted(dBConn.getConn(), BedsideLoginScreen.bedside_patient_id, id);

            if(id > 0)
            {
                if (result == 1)
                {
                    BedsideHandler bedsideHandler = new BedsideHandler();
                    int alarmResult = bedsideHandler.updateAlarmStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 0);
                    if(alarmResult == 1)
                    {
                        int alarmResultZero = bedsideHandler.updateAlarmZeroStatus(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass, 0);

                        if(alarmResultZero == 1)
                        {
                            MessageBox.Show("Muted Alarm", "Muted Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            alarmReadingStatus = false;
                            alarmZeroStatus = false;

                            if (backgroundWorkerAlarmReading.IsBusy)
                            {
                                backgroundWorkerAlarmReading.CancelAsync();
                            }

                            if (backgroundWorkerAlarmZero.IsBusy)
                            {
                                backgroundWorkerAlarmZero.CancelAsync();
                            }

                            backgroundWorkerBeep.RunWorkerAsync();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Alarm cannot be muted", "Muted Alarm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
            
        }

        private void patientProfileBtn_Click(object sender, EventArgs e)
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            PatientProfileScreen profileScreen = new PatientProfileScreen();
            profileScreen.Show();
            
            PatientHandler patientHandler = new PatientHandler();
            Patient oldPatient = patientHandler.getSpecificPatient(dBConn.getConn(), BedsideLoginScreen.bedside_patient_id);
            profileScreen.BedsideId = BedsideLoginScreen.bedsideIDPass.ToString();
            profileScreen.PatientId = oldPatient.Id.ToString();
            profileScreen.PatientName = oldPatient.FullName;
            profileScreen.PatientNRIC = oldPatient.IdentityCard.ToString();
            profileScreen.Age = oldPatient.Age.ToString();
            profileScreen.AlarmDetails = "Blood Pressure Occurs: " + listbloodPressure.Count +
                Environment.NewLine + "Breathing Rate Occurs: " + listbreathingRate.Count +
                Environment.NewLine + "Pulse Rate Occurs: " + listPulseRate.Count +
                Environment.NewLine + "Temperature Occurs: " + listTemperature.Count;

        }

        

        private void setAlarmBtn_Click(object sender, EventArgs e)
        {
            ReadingScreen readingScreen = new ReadingScreen();
            readingScreen.Show();
        }

        private void InitTrackAlarm()
        {
            trackAlarmTimer = new System.Windows.Forms.Timer();
            trackAlarmTimer.Tick += new EventHandler(trackAlarmTimer_Tick);
            trackAlarmTimer.Interval = 1000;
            trackAlarmTimer.Start();
        }
        private void trackAlarmTimer_Tick(object sender, EventArgs e)
        {
            DBConnector dBc = new DBConnector();
            dBc.connect();
            BedsideHandler bedsideHandler = new BedsideHandler();
            int alarmStatus8 = bedsideHandler.SelectAlarmStatusBedside(dBc.getConn(), BedsideLoginScreen.bedsideIDPass);
            int alarmZeroStatus8 = bedsideHandler.SelectAlarmZeroStatusBedside(dBc.getConn(), BedsideLoginScreen.bedsideIDPass);

            if ((alarmStatus8 == 1) || (alarmZeroStatus8 == 1))
            {
                if (alarmZeroStatus8 == 1)
                {
                    if (!backgroundWorkerAlarmZero.IsBusy)
                    {
                        backgroundWorkerAlarmZero.RunWorkerAsync();
                        backgroundWorkerBeep.CancelAsync();
                        backgroundWorkerAlarmReading.CancelAsync();
                    }
                }
                else
                {
                    if (!backgroundWorkerAlarmReading.IsBusy)
                    {
                        backgroundWorkerAlarmReading.RunWorkerAsync();
                        backgroundWorkerBeep.CancelAsync();
                    }
                }
            }
            else
            {
                backgroundWorkerAlarmZero.CancelAsync();
                backgroundWorkerAlarmReading.CancelAsync();
            }
        }

        public void InitTrackReading()
        {
            trackReadingtimer = new System.Windows.Forms.Timer();
            trackReadingtimer.Tick += new EventHandler(trackReadingtimer_Tick);
            trackReadingtimer.Interval = 1000;
            trackReadingtimer.Start();
        }

        private void trackReadingtimer_Tick(object sender, EventArgs e)
        {
            Reading patientReading = new Reading();
            ReadingHandler readingHandler = new ReadingHandler();
            DBConnector dbConn = new DBConnector();
            dbConn.connect();
            bool status = readingHandler.checkExistsReading(dbConn.getConn(), BedsideLoginScreen.bedside_patient_id);

            if (status)
            {
                patientReading = readingHandler.getReading(dbConn.getConn(), BedsideLoginScreen.bedside_patient_id);
                minBloodPressureLabel.Text = patientReading.MinBloodPressure.ToString();
                maxBloodPressureLabel.Text = patientReading.MaxBloodPressure.ToString();
                minBreathingRateLabel.Text = patientReading.MinBreathing.ToString();
                maxBreathingRateLabel.Text = patientReading.MaxBreathing.ToString();
                minPulseRateLabel.Text = patientReading.MinPulse.ToString();
                maxPulseRateLabel.Text = patientReading.MaxPulse.ToString();
                minTemperatureLabel.Text = patientReading.MinTemperature.ToString();
                maxTemperatureLabel.Text = patientReading.MaxTemperature.ToString();
            }
            else
            {
                minBloodPressureLabel.Text = "--";
                maxBloodPressureLabel.Text = "--";
                minBreathingRateLabel.Text = "--";
                maxBreathingRateLabel.Text = "--";
                minPulseRateLabel.Text = "--";
                maxPulseRateLabel.Text = "--";
                minTemperatureLabel.Text = "--";
                maxTemperatureLabel.Text = "--";
            }
        }

        private void backgroundWorkerSendSMS_DoWork(object sender, DoWorkEventArgs e)
        {
            DBConnector dBConn = new DBConnector();
            dBConn.connect();
            smsTrigger = 2;
            SMSHandler sMSHandler = new SMSHandler();
            List<MedicalStaff> listMedicalStaff = sMSHandler.getMedicalStaff(dBConn.getConn(), BedsideLoginScreen.bedsideIDPass);
            for (int i = 0; i < listMedicalStaff.Count; i++)
            {
                if (listMedicalStaff[i].WorkStatus)
                {
                    DateTime currentDateTime = DateTime.Now;
                    SMS sms = new SMS();
                    sms.BedsideId = BedsideLoginScreen.bedsideIDPass;
                    sms.StaffId = listMedicalStaff[i].Id;
                    sms.Description = "Bedside " + BedsideLoginScreen.bedsideIDPass + " is trigger alarm";
                    sms.DateTimeSent = currentDateTime;
                    int r = sMSHandler.addSMS(dBConn.getConn(), sms);
                    if (r == 1)
                    {
                        MessageBox.Show("Sent");
                    }
                }
                else
                {
                    MessageBox.Show("Not Sent");
                }
                
            }
        }
    }
}
