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
    public partial class RequestTaxiInfo : Form
    {
        public RequestTaxiInfo()
        {
            InitializeComponent();
        }

        private void buttonClientRequest_Click(object sender, EventArgs e)
        {
            //Program.driver.RecieveRequest(DriverGlobals.FreeDrivers.First(),ClientGlobals.ClientMap[Login.currentUsername]);
            Program.client.ReserveTaxi(Login.currentUsername, from.Text, to.Text);
        }

        private void RequestTaxiInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.updateFiles();
        }
    }
}
