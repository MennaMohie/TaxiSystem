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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            Client Reg = new Client();
            Reg.ClientUsername = UserNameTextBox.Text;
            Reg.ClientName = NameTextBox.Text;
            Reg.ClientPassword = PasswordTextBox.Text;



            if (!string.IsNullOrEmpty(UserNameTextBox.Text) && !string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(ConfirmTextBox.Text))
            {
                if (ConfirmTextBox.Text == PasswordTextBox.Text)
                {
                    bool reg = Reg.ClientRegister(Reg);
                    if (!reg)
                    {
                        MessageBox.Show("used user name, please write another one");

                    }
                    else
                    {
                        MessageBox.Show("Registration Completed successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm password doesn’t match password ");
                }
            }
            else
            {
                MessageBox.Show("Please fill the empty text boxes");
            }

        }
    }
}
