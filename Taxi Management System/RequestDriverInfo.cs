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
    public partial class RequestDriverInfo : Form
    {
        public RequestDriverInfo()
        {
            InitializeComponent();
        }

        private void buttonClientRequest_Click(object sender, EventArgs e)
        {
            Program.driver.RecieveRequest(DriverGlobals.FreeDrivers.First(),ClientGlobals.ClientMap[Login.currentUsername]);
        }
    }
}
