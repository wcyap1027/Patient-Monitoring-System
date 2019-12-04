using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BedsideSystem
{
    public partial class HistoryScreen : Form
    {
        public HistoryScreen()
        {
            InitializeComponent();
        }

        public string LabelText
        {
            get
            {
                return this.historyLabelText.Text;
            }

            set
            {
                this.historyLabelText.Text = value;
            }
        }

        private void HistoryScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
