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

namespace BedsideSystem
{
    public partial class BedsideMainScreen : Form
    {
        public static List<BloodPressure> listbloodPressure = new List<BloodPressure>();
        public BedsideMainScreen()
        {
            InitializeComponent();
        }

        private async void readData()
        {   

            string path = "../../data files/bloodPressureCSV.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                foreach(string column in columns)
                {
                    await Task.Delay(1000);
                    DateTime currentDate = DateTime.Now;
                    DateTime currentTime = DateTime.Now;
                    DBConnector dBConn = new DBConnector();
                    dBConn.connect();
                    BloodPressure bloodPressureData = new BloodPressure();
                    bloodPressureData.BloodPressureValue = double.Parse(column);
                    bloodPressureData.BloodPressureDate = currentDate;
                    bloodPressureData.BloodPressureTime = currentTime;
                    BloodPressureHandler bloodPressureHandler = new BloodPressureHandler();
                    int result = bloodPressureHandler.addNewBloodPressure(dBConn.getConn(), bloodPressureData, BedsideLoginScreen.bedside_patient_id);

                    if(result == 1)
                    {
                        bloodPressureCurrentValue.Text = bloodPressureData.BloodPressureValue.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("Insert Data failed");
                        break;  
                    }
                    //listbloodPressure.Add(bloodPressure);
                    
                    
                }
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            readData();
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
        }
    }
}
