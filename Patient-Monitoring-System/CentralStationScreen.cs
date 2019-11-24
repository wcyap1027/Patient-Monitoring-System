using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Monitoring_System
{
    public partial class central_station_screen : Form
    {
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
                SEbtn.Visible = true;
                NEbtn.Visible = true;
            }
            else
            {
                if(e.KeyCode == Keys.F)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    TopMost = true;
                    SEbtn.Visible = false;
                    NEbtn.Visible = false;
                }
            }
        }

        private void SEbtn_Click(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            bayName.Text = csHandler.getBayName(dBc.getConn(), "Bay "+SEbtn.Text);
        }

        private void NEbtn_Click(object sender, EventArgs e)
        {
            CentralStationHandler csHandler = new CentralStationHandler();
            DBConnector dBc = new DBConnector();
            dBc.connect();
            bayName.Text = csHandler.getBayName(dBc.getConn(), "Bay " + NEbtn.Text);
        }

        
    }
}
