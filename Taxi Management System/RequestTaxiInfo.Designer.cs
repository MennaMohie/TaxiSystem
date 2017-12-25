namespace Taxi_Management_System
{
    partial class RequestTaxiInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.buttonClientRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(100, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(111, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(193, 133);
            this.from.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(246, 27);
            this.from.TabIndex = 2;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(193, 234);
            this.to.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(246, 27);
            this.to.TabIndex = 3;
            // 
            // buttonClientRequest
            // 
            this.buttonClientRequest.BackColor = System.Drawing.Color.Black;
            this.buttonClientRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClientRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClientRequest.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientRequest.ForeColor = System.Drawing.Color.White;
            this.buttonClientRequest.Location = new System.Drawing.Point(206, 358);
            this.buttonClientRequest.Name = "buttonClientRequest";
            this.buttonClientRequest.Size = new System.Drawing.Size(161, 56);
            this.buttonClientRequest.TabIndex = 4;
            this.buttonClientRequest.Text = "Request";
            this.buttonClientRequest.UseVisualStyleBackColor = false;
            this.buttonClientRequest.Click += new System.EventHandler(this.buttonClientRequest_Click_1);
            // 
            // RequestTaxiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi_Management_System.Properties.Resources.LogInBackground;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonClientRequest);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestTaxiInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request taxi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Button buttonClientRequest;
    }
}