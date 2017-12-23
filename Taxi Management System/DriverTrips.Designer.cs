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
            this.DriverTripsTable.Name = "DriverTripsTable";
            this.DriverTripsTable.Size = new System.Drawing.Size(240, 150);
            this.DriverTripsTable.TabIndex = 0;
            // 
            // DriverTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 336);
            this.Controls.Add(this.DriverTripsTable);
            this.Name = "DriverTrips";
            this.Text = "DriverTrips";
            ((System.ComponentModel.ISupportInitialize)(this.DriverTripsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DriverTripsTable;
    }
}