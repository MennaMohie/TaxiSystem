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
            this.label1 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DriverTripsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverTripsTable
            // 
            this.DriverTripsTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DriverTripsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverTripsTable.Location = new System.Drawing.Point(32, 107);
            this.DriverTripsTable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DriverTripsTable.Name = "DriverTripsTable";
            this.DriverTripsTable.Size = new System.Drawing.Size(514, 329);
            this.DriverTripsTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver Trips";
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.Black;
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.White;
            this.Backbutton.Location = new System.Drawing.Point(480, 55);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(92, 37);
            this.Backbutton.TabIndex = 10;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // DriverTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi_Management_System.Properties.Resources.LogInBackground;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DriverTripsTable);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DriverTrips";
            this.Text = "DriverTrips";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DriverTrips_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DriverTripsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DriverTripsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
    }
}