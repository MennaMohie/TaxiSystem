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
            Program.driver.ChangeStatus(Login.currentUsername);
            MessageBox.Show("The status is changed");
        }

        private void buttonDriverRequests_Click(object sender, EventArgs e)
        {
            for (int i=0; i<AdminGlobals.AllTrips.Count(); i++)
            {
                if (AdminGlobals.AllTrips[i].DriverUserName == Login.currentUsername && AdminGlobals.AllTrips[i].Status == "Pending")
                {
                    MessageBox.Show("Client's Name: " + AdminGlobals.AllTrips[i].ClientName + "\nClient's Username: " + AdminGlobals.AllTrips[i].ClientUsername + "\nFrom: " + AdminGlobals.AllTrips[i].From + "\nTo: " + AdminGlobals.AllTrips[i].To);
                    AdminGlobals.AllTrips[i].Status = "Accepted";
                }
            }
        }

        private void Driver_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.updateFiles();
        }
    }
}
