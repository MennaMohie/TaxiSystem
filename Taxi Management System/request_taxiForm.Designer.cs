namespace Taxi_Management_System
{
    partial class request_taxiForm
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
            this.textBoxfrom = new System.Windows.Forms.TextBox();
            this.textBoxto = new System.Windows.Forms.TextBox();
            this.buttonrequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "To :";
            // 
            // textBoxfrom
            // 
            this.textBoxfrom.Location = new System.Drawing.Point(203, 100);
            this.textBoxfrom.Name = "textBoxfrom";
            this.textBoxfrom.Size = new System.Drawing.Size(249, 27);
            this.textBoxfrom.TabIndex = 2;
            // 
            // textBoxto
            // 
            this.textBoxto.Location = new System.Drawing.Point(203, 215);
            this.textBoxto.Name = "textBoxto";
            this.textBoxto.Size = new System.Drawing.Size(249, 27);
            this.textBoxto.TabIndex = 3;
            // 
            // buttonrequest
            // 
            this.buttonrequest.Location = new System.Drawing.Point(186, 357);
            this.buttonrequest.Name = "buttonrequest";
            this.buttonrequest.Size = new System.Drawing.Size(176, 53);
            this.buttonrequest.TabIndex = 4;
            this.buttonrequest.Text = "Request";
            this.buttonrequest.UseVisualStyleBackColor = true;
            this.buttonrequest.Click += new System.EventHandler(this.buttonrequest_Click);
            // 
            // request_taxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.buttonrequest);
            this.Controls.Add(this.textBoxto);
            this.Controls.Add(this.textBoxfrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "request_taxiForm";
            this.Text = "request_taxiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxfrom;
        private System.Windows.Forms.TextBox textBoxto;
        private System.Windows.Forms.Button buttonrequest;
    }
}