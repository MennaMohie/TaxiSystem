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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void buttonAddNewDriver_Click(object sender, EventArgs e)
        {
            AddDriver adddriver = new AddDriver();
            adddriver.Show();
            this.Hide();
        }

        private void buttonAddNewCar_Click(object sender, EventArgs e)
        {
            AddCar addcar = new AddCar();
            addcar.Show();
            this.Hide();
        }

        private void buttonViewReports_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.updateFiles();
        }
    }
}
