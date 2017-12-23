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
    public partial class Driver_Home : Form
    {
        public Driver_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDriverChangeStatus_Click(object sender, EventArgs e)
        {
            Program.driver.ChangeStatus(Program.driver.DriverName);
            MessageBox.Show("The status is changed");
        }

        private void buttonDriverRequests_Click(object sender, EventArgs e)
        {

        }
    }
}
