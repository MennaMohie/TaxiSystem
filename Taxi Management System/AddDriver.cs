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
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDriverbutton_Click(object sender, EventArgs e)
        {
            int lastdriverid = DriverGlobals.DriverMap.Count();
            int currentid = lastdriverid + 1;
            string driver_id = Convert.ToString(currentid);
            Program.admin.AddNewDriver(textBoxusername.Text, textBoxpassword.Text, textBoxname.Text, driver_id, textBoxcarnumber.Text, textBoxsalary.Text, textBoxstatus.Text);
            MessageBox.Show("The Driver has been added successfully");
            AdminHome admin_homr = new AdminHome();
            admin_homr.Show();
            this.Hide();
        }
    }
}
