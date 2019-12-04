using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System;
using rtChart;

namespace BedsideSystem
{
    public partial class BedsideMainScreen : Form
    {
        public static bool run = true;
        public static bool status = true;
        public static int counterBP = 0;
        public static int counterPR = 0;
        public static int counterBR = 0;
        public static int counterTemp = 0;
        public static List<BloodPressure> listbloodPressure = new List<BloodPressure>();
        public static List<double> listDouble = new List<double>();
        public static System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public BedsideMainScreen()
        {
            InitializeComponent();
        }

        private async void readTemperatureData()
        {
            kayChart dataCha = new kayChart(temperatureLineGraph, 60);
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
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value >= 36.5 && value <= 37.2)
                            {
                                temperatureLineGraph.Series["Temperature"].Color = Color.Green;
                                temperatureCurrentValue.ForeColor = Color.Green;
                                temperatureStatus.Text = "NORMAL";
                                temperatureStatus.ForeColor = Color.Green;
                            }
                            else if (value > 37.2)
                            {
                                temperatureLineGraph.Series["Temperature"].Color = Color.Red;
                                temperatureCurrentValue.ForeColor = Color.Red;
                                temperatureStatus.Text = "FEVER";
                                temperatureStatus.ForeColor = Color.Red;
                            }

                            temperatureCurrentValue.Text = value.ToString() + "°C";
                            //add each value to database *DONT Delete*
                            //DateTime currentDate = DateTime.Now;
                            //DateTime currentTime = DateTime.Now;
                            //DBConnector dBConn = new DBConnector();
                            //dBConn.connect();
                            //Temperature newTemperature = new Temperature();
                            //newTemperature.TemperatureValue = value;
                            //newTemperature.TemperatureDate = currentDate;
                            //newTemperature.TemperatureTime = currentTime;
                            //TemperatureHandler temperatureHandler = new TemperatureHandler();
                            //int result = temperatureHandler.addNewTemperature(dBConn.getConn(), newTemperature, BedsideLoginScreen.bedside_patient_id);

                            //if (result == 1)
                            //{
                            //    temperatureCurrentValue.Text = value.ToString() + "°C";
                            //}
                            //else
                            //{
                            //   MessageBox.Show("Insert Data failed");
                            //   break;
                            //}
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
                            double value = double.Parse(column);
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value <= 90)
                            {
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Blue;
                                bloodPressureCurrentValue.ForeColor = Color.Blue;
                                bloodPressureStatus.Text = "LOW";
                                bloodPressureStatus.ForeColor = Color.Blue;
                            }
                            else if (value > 90 && value <= 120)
                            {
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Green;
                                bloodPressureCurrentValue.ForeColor = Color.Green;
                                bloodPressureStatus.Text = "NORMAL";
                                bloodPressureStatus.ForeColor = Color.Green;
                            }
                            else if (value > 120 && value <= 140)
                            {
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Orange;
                                bloodPressureCurrentValue.ForeColor = Color.Orange;
                                bloodPressureStatus.Text = "PRE-HIGH";
                                bloodPressureStatus.ForeColor = Color.Orange;
                            }
                            else if (value > 140)
                            {
                                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Red;
                                bloodPressureCurrentValue.ForeColor = Color.Red;
                                bloodPressureStatus.Text = "HIGH";
                                bloodPressureStatus.ForeColor = Color.Red;
                            }

                            bloodPressureCurrentValue.Text = value.ToString() + "/80";
                            //add each value to database *DONT Delete*
                            //DateTime currentDate = DateTime.Now;
                            //DateTime currentTime = DateTime.Now;
                            //DBConnector dBConn = new DBConnector();
                            //dBConn.connect();
                            //BloodPressure bloodPressureData = new BloodPressure();
                            //bloodPressureData.BloodPressureValue = value;
                            //bloodPressureData.BloodPressureDate = currentDate;
                            //bloodPressureData.BloodPressureTime = currentTime;
                            //BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
                            //int result = bloodPressureHandler.addNewBloodPressure(dBConn.getConn(), bloodPressureData, BedsideLoginScreen.bedside_patient_id);

                            //if (result == 1)
                            //{
                            //    bloodPressureCurrentValue.Text = value.ToString() + "/80";
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Insert Data failed");
                            //    break;
                            //}
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
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value >= 60 && value <= 100)
                            {
                                pulseRateLineGraph.Series["Pulse Rate"].Color = Color.Green;
                                pulseRateCurrentValue.ForeColor = Color.Green;
                                pulseRateStatus.Text = "NORMAL";
                                pulseRateStatus.ForeColor = Color.Green;
                            }
                            else if (value < 60)
                            {
                                pulseRateLineGraph.Series["Pulse Rate"].Color = Color.Yellow;
                                pulseRateCurrentValue.ForeColor = Color.Yellow;
                                pulseRateStatus.Text = "SLOW";
                                pulseRateStatus.ForeColor = Color.Yellow;
                            }
                            else if (value > 100)
                            {
                                pulseRateLineGraph.Series["Pulse Rate"].Color = Color.Red;
                                pulseRateCurrentValue.ForeColor = Color.Red;
                                pulseRateStatus.Text = "FAST";
                                pulseRateStatus.ForeColor = Color.Red;
                            }


                            pulseRateCurrentValue.Text = value.ToString() + "/min";
                            //add each value to database *DONT Delete*
                            //DateTime currentDate = DateTime.Now;
                            //DateTime currentTime = DateTime.Now;
                            //DBConnector dBConn = new DBConnector();
                            //dBConn.connect();
                            //PulseRate pulseRateData = new PulseRate();
                            //pulseRateData.PulseRateValue = value;
                            //pulseRateData.PulseRateDate = currentDate;
                            //pulseRateData.PulseRateTime = currentTime;
                            //PulseRateHandler pulseRateHandler = new PulseRateHandler();
                            //int result = pulseRateHandler.addNewPulseRate(dBConn.getConn(), pulseRateData, BedsideLoginScreen.bedside_patient_id);

                            //if (result == 1)
                            //{
                            //    pulseRateCurrentValue.Text = value.ToString() + "/min";
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Insert Data failed");
                            //    break;
                            //}
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
                            await Task.Delay(1500);
                            await Task.Factory.StartNew(() =>
                            {
                                dataChart.TriggeredUpdate(value);
                            });

                            if (value >= 12 && value <= 20)
                            {
                                breathingRateLineGraph.Series["Breathing Rate"].Color = Color.Green;
                                breathingRateCurrentValue.ForeColor = Color.Green;
                                breathingRateStatus.Text = "NORMAL";
                                breathingRateStatus.ForeColor = Color.Green;
                            }
                            else if (value < 12 || value > 25)
                            {
                                breathingRateLineGraph.Series["Breathing Rate"].Color = Color.Red;
                                breathingRateCurrentValue.ForeColor = Color.Red;
                                breathingRateStatus.Text = "ABNORMAL";
                                breathingRateStatus.ForeColor = Color.Red;
                            }


                            breathingRateCurrentValue.Text = value.ToString() + "/min";
                            //add each value to database *DONT Delete*
                            //DateTime currentDate = DateTime.Now;
                            //DateTime currentTime = DateTime.Now;
                            //DBConnector dBConn = new DBConnector();
                            //dBConn.connect();
                            //BreathingRate newBreathingRate = new BreathingRate();
                            //newBreathingRate.BreathingRateValue = value;
                            //newBreathingRate.BreathingRateDate = currentDate;
                            //newBreathingRate.BreathingRateTime = currentTime;
                            //BreathingRateHandler breathingRateHandler = new BreathingRateHandler();
                            //int result = breathingRateHandler.addNewBreathingRate(dBConn.getConn(), newBreathingRate, BedsideLoginScreen.bedside_patient_id);

                            //if (result == 1)
                            //{
                            //    breathingRateCurrentValue.Text = value.ToString() + "/min";
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Insert Data failed");
                            //    break;
                            //}
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
            run = true;
            haltButton.Visible = true;
            startBtn.Visible = false;

            readBloodPressureData();
            readPulseRateData();
            readTemperatureData();
            readBreathingRateData();

            backgroundWorkerBeep.RunWorkerAsync(1000);

        }



        private void historyBtn_Click(object sender, EventArgs e)
        {
            HistoryScreen historyScreen = new HistoryScreen();
            historyScreen.Show();
            for(int i = 0; i < listbloodPressure.Count; i++)
            {
                string statement = "Date: " + listbloodPressure[i].BloodPressureDate.ToString("yyyy-MM-dd")
                    + Environment.NewLine + "Time: " + listbloodPressure[i].BloodPressureTime.ToString("HH:mm:ss") + Environment.NewLine + "Value: " + listbloodPressure[i].BloodPressureValue 
                    + Environment.NewLine;
                historyScreen.LabelText += statement;
            }
        }

        private void BedsideMainScreen_Load(object sender, EventArgs e)
        {

            testLabel.Text = BedsideLoginScreen.bedside_patient_id.ToString();
            //bloodPressureLineGraph.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            //bloodPressureLineGraph.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            //bloodPressureLineGraph.ChartAreas[0].AxisY.Maximum = 200;
            //bloodPressureLineGraph.ChartAreas[0].AxisY.Minimum = 0;
            //pulseRateLineGraph.ChartAreas[0].AxisY.Maximum = 200;
            //pulseRateLineGraph.ChartAreas[0].AxisY.Minimum = 0;
            //breathingRateLineGraph.ChartAreas[0].AxisY.Maximum = 200;
            //breathingRateLineGraph.ChartAreas[0].AxisY.Minimum = 0;
            //temperatureLineGraph.ChartAreas[0].AxisY.Maximum = 200;
            //temperatureLineGraph.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void setAlarmBtn_Click(object sender, EventArgs e)
        {
            AlarmScreen alarmScreen = new AlarmScreen();
            alarmScreen.Show();
        }

        private void backgroundWorkerBeep_DoWork(object sender, DoWorkEventArgs e)
        {
            //counterBP = readFileSize("../../data files/bloodPressureCSV.csv");
            //counterPR = readFileSize("../../data files/pulseRateCSV.csv");
            //counterBR = readFileSize("../../data files/breathingRateCSV.csv"); 
            //counterTemp = readFileSize("../../data files/temperatureCSV.csv");

            player.SoundLocation = "../../../Patient-Monitoring-System/Sound/Beep-SoundBible.com-923660219.wav";
            while (run)
            {
                Thread.Sleep(1500);
                player.PlaySync();
            }
            
        }   

           

        private void haltButton_Click(object sender, EventArgs e)
        {
            startBtn.Visible = true;
            haltButton.Visible = false;
            run = false;
        }
    }
}
