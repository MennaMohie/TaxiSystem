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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmpassword = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
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
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(251, 83);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(262, 20);
            this.NameTextBox.TabIndex = 1;
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
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(251, 161);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(262, 20);
            this.UserNameTextBox.TabIndex = 3;
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
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(251, 240);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(262, 20);
            this.PasswordTextBox.TabIndex = 5;
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
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Location = new System.Drawing.Point(251, 314);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(262, 20);
            this.ConfirmTextBox.TabIndex = 7;
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
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.username);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label confirmpassword;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Button signup;
    }
}