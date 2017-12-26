namespace Taxi_Management_System
{
    partial class ViewReports_Admin
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
            this.dataGridViewAdminTrips = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdminTrips
            // 
            this.dataGridViewAdminTrips.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAdminTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminTrips.Location = new System.Drawing.Point(27, 161);
            this.dataGridViewAdminTrips.Name = "dataGridViewAdminTrips";
            this.dataGridViewAdminTrips.Size = new System.Drawing.Size(623, 327);
            this.dataGridViewAdminTrips.TabIndex = 0;
            this.dataGridViewAdminTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminTrips_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trip Reports";
            // 
            // ViewReports_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi_Management_System.Properties.Resources.LogInBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAdminTrips);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewReports_Admin";
            this.Text = "View Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdminTrips;
        private System.Windows.Forms.Label label1;
    }
}