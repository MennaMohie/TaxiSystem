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
    public partial class Login_Register : Form
    {
        

        public Login_Register()
        {
            InitializeComponent();

            Program.client.FillCientMap();
            Program.driver.FillDriverMap();
            Program.car.FillCarMap();
            Program.admin.FillAdminMap();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
