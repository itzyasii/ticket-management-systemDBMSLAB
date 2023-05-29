namespace HomeScreen
{
    partial class SigninForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigninForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup = new System.Windows.Forms.Button();
            this.signin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1124, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1123, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(1123, 321);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(174, 22);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(1123, 416);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(174, 22);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(487, 29);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(285, 91);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HomeScreen.Properties.Resources.Busimage;
            this.pictureBox1.Location = new System.Drawing.Point(47, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 394);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1125, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "New here? Let\'s Sign you up here!";
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.DodgerBlue;
            this.signup.FlatAppearance.BorderSize = 3;
            this.signup.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold);
            this.signup.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(1197, 547);
            this.signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(140, 36);
            this.signup.TabIndex = 7;
            this.signup.Text = "SIGN UP";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.DodgerBlue;
            this.signin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signin.FlatAppearance.BorderSize = 3;
            this.signin.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.White;
            this.signin.Location = new System.Drawing.Point(1211, 465);
            this.signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(126, 34);
            this.signin.TabIndex = 8;
            this.signin.Text = "SIGN IN";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // SigninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 793);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SigninForm";
            this.Text = "Signing in";
            this.Load += new System.EventHandler(this.SigninForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Button signin;
    }
}