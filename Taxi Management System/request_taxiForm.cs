//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Taxi_Management_System
//{
//    public partial class request_taxiForm : Form
//    {
        
//        public request_taxiForm()
//        {
//            InitializeComponent();
//        }

//        private void buttonrequest_Click(object sender, EventArgs e)
//        {
//            Program.client.ReserveTaxi(Program.client.ClientUsername, textBoxfrom.Text, textBoxto.Text);
//            Login.requested = true;
//            clientHome client_home = new clientHome();
//            client_home.Show();
//            this.Close();
//        }
//    }
//}
