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

namespace Patient_Monitoring_System
{
    public partial class central_station_screen : Form
    {
        private static int counter = 0;
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
                List<Label> listLabelBedsideNumber = new List<Label>();
                List<Label> listLabelBedsideStatus = new List<Label>();
                List<Label> listLabelBPValue = new List<Label>();
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

                List<Bedside> listbedsides = new List<Bedside>();
                List<BloodPressure> listBP = new List<BloodPressure>();
                CentralStationHandler csHandler = new CentralStationHandler();
                DBConnector dBc = new DBConnector();
                dBc.connect();
                bayName.Text = centralStationNameComboBox.SelectedItem.ToString();
                listbedsides = csHandler.getAllBedsideMonitor(dBc.getConn(), centralStationNameComboBox.SelectedItem.ToString());
               
                for (int i = 0; i < listbedsides.Count; i++)
                {
                    listLabelBedsideNumber[i].Text = listbedsides[i].Id.ToString();
                    if (listbedsides[i].Status == true)
                    {
                        listLabelBedsideStatus[i].Text = "ONLINE";
                        listLabelBedsideStatus[i].ForeColor = Color.Lime;
                    }
                    else
                    {
                        listLabelBedsideStatus[i].Text = "OFFLINE";
                        listLabelBedsideStatus[i].ForeColor = Color.Red;
                    }

                    //listLabelBPValue[i].Text = csHandler.getMaxValue(dBc.getConn(), listbedsides[i]).ToString();
                    
                }

                while (true)
                {
                    //Thread.Sleep(1000);
                    
                    listLabelBPValue[0].Text = csHandler.getMaxValue(dBc.getConn(), listbedsides[0]).ToString();
                    

                    

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CentralStationHandler csHandler = new CentralStationHandler();
            //DBConnector dBc = new DBConnector();
            //dBc.connect();
            //List<BloodPressure> listBP = new List<BloodPressure>();
            //listBP = csHandler.getMaxValue(dBc.getConn(), centralStationNameComboBox.SelectedItem.ToString());
            //foreach(BloodPressure i in listBP)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
