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
            //foreach(KeyValuePair<string,Driver> kvp in DriverGlobals.DriverMap)
            //{
            //    MessageBox.Show(kvp.Value.DriverPassword.ToString());
            //}

            bool isClient = false, isDriver = false, isAdmin = false, correctPassword = false;

            if (ClientGlobals.ClientMap.ContainsKey(usernametextbox.Text))
                isClient = true;
            else if (DriverGlobals.DriverMap.ContainsKey(usernametextbox.Text))
                isDriver = true;
            else if (AdminGlobals.AdminMap.ContainsKey(usernametextbox.Text))
                isAdmin = true;

            if (!isClient && !isDriver && !isAdmin)
                MessageBox.Show("Not found. Please retry or register.", "Invalid Data");

            else if (isClient)
            {
                if (ClientGlobals.ClientMap[usernametextbox.Text].ClientPassword == loginpasswordtext.Text)
                    correctPassword = true;
            }
            else if (isDriver)
            {
                if (DriverGlobals.DriverMap[usernametextbox.Text].DriverPassword == loginpasswordtext.Text)
                    correctPassword = true;
            }
            else if (isAdmin)
            {
                if (AdminGlobals.AdminMap[usernametextbox.Text].AdminPassword == loginpasswordtext.Text)
                    correctPassword = true;
            }
            

            if (isClient && correctPassword)
            {
                clientHome ClientHome = new clientHome();
                ClientHome.Show();
                this.Hide();
                currentUsername = usernametextbox.Text;
            }
                       
            else if (isDriver && correctPassword)
            {
                Driver_Home DriverHome = new Driver_Home();
                DriverHome.Show();
                this.Hide();
                currentUsername = usernametextbox.Text;
            } 
                
            else if (isAdmin && correctPassword)
            {
                AdminHome adminHome = new AdminHome();
                adminHome.Show();
                this.Hide();
                currentUsername = usernametextbox.Text;
            }

            else
                MessageBox.Show("Please retry or register.", "Invalid Data");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
