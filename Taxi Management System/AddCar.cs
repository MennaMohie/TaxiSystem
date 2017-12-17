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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.AddNewCar(PlateNumber.Text, Color.Text, Year.Text, Model.Text);
        }
    }
}
