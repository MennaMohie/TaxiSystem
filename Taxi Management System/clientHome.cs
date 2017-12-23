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

    public partial class clientHome : Form
    {
        
        public clientHome()
        {
            InitializeComponent();
        }

        private void Viewtripsbuttonclient_Click(object sender, EventArgs e)
        {
            Program.client.ViewClientHistory(Program.client.ClientUsername);
            this.Hide();
        }

        private void buttonClientRequest_Click(object sender, EventArgs e)
        {
            if (Login.requested == true)
            {
                MessageBox.Show("Sorry you already requested a Taxi");
                buttonClientRequest.Visible = false;

            }
            else
            {
                request_taxiForm request = new request_taxiForm();
                request.Show();
                this.Hide();
            }
        }
    }
}
