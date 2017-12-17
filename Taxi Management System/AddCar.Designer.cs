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
            this.PlateNumber = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plate number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model:";
            // 
            // PlateNumber
            // 
            this.PlateNumber.Location = new System.Drawing.Point(244, 97);
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.Size = new System.Drawing.Size(154, 27);
            this.PlateNumber.TabIndex = 4;
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(244, 157);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(154, 27);
            this.Color.TabIndex = 5;
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(244, 218);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(154, 27);
            this.Year.TabIndex = 6;
            this.Year.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(244, 276);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(154, 27);
            this.Model.TabIndex = 7;
            // 
            // AddCarButton
            // 
            this.AddCarButton.BackColor = System.Drawing.Color.Black;
            this.AddCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCarButton.ForeColor = System.Drawing.Color.White;
            this.AddCarButton.Location = new System.Drawing.Point(229, 383);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(120, 32);
            this.AddCarButton.TabIndex = 8;
            this.AddCarButton.Text = "Add";
            this.AddCarButton.UseVisualStyleBackColor = false;
            this.AddCarButton.Click += new System.EventHandler(this.AddCarButton_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.AddCarButton);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.PlateNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlateNumber;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Button AddCarButton;
    }
}