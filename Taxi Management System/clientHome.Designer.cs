namespace Taxi_Management_System
{
    partial class clientHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientHome));
            this.buttonClientRequest = new System.Windows.Forms.Button();
            this.Viewtripsbuttonclient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientRequest
            // 
            this.buttonClientRequest.BackColor = System.Drawing.Color.Black;
            this.buttonClientRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClientRequest.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientRequest.ForeColor = System.Drawing.Color.White;
            this.buttonClientRequest.Location = new System.Drawing.Point(42, 168);
            this.buttonClientRequest.Name = "buttonClientRequest";
            this.buttonClientRequest.Size = new System.Drawing.Size(255, 90);
            this.buttonClientRequest.TabIndex = 1;
            this.buttonClientRequest.Text = "Request Taxi";
            this.buttonClientRequest.UseVisualStyleBackColor = false;
            // 
            // Viewtripsbuttonclient
            // 
            this.Viewtripsbuttonclient.BackColor = System.Drawing.Color.Black;
            this.Viewtripsbuttonclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Viewtripsbuttonclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Viewtripsbuttonclient.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewtripsbuttonclient.ForeColor = System.Drawing.Color.White;
            this.Viewtripsbuttonclient.Location = new System.Drawing.Point(42, 34);
            this.Viewtripsbuttonclient.Name = "Viewtripsbuttonclient";
            this.Viewtripsbuttonclient.Size = new System.Drawing.Size(255, 90);
            this.Viewtripsbuttonclient.TabIndex = 2;
            this.Viewtripsbuttonclient.Text = "View Trips";
            this.Viewtripsbuttonclient.UseVisualStyleBackColor = false;
            // 
            // clientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Viewtripsbuttonclient);
            this.Controls.Add(this.buttonClientRequest);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "clientHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientRequest;
        private System.Windows.Forms.Button Viewtripsbuttonclient;
    }
}