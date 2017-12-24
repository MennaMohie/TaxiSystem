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
    public partial class ClientTrips : Form
    {
        public ClientTrips()
        {
            InitializeComponent();
        }

        private void ClientTrips_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.updateFiles();
        }
    }
}
