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
        public static string currentClientUsername;
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
    }
}
