
namespace BankAppSqlite.UI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUpFirstName = new System.Windows.Forms.TextBox();
            this.SignUpLastName = new System.Windows.Forms.TextBox();
            this.SignUpEmail = new System.Windows.Forms.TextBox();
            this.SignUpPassword = new System.Windows.Forms.TextBox();
            this.SignUpInitialDeposit = new System.Windows.Forms.TextBox();
            this.SignUpAccountChoice = new System.Windows.Forms.Panel();
            this.radioButton2Current = new System.Windows.Forms.RadioButton();
            this.radioButton1Savings = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SignUpSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SignUpAccountChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Initial Deposit";
            // 
            // SignUpFirstName
            // 
            this.SignUpFirstName.Location = new System.Drawing.Point(354, 84);
            this.SignUpFirstName.Name = "SignUpFirstName";
            this.SignUpFirstName.Size = new System.Drawing.Size(190, 31);
            this.SignUpFirstName.TabIndex = 5;
            // 
            // SignUpLastName
            // 
            this.SignUpLastName.Location = new System.Drawing.Point(354, 160);
            this.SignUpLastName.Name = "SignUpLastName";
            this.SignUpLastName.Size = new System.Drawing.Size(190, 31);
            this.SignUpLastName.TabIndex = 6;
            // 
            // SignUpEmail
            // 
            this.SignUpEmail.Location = new System.Drawing.Point(354, 237);
            this.SignUpEmail.Name = "SignUpEmail";
            this.SignUpEmail.Size = new System.Drawing.Size(190, 31);
            this.SignUpEmail.TabIndex = 7;
            // 
            // SignUpPassword
            // 
            this.SignUpPassword.Location = new System.Drawing.Point(354, 302);
            this.SignUpPassword.Name = "SignUpPassword";
            this.SignUpPassword.Size = new System.Drawing.Size(190, 31);
            this.SignUpPassword.TabIndex = 8;
            // 
            // SignUpInitialDeposit
            // 
            this.SignUpInitialDeposit.Location = new System.Drawing.Point(354, 500);
            this.SignUpInitialDeposit.Name = "SignUpInitialDeposit";
            this.SignUpInitialDeposit.Size = new System.Drawing.Size(190, 31);
            this.SignUpInitialDeposit.TabIndex = 9;
            // 
            // SignUpAccountChoice
            // 
            this.SignUpAccountChoice.Controls.Add(this.radioButton2Current);
            this.SignUpAccountChoice.Controls.Add(this.radioButton1Savings);
            this.SignUpAccountChoice.Controls.Add(this.label6);
            this.SignUpAccountChoice.Location = new System.Drawing.Point(56, 378);
            this.SignUpAccountChoice.Name = "SignUpAccountChoice";
            this.SignUpAccountChoice.Size = new System.Drawing.Size(1001, 59);
            this.SignUpAccountChoice.TabIndex = 10;
            // 
            // radioButton2Current
            // 
            this.radioButton2Current.AutoSize = true;
            this.radioButton2Current.Location = new System.Drawing.Point(650, 21);
            this.radioButton2Current.Name = "radioButton2Current";
            this.radioButton2Current.Size = new System.Drawing.Size(165, 29);
            this.radioButton2Current.TabIndex = 2;
            this.radioButton2Current.TabStop = true;
            this.radioButton2Current.Text = "Current Account";
            this.radioButton2Current.UseVisualStyleBackColor = true;
            // 
            // radioButton1Savings
            // 
            this.radioButton1Savings.AutoSize = true;
            this.radioButton1Savings.Location = new System.Drawing.Point(317, 21);
            this.radioButton1Savings.Name = "radioButton1Savings";
            this.radioButton1Savings.Size = new System.Drawing.Size(168, 29);
            this.radioButton1Savings.TabIndex = 1;
            this.radioButton1Savings.TabStop = true;
            this.radioButton1Savings.Text = "Savings Account";
            this.radioButton1Savings.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Account Type";
            // 
            // SignUpSubmit
            // 
            this.SignUpSubmit.Location = new System.Drawing.Point(522, 561);
            this.SignUpSubmit.Name = "SignUpSubmit";
            this.SignUpSubmit.Size = new System.Drawing.Size(246, 50);
            this.SignUpSubmit.TabIndex = 11;
            this.SignUpSubmit.Text = "Submit";
            this.SignUpSubmit.UseVisualStyleBackColor = true;
            this.SignUpSubmit.Click += new System.EventHandler(this.SignUpSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(144, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(382, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Note, a minimum amount of $1000 is required";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1093, 634);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SignUpSubmit);
            this.Controls.Add(this.SignUpAccountChoice);
            this.Controls.Add(this.SignUpInitialDeposit);
            this.Controls.Add(this.SignUpPassword);
            this.Controls.Add(this.SignUpEmail);
            this.Controls.Add(this.SignUpLastName);
            this.Controls.Add(this.SignUpFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.SignUpAccountChoice.ResumeLayout(false);
            this.SignUpAccountChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SignUpFirstName;
        private System.Windows.Forms.TextBox SignUpLastName;
        private System.Windows.Forms.TextBox SignUpEmail;
        private System.Windows.Forms.TextBox SignUpPassword;
        private System.Windows.Forms.TextBox SignUpInitialDeposit;
        private System.Windows.Forms.Panel SignUpAccountChoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SignUpSubmit;
        private System.Windows.Forms.RadioButton radioButton2Current;
        private System.Windows.Forms.RadioButton radioButton1Savings;
        private System.Windows.Forms.Label label7;
    }
}