namespace Taxi_Management_System
{
    partial class ClientHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientHome));
            this.ReserveTaxiButton = new System.Windows.Forms.Button();
            this.ViewHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReserveTaxiButton
            // 
            this.ReserveTaxiButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReserveTaxiButton.BackgroundImage")));
            this.ReserveTaxiButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveTaxiButton.Location = new System.Drawing.Point(47, 311);
            this.ReserveTaxiButton.Name = "ReserveTaxiButton";
            this.ReserveTaxiButton.Size = new System.Drawing.Size(187, 66);
            this.ReserveTaxiButton.TabIndex = 0;
            this.ReserveTaxiButton.Text = "Reserve Taxi";
            this.ReserveTaxiButton.UseVisualStyleBackColor = true;
            // 
            // ViewHistoryButton
            // 
            this.ViewHistoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ViewHistoryButton.BackgroundImage")));
            this.ViewHistoryButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewHistoryButton.Location = new System.Drawing.Point(323, 311);
            this.ViewHistoryButton.Name = "ViewHistoryButton";
            this.ViewHistoryButton.Size = new System.Drawing.Size(187, 66);
            this.ViewHistoryButton.TabIndex = 1;
            this.ViewHistoryButton.Text = "View My History";
            this.ViewHistoryButton.UseVisualStyleBackColor = true;
            this.ViewHistoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.ViewHistoryButton);
            this.Controls.Add(this.ReserveTaxiButton);
            this.DoubleBuffered = true;
            this.Name = "ClientHome";
            this.Text = "ClientHome";
            this.Load += new System.EventHandler(this.ClientHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReserveTaxiButton;
        private System.Windows.Forms.Button ViewHistoryButton;
    }
}