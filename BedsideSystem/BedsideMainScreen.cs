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
using Patient_Monitoring_System;
using Patient_Monitoring_System.Handler;
using rtChart;

namespace BedsideSystem
{
    public partial class BedsideMainScreen : Form
    {
        public static List<BloodPressure> listbloodPressure = new List<BloodPressure>();
        public static List<double> listDouble = new List<double>();
        public BedsideMainScreen()
        {
            InitializeComponent();
        }


        private async void readAllData(string pathName, string seriesName, System.Windows.Forms.DataVisualization.Charting.Chart chart, Label showData, Label showStatus)
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
                    await Task.Delay(1000);
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

        private async void readData()
        {
            kayChart bloodPressureData = new kayChart(bloodPressureLineGraph, 60);
            bloodPressureData.serieName = "Blood Pressure";
            string path = "../../data files/bloodPressureCSV.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                foreach(string column in columns)
                {
                    await Task.Delay(1000);
                    //DateTime currentDate = DateTime.Now;
                    //DateTime currentTime = DateTime.Now;
                    //DBConnector dBConn = new DBConnector();
                    //dBConn.connect();
                    //BloodPressure bloodPressureData = new BloodPressure();
                    //bloodPressureData.BloodPressureValue = double.Parse(column);
                    //bloodPressureData.BloodPressureDate = currentDate;
                    //bloodPressureData.BloodPressureTime = currentTime;
                    //BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
                    //int result = bloodPressureHandler.addNewBloodPressure(dBConn.getConn(), bloodPressureData, BedsideLoginScreen.bedside_patient_id);

                    //if(result == 1)
                    //{
                    //    bloodPressureCurrentValue.Text = bloodPressureData.BloodPressureValue.ToString("0.00");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Insert Data failed");
                    //    break;  
                    //}
                    //listbloodPressure.Add(bloodPressure);
                    //listDouble.Add(double.Parse(column));
                    await Task.Factory.StartNew(() =>
                     {
                         bloodPressureData.TriggeredUpdate(double.Parse(column));
                     });
                    double value = double.Parse(column);
                    if(value <= 90)
                    {
                        bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Blue;
                        bloodPressureCurrentValue.ForeColor = Color.Blue;
                        bloodPressureStatus.Text = "LOW";
                        bloodPressureStatus.ForeColor = Color.Blue;
                    }
                    else if(value > 90 && value <= 120)
                    {
                        bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.LightGreen;
                        bloodPressureCurrentValue.ForeColor = Color.LightGreen;
                        bloodPressureStatus.Text = "OK";
                        bloodPressureStatus.ForeColor = Color.LightGreen;
                    }
                    else if(value > 120 && value <= 140)
                    {
                        bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Orange;
                        bloodPressureCurrentValue.ForeColor = Color.Orange;
                        bloodPressureStatus.Text = "PRE-HIGH";
                        bloodPressureStatus.ForeColor = Color.Orange;
                    }
                    else if(value > 140)
                    {
                        bloodPressureLineGraph.Series["Blood Pressure"].Color = Color.Red;
                        bloodPressureCurrentValue.ForeColor = Color.Red;
                        bloodPressureStatus.Text = "HIGH";
                        bloodPressureStatus.ForeColor = Color.Red;
                    }
                    
                    bloodPressureCurrentValue.Text = column;

                }
            }
        }


        private void startBtn_Click(object sender, EventArgs e)
        {
            //readData();
            readAllData("../../data files/bloodPressureCSV.csv", "Blood Pressure", bloodPressureLineGraph, bloodPressureCurrentValue, bloodPressureStatus);
            readAllData("../../data files/bloodPressureCSV.csv", "Pulse Rate", pulseRateLineGraph, pulseRateCurrentValue, pulseRateStatus);
            readAllData("../../data files/bloodPressureCSV.csv", "Breathing Rate", breathingRateLineGraph, breathingRateCurrentValue, breathingRateStatus);
            readAllData("../../data files/bloodPressureCSV.csv", "Temperature", temperatureLineGraph, temperatureCurrentValue, temperatureStatus);
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
            bloodPressureLineGraph.ChartAreas[0].AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            bloodPressureLineGraph.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            //bloodPressureLineGraph.ChartAreas[0].AxisY.Maximum = 170;
            //bloodPressureLineGraph.ChartAreas[0].AxisY.Minimum = 70;
        }

        private void setAlarmBtn_Click(object sender, EventArgs e)
        {
            AlarmScreen alarmScreen = new AlarmScreen();
            alarmScreen.Show();
        }
    }
}
