using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_Management_System
{
    public partial class Login : Form
    {
        public static string currentUsername;
        public static bool isAdmin = false;
        public static bool isClient = false;
        public static bool isDriver = false;
        public static bool requested = false;
        public static bool notregisterd = true;
        public Login()
        {
            InitializeComponent();
            this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(22)))));
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(179)))), ((int)(((byte)(22)))));
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

                
                Program.client.ClientLogin(usernametextbox.Text, loginpasswordtext.Text);
                Program.admin.AdminLogin(usernametextbox.Text, loginpasswordtext.Text);
            Program.driver.DriverLogin(usernametextbox.Text, loginpasswordtext.Text);
             if (isAdmin==false && isClient==false && notregisterd==true && isDriver==false)
            {
                MessageBox.Show("Username isn't registered please register");
            }
           else  if (isAdmin==true && isClient==false && notregisterd==false && isDriver == false)
            {
                AdminHome adminhome = new AdminHome();
                adminhome.Show();
                this.Hide();
            }
            else if (isAdmin==false && isClient==true && notregisterd==false && isDriver == false)
            {
                clientHome client_home = new clientHome();
                client_home.Show();
                this.Hide();
            }
             else if (isAdmin == false && isClient == false && notregisterd == false && isDriver == true)
            {
                Driver_Home driverhome = new Driver_Home();
                driverhome.Show();
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
