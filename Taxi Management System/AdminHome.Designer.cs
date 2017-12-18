namespace Taxi_Management_System
{
    partial class AdminHome
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
            this.buttonAddNewDriver = new System.Windows.Forms.Button();
            this.buttonAddNewCar = new System.Windows.Forms.Button();
            this.buttonViewReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddNewDriver
            // 
            this.buttonAddNewDriver.BackColor = System.Drawing.Color.Black;
            this.buttonAddNewDriver.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewDriver.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewDriver.Location = new System.Drawing.Point(24, 24);
            this.buttonAddNewDriver.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAddNewDriver.Name = "buttonAddNewDriver";
            this.buttonAddNewDriver.Size = new System.Drawing.Size(255, 90);
            this.buttonAddNewDriver.TabIndex = 0;
            this.buttonAddNewDriver.Text = "Add New Driver";
            this.buttonAddNewDriver.UseVisualStyleBackColor = false;
            // 
            // buttonAddNewCar
            // 
            this.buttonAddNewCar.BackColor = System.Drawing.Color.Black;
            this.buttonAddNewCar.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewCar.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewCar.Location = new System.Drawing.Point(24, 242);
            this.buttonAddNewCar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonAddNewCar.Name = "buttonAddNewCar";
            this.buttonAddNewCar.Size = new System.Drawing.Size(255, 90);
            this.buttonAddNewCar.TabIndex = 1;
            this.buttonAddNewCar.Text = "Add New Car";
            this.buttonAddNewCar.UseVisualStyleBackColor = false;
            // 
            // buttonViewReports
            // 
            this.buttonViewReports.BackColor = System.Drawing.Color.Black;
            this.buttonViewReports.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewReports.ForeColor = System.Drawing.Color.White;
            this.buttonViewReports.Location = new System.Drawing.Point(24, 134);
            this.buttonViewReports.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonViewReports.Name = "buttonViewReports";
            this.buttonViewReports.Size = new System.Drawing.Size(255, 90);
            this.buttonViewReports.TabIndex = 2;
            this.buttonViewReports.Text = "View Reports";
            this.buttonViewReports.UseVisualStyleBackColor = false;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi_Management_System.Properties.Resources.WhatsApp_Image_2017_12_17_at_16_01_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.buttonViewReports);
            this.Controls.Add(this.buttonAddNewCar);
            this.Controls.Add(this.buttonAddNewDriver);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewDriver;
        private System.Windows.Forms.Button buttonAddNewCar;
        private System.Windows.Forms.Button buttonViewReports;
    }
}