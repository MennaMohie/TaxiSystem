namespace Taxi_Management_System
{
    partial class DriverTrips
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DriverTripsTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DriverTripsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverTripsTable
            // 
            this.DriverTripsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverTripsTable.Location = new System.Drawing.Point(0, 0);
            this.DriverTripsTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DriverTripsTable.Name = "DriverTripsTable";
            this.DriverTripsTable.Size = new System.Drawing.Size(280, 185);
            this.DriverTripsTable.TabIndex = 0;
            // 
            // DriverTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 414);
            this.Controls.Add(this.DriverTripsTable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriverTrips";
            this.Text = "DriverTrips";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DriverTrips_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DriverTripsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DriverTripsTable;
    }
}