
namespace BankAppSqlite.UI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginPageEmail = new System.Windows.Forms.TextBox();
            this.LoginPagePassword = new System.Windows.Forms.TextBox();
            this.LoginPageSubmit = new System.Windows.Forms.Button();
            this.LoginPageSignup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(405, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(405, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(405, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Not a customer ?";
            // 
            // LoginPageEmail
            // 
            this.LoginPageEmail.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoginPageEmail.Location = new System.Drawing.Point(533, 110);
            this.LoginPageEmail.Name = "LoginPageEmail";
            this.LoginPageEmail.Size = new System.Drawing.Size(382, 44);
            this.LoginPageEmail.TabIndex = 4;
            // 
            // LoginPagePassword
            // 
            this.LoginPagePassword.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoginPagePassword.Location = new System.Drawing.Point(533, 256);
            this.LoginPagePassword.Name = "LoginPagePassword";
            this.LoginPagePassword.Size = new System.Drawing.Size(382, 44);
            this.LoginPagePassword.TabIndex = 5;
            // 
            // LoginPageSubmit
            // 
            this.LoginPageSubmit.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoginPageSubmit.Location = new System.Drawing.Point(632, 375);
            this.LoginPageSubmit.Name = "LoginPageSubmit";
            this.LoginPageSubmit.Size = new System.Drawing.Size(184, 48);
            this.LoginPageSubmit.TabIndex = 6;
            this.LoginPageSubmit.Text = "LOGIN";
            this.LoginPageSubmit.UseVisualStyleBackColor = true;
            this.LoginPageSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginPageSignup
            // 
            this.LoginPageSignup.AutoSize = true;
            this.LoginPageSignup.Font = new System.Drawing.Font("Tempus Sans ITC", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LoginPageSignup.LinkColor = System.Drawing.Color.Navy;
            this.LoginPageSignup.Location = new System.Drawing.Point(704, 500);
            this.LoginPageSignup.Name = "LoginPageSignup";
            this.LoginPageSignup.Size = new System.Drawing.Size(100, 37);
            this.LoginPageSignup.TabIndex = 7;
            this.LoginPageSignup.TabStop = true;
            this.LoginPageSignup.Text = "SignUp";
            this.LoginPageSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginPageSignup_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 57F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 605);
            this.Controls.Add(this.LoginPageSignup);
            this.Controls.Add(this.LoginPageSubmit);
            this.Controls.Add(this.LoginPagePassword);
            this.Controls.Add(this.LoginPageEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Name = "Login";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LoginPageEmail;
        private System.Windows.Forms.TextBox LoginPagePassword;
        private System.Windows.Forms.Button LoginPageSubmit;
        private System.Windows.Forms.LinkLabel LoginPageSignup;
    }
}

