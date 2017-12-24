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

            if(Reg.ClientRegister(Reg, ConfirmTextBox.Text))
            {
                clientHome ClientHome = new clientHome();
                ClientHome.Show();
                this.Hide();
            }
  
        }
    }
}
