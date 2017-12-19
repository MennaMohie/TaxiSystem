namespace Taxi_Management_System
{
    partial class AddCar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcarnumber = new System.Windows.Forms.TextBox();
            this.textBoxcarcolor = new System.Windows.Forms.TextBox();
            this.textBoxcaryear = new System.Windows.Forms.TextBox();
            this.textBoxcarmodel = new System.Windows.Forms.TextBox();
            this.AddDriverbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(93, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLATE NUMBER: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(93, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "COLOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(93, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "YEAR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(93, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "MODEL:";
            // 
            // textBoxcarnumber
            // 
            this.textBoxcarnumber.Location = new System.Drawing.Point(279, 118);
            this.textBoxcarnumber.Name = "textBoxcarnumber";
            this.textBoxcarnumber.Size = new System.Drawing.Size(276, 32);
            this.textBoxcarnumber.TabIndex = 4;
            // 
            // textBoxcarcolor
            // 
            this.textBoxcarcolor.Location = new System.Drawing.Point(187, 184);
            this.textBoxcarcolor.Name = "textBoxcarcolor";
            this.textBoxcarcolor.Size = new System.Drawing.Size(368, 32);
            this.textBoxcarcolor.TabIndex = 5;
            // 
            // textBoxcaryear
            // 
            this.textBoxcaryear.Location = new System.Drawing.Point(170, 249);
            this.textBoxcaryear.Name = "textBoxcaryear";
            this.textBoxcaryear.Size = new System.Drawing.Size(385, 32);
            this.textBoxcaryear.TabIndex = 6;
            this.textBoxcaryear.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxcarmodel
            // 
            this.textBoxcarmodel.Location = new System.Drawing.Point(187, 315);
            this.textBoxcarmodel.Name = "textBoxcarmodel";
            this.textBoxcarmodel.Size = new System.Drawing.Size(368, 32);
            this.textBoxcarmodel.TabIndex = 7;
            // 
            // AddDriverbutton
            // 
            this.AddDriverbutton.BackColor = System.Drawing.Color.Black;
            this.AddDriverbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDriverbutton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDriverbutton.ForeColor = System.Drawing.Color.White;
            this.AddDriverbutton.Location = new System.Drawing.Point(401, 387);
            this.AddDriverbutton.Name = "AddDriverbutton";
            this.AddDriverbutton.Size = new System.Drawing.Size(212, 75);
            this.AddDriverbutton.TabIndex = 8;
            this.AddDriverbutton.Text = "Add Car";
            this.AddDriverbutton.UseVisualStyleBackColor = false;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi_Management_System.Properties.Resources.LogInBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.AddDriverbutton);
            this.Controls.Add(this.textBoxcarmodel);
            this.Controls.Add(this.textBoxcaryear);
            this.Controls.Add(this.textBoxcarcolor);
            this.Controls.Add(this.textBoxcarnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Car";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcarnumber;
        private System.Windows.Forms.TextBox textBoxcarcolor;
        private System.Windows.Forms.TextBox textBoxcaryear;
        private System.Windows.Forms.TextBox textBoxcarmodel;
        private System.Windows.Forms.Button AddDriverbutton;
    }
}