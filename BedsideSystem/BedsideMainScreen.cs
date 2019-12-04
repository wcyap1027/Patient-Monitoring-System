using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;
using rtChart;

namespace BedsideSystem
{
    public partial class BedsideMainScreen : Form
    {
        public static bool status = false;
        public static int counterBP = 0;
        public static int counterPR = 0;
        public static int counterBR = 0;
        public static int counterTemp = 0;
        public static List<BloodPressure> listbloodPressure = new List<BloodPressure>();
        public static List<double> listDouble = new List<double>();
        public BedsideMainScreen()
        {
            InitializeComponent();
        }

        private int readFileSize(string pathName)
        {
            List<string> listValue = new List<string>();
            string path = pathName;
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                foreach(string column in columns)
                {
                    listValue.Add(column);
                }
            }

            return listValue.Count;
        }

        private async void readTemperatureData()
        {
            kayChart dataChart = new kayChart(temperatureLineGraph, 60);
            dataChart.serieName = "Temperature";
            string path = "../../data files/temperatureCSV.csv";
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
                        
                         double value = double.Parse(column);
                                await Task.Delay(2000);
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

                                temperatureCurrentValue.Text = value.ToString()+ "°C";
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
            string path = "../../data files/bloodPressureCSV.csv";
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

                        double value = double.Parse(column);
                        await Task.Delay(2000);
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

                        bloodPressureCurrentValue.Text = value.ToString()+ "/80";
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
            string path = "../../data files/pulseRateCSV.csv";
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

                        double value = double.Parse(column);
                        await Task.Delay(2000);
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
            string path = "../../data files/breathingRateCSV.csv";
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

                        double value = double.Parse(column);
                        await Task.Delay(2000);
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

        private async void ReadAllData(string pathName, string seriesName, System.Windows.Forms.DataVisualization.Charting.Chart chart, Label showData, Label showStatus)
        {
            
            kayChart dataChart = new kayChart(chart, 60);
            
            dataChart.serieName = seriesName;
            string path = pathName;
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                
                foreach(string column in columns)
                {

                        await Task.Delay(2000);
                        await Task.Factory.StartNew(() =>
                        {
                            dataChart.TriggeredUpdate(double.Parse(column));

                        });
                        double value = double.Parse(column);
                        if (value <= 90)
                        {
                            chart.Series[seriesName].Color = Color.Blue;
                            showData.ForeColor = Color.Blue;
                            showStatus.Text = "LOW";
                            showStatus.ForeColor = Color.Blue;
                        }
                        else if (value > 90 && value <= 120)
                        {
                            chart.Series[seriesName].Color = Color.LightGreen;
                            showData.ForeColor = Color.LightGreen;
                            showStatus.Text = "OK";
                            showStatus.ForeColor = Color.LightGreen;
                        }
                        else if (value > 120 && value <= 140)
                        {
                            chart.Series[seriesName].Color = Color.Orange;
                            showData.ForeColor = Color.Orange;
                            showStatus.Text = "PRE-HIGH";
                            showStatus.ForeColor = Color.Orange;
                        }
                        else if (value > 140)
                        {
                            chart.Series[seriesName].Color = Color.Red;
                            showData.ForeColor = Color.Red;
                            bloodPressureStatus.Text = "HIGH";
                            showStatus.ForeColor = Color.Red;
                        }

                        showData.Text = column + "/80";
                        
                    
                }  
            }
        }

        //private async void readData()
        //{
        //    kayChart bloodPressureData = new kayChart(bloodPressureLineGraph, 60);
        //    bloodPressureData.serieName = "Blood Pressure";
        //    string path = "../../data files/bloodPressureCSV.csv";
        //    string[] lines = System.IO.File.ReadAllLines(path);
        //    foreach (string line in lines)
        //    {
        //        string[] columns = line.Split(',');
        //        foreach (string column in columns)
        //        {
        //            await Task.Delay(1000);
        //            DateTime currentDate = DateTime.Now;
        //            DateTime currentTime = DateTime.Now;
        //            DBConnector dBConn = new DBConnector();
        //            dBConn.connect();
        //            BloodPressure bloodPressureData = new BloodPressure();
        //            bloodPressureData.BloodPressureValue = double.Parse(column);
        //            bloodPressureData.BloodPressureDate = currentDate;
        //            bloodPressureData.BloodPressureTime = currentTime;
        //            BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
        //            int result = bloodPressureHandler.addNewBloodPressure(dBConn.getConn(), bloodPressureData, BedsideLoginScreen.bedside_patient_id);

        //            if (result == 1)
        //            {
        //                bloodPressureCurrentValue.Text = bloodPressureData.BloodPressureValue.ToString("0.00");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Insert Data failed");
        //                break;
        //            }
        //            listbloodPressure.Add(bloodPressure);
        //            listDouble.Add(double.Parse(column));
        //            await Task.Factory.StartNew(() =>
        //             {
        //                 bloodPressureData.TriggeredUpdate(double.Parse(column));

        //             });
        //            double value = double.Parse(column);
        //            if (value <= 90)
        //            {
        //                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Blue;
        //                bloodPressureCurrentValue.ForeColor = Color.Blue;
        //                bloodPressureStatus.Text = "LOW";
        //                bloodPressureStatus.ForeColor = Color.Blue;

        //            }
        //            else if (value > 90 && value <= 120)
        //            {
        //                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.LightGreen;
        //                bloodPressureCurrentValue.ForeColor = Color.LightGreen;
        //                bloodPressureStatus.Text = "OK";
        //                bloodPressureStatus.ForeColor = Color.LightGreen;

        //            }
        //            else if (value > 120 && value <= 140)
        //            {
        //                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Orange;
        //                bloodPressureCurrentValue.ForeColor = Color.Orange;
        //                bloodPressureStatus.Text = "PRE-HIGH";
        //                bloodPressureStatus.ForeColor = Color.Orange;
        //            }
        //            else if (value > 140)
        //            {
        //                bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Red;
        //                bloodPressureCurrentValue.ForeColor = Color.Red;
        //                bloodPressureStatus.Text = "HIGH";
        //                bloodPressureStatus.ForeColor = Color.Red;

        //            }

        //            bloodPressureCurrentValue.Text = column;

        //        }
        //    }
        //}

        //private async void readDataWithBeep()
        //{
        //    kayChart bloodPressureChart = new kayChart(bloodPressureLineGraph, 100);
        //    kayChart pulseRateChart = new kayChart(pulseRateLineGraph, 100);
        //    kayChart breathingRateChart = new kayChart(breathingRateLineGraph, 100);
        //    kayChart temperatureChart = new kayChart(temperatureLineGraph, 100);

        //    bloodPressureChart.serieName = "Blood Pressure";
        //    pulseRateChart.serieName = "Pulse Rate";
        //    breathingRateChart.serieName = "Breathing Rate";
        //    temperatureChart.serieName = "Temperature";
        //    string pathBloodPressure = "../../data files/bloodPressureCSV.csv";
        //    string pathPulseRate = "../../data files/bloodPressureCSV.csv";
        //    string pathBreathingRate = "../../data files/bloodPressureCSV.csv";
        //    string pathTemperature = "../../data files/bloodPressureCSV.csv";
        //    string[] bloodPressurelines = System.IO.File.ReadAllLines(pathBloodPressure);
        //    string[] pulseRatelines = System.IO.File.ReadAllLines(pathPulseRate);
        //    string[] breathingRatelines = System.IO.File.ReadAllLines(pathBreathingRate);
        //    string[] temperaturelines = System.IO.File.ReadAllLines(pathTemperature);

        //    if (bloodPressurelines.Length > 0 || pulseRatelines.Length > 0 || breathingRatelines.Length > 0 || temperaturelines.Length > 0)
        //    {
        //        foreach(string line in bloodPressurelines)
        //        {
        //            string[] columnBP = line.Split(',');
        //            foreach(string column in columnBP)
        //            {

        //            }
        //            await Task.Factory.StartNew(() =>
        //            {
        //                bloodPressureChart.TriggeredUpdate(double.Parse());

        //            });

        //            await Task.Delay(1000);

        //            double value = double.Parse(column);
        //            if (value <= 90)
        //            {
        //                bloodPressureChart.
        //                showData.ForeColor = Color.Blue;
        //                showStatus.Text = "LOW";
        //                showStatus.ForeColor = Color.Blue;
        //            }
        //            else if (value > 90 && value <= 120)
        //            {
        //                chart.Series[seriesName].Color = Color.LightGreen;
        //                showData.ForeColor = Color.LightGreen;
        //                showStatus.Text = "OK";
        //                showStatus.ForeColor = Color.LightGreen;
        //            }
        //            else if (value > 120 && value <= 140)
        //            {
        //                chart.Series[seriesName].Color = Color.Orange;
        //                showData.ForeColor = Color.Orange;
        //                showStatus.Text = "PRE-HIGH";
        //                showStatus.ForeColor = Color.Orange;
        //            }
        //            else if (value > 140)
        //            {
        //                chart.Series[seriesName].Color = Color.Red;
        //                showData.ForeColor = Color.Red;
        //                bloodPressureStatus.Text = "HIGH";
        //                showStatus.ForeColor = Color.Red;
        //            }

        //            showData.Text = column + "/80";
        //        }
        //    }
        //    foreach (string line in lines)
        //    {
        //        string[] columns = line.Split(',');
        //        foreach (string column in columns)
        //        {
        //            await Task.Delay(1000);

        //            double value = double.Parse(column);
        //            if (value <= 90)
        //            {
        //                chart.Series[seriesName].Color = Color.Blue;
        //                showData.ForeColor = Color.Blue;
        //                showStatus.Text = "LOW";
        //                showStatus.ForeColor = Color.Blue;
        //            }
        //            else if (value > 90 && value <= 120)
        //            {
        //                chart.Series[seriesName].Color = Color.LightGreen;
        //                showData.ForeColor = Color.LightGreen;
        //                showStatus.Text = "OK";
        //                showStatus.ForeColor = Color.LightGreen;
        //            }
        //            else if (value > 120 && value <= 140)
        //            {
        //                chart.Series[seriesName].Color = Color.Orange;
        //                showData.ForeColor = Color.Orange;
        //                showStatus.Text = "PRE-HIGH";
        //                showStatus.ForeColor = Color.Orange;
        //            }
        //            else if (value > 140)
        //            {
        //                chart.Series[seriesName].Color = Color.Red;
        //                showData.ForeColor = Color.Red;
        //                bloodPressureStatus.Text = "HIGH";
        //                showStatus.ForeColor = Color.Red;
        //            }

        //            showData.Text = column + "/80";



        //        }

        private async void startBeep()
        {
            while (status)
            {
                Console.Beep();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //readData();

            //ReadAllData("../../data files/bloodPressureCSV.csv", "Blood Pressure", bloodPressureLineGraph, bloodPressureCurrentValue, bloodPressureStatus);
            //ReadAllData("../../data files/bloodPressureCSV.csv", "Pulse Rate", pulseRateLineGraph, pulseRateCurrentValue, pulseRateStatus);
            //ReadAllData("../../data files/bloodPressureCSV.csv", "Breathing Rate", breathingRateLineGraph, breathingRateCurrentValue, breathingRateStatus);
            //ReadAllData("../../data files/bloodPressureCSV.csv", "Temperature", temperatureLineGraph, temperatureCurrentValue, temperatureStatus);
            
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
            counterBP = readFileSize("../../data files/bloodPressureCSV.csv");
            counterPR = readFileSize("../../data files/bloodPressureCSV.csv");
            counterBR = readFileSize("../../data files/bloodPressureCSV.csv"); 
            counterTemp = readFileSize("../../data files/bloodPressureCSV.csv");
            if (counterBP >= counterPR)
            {
                if(counterBP >= counterBR){
                    if(counterBP >= counterTemp)
                    {
                        for (int i = 0; i < counterBP; i++)
                        {
                            Thread.Sleep(2000);
                            Console.Beep();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < counterTemp; i++)
                        {
                            Thread.Sleep(2000);
                            Console.Beep();
                        }
                    }
                }
            }
            
            
        }
    }
}
