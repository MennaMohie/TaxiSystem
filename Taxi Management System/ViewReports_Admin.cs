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
    public partial class ViewReports_Admin : Form
    {
        public ViewReports_Admin()
        {
            InitializeComponent();
            viewTrips();
        }

        public void viewTrips()
        {
            int num_trips;
            num_trips = AdminGlobals.AllTrips.Count;
            DataTable Trips = new DataTable();
            Trips.Columns.Add("Client Name");
            Trips.Columns.Add("Driver Name");
            Trips.Columns.Add("From");
            Trips.Columns.Add("To");
            Trips.Columns.Add("Date");
            Trips.Columns.Add("Status");

            DataRow NewTrip;
            for (int i = 0; i < num_trips; i++)
            {
                NewTrip = Trips.NewRow();
                NewTrip["Client Name"] = AdminGlobals.AllTrips[i].ClientUsername;
                NewTrip["Driver Name"] = AdminGlobals.AllTrips[i].DriverUserName;
                NewTrip["From"] = AdminGlobals.AllTrips[i].From;
                NewTrip["To"] = AdminGlobals.AllTrips[i].To;
                NewTrip["Date"] = AdminGlobals.AllTrips[i].Date;
                NewTrip["Status"] = AdminGlobals.AllTrips[i].Status;
                Trips.Rows.Add(NewTrip);
            }
            dataGridViewAdminTrips.DataSource = Trips;
        }
        private void dataGridViewAdminTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
