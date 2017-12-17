namespace Taxi_Management_System
{
    partial class Driver_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Driver_Home));
            this.buttonDriverViewTrips = new System.Windows.Forms.Button();
            this.buttonDriverChangeStatus = new System.Windows.Forms.Button();
            this.buttonDriverRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDriverViewTrips
            // 
            this.buttonDriverViewTrips.BackColor = System.Drawing.Color.Black;
            this.buttonDriverViewTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriverViewTrips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDriverViewTrips.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDriverViewTrips.ForeColor = System.Drawing.Color.White;
            this.buttonDriverViewTrips.Location = new System.Drawing.Point(43, 69);
            this.buttonDriverViewTrips.Name = "buttonDriverViewTrips";
            this.buttonDriverViewTrips.Size = new System.Drawing.Size(258, 100);
            this.buttonDriverViewTrips.TabIndex = 0;
            this.buttonDriverViewTrips.Text = "View Trips";
            this.buttonDriverViewTrips.UseVisualStyleBackColor = false;
            this.buttonDriverViewTrips.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDriverChangeStatus
            // 
            this.buttonDriverChangeStatus.BackColor = System.Drawing.Color.Black;
            this.buttonDriverChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriverChangeStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDriverChangeStatus.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDriverChangeStatus.ForeColor = System.Drawing.Color.White;
            this.buttonDriverChangeStatus.Location = new System.Drawing.Point(43, 194);
            this.buttonDriverChangeStatus.Name = "buttonDriverChangeStatus";
            this.buttonDriverChangeStatus.Size = new System.Drawing.Size(255, 100);
            this.buttonDriverChangeStatus.TabIndex = 2;
            this.buttonDriverChangeStatus.Text = "Change Status";
            this.buttonDriverChangeStatus.UseVisualStyleBackColor = false;
            // 
            // buttonDriverRequests
            // 
            this.buttonDriverRequests.BackColor = System.Drawing.Color.Black;
            this.buttonDriverRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriverRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDriverRequests.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDriverRequests.ForeColor = System.Drawing.Color.White;
            this.buttonDriverRequests.Location = new System.Drawing.Point(43, 318);
            this.buttonDriverRequests.Name = "buttonDriverRequests";
            this.buttonDriverRequests.Size = new System.Drawing.Size(255, 100);
            this.buttonDriverRequests.TabIndex = 3;
            this.buttonDriverRequests.Text = "Available Requests";
            this.buttonDriverRequests.UseVisualStyleBackColor = false;
            // 
            // Driver_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 642);
            this.Controls.Add(this.buttonDriverRequests);
            this.Controls.Add(this.buttonDriverChangeStatus);
            this.Controls.Add(this.buttonDriverViewTrips);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Driver_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDriverViewTrips;
        private System.Windows.Forms.Button buttonDriverChangeStatus;
        private System.Windows.Forms.Button buttonDriverRequests;
    }
}