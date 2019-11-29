using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class StaffSchedule : Form
    {
        public StaffSchedule()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMainScreen mainScreen = new ManagerMainScreen();
            mainScreen.ShowDialog();
            this.Close();
        }
    }
}
