namespace Taxi_Management_System
{
    partial class Register
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
            this.username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(78, 162);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(112, 19);
            this.username.TabIndex = 0;
            this.username.Text = "USERNAME :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(78, 241);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(120, 19);
            this.password.TabIndex = 2;
            this.password.Text = "PASSWORD  :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 3;
            // 
            // confirmpassword
            // 
            this.confirmpassword.AutoSize = true;
            this.confirmpassword.BackColor = System.Drawing.Color.Transparent;
            this.confirmpassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpassword.Location = new System.Drawing.Point(36, 315);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(197, 19);
            this.confirmpassword.TabIndex = 4;
            this.confirmpassword.Text = "CONFIRM PASSWORD :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 20);
            this.textBox3.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(94, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 19);
            this.name.TabIndex = 6;
            this.name.Text = "NAME :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(262, 20);
            this.textBox4.TabIndex = 7;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Black;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.Cornsilk;
            this.signup.Location = new System.Drawing.Point(212, 362);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(133, 46);
            this.signup.TabIndex = 8;
            this.signup.Text = "sign up";
            this.signup.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Taxi_Management_System.Properties.Resources.taxibackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label confirmpassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button signup;
    }
}