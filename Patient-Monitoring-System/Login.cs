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
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(usernameTextBox.Text))
            //{
            //    MessageBox.Show("Please enter username");
            //    return;
            //}

            //if (string.IsNullOrEmpty(passwordTextBox.Text))
            //{
            //    MessageBox.Show("Please enter password");
            //    return;
            //}

            //if((usernameTextBox.Text == "monitor") && (passwordTextBox.Text == "123456"))
            //{
            //    MainScreen mainscreen = new MainScreen();
            //    mainscreen.Show();
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password");
            //    usernameTextBox.Text = "";
            //    passwordTextBox.Text = "";
            //}

            MainScreen mainscreen = new MainScreen();
            mainscreen.Show();
            Close();

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
