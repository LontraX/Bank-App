
namespace BankAppSqlite.UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SubmitDeposit = new System.Windows.Forms.Button();
            this.AccountSelectionDeposit = new System.Windows.Forms.Panel();
            this.CurrentRadioDeposit = new System.Windows.Forms.RadioButton();
            this.SavingsRadioDeposit = new System.Windows.Forms.RadioButton();
            this.AmountDeposit = new System.Windows.Forms.TextBox();
            this.NoteDeposit = new System.Windows.Forms.TextBox();
            this.AccountNumberDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.NoteWithdraw = new System.Windows.Forms.TextBox();
            this.AmountWithdraw = new System.Windows.Forms.TextBox();
            this.AccountNumWithdraw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.AccountNumBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.AccountSelectionDeposit.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(339, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.SubmitDeposit);
            this.tabPage1.Controls.Add(this.AccountSelectionDeposit);
            this.tabPage1.Controls.Add(this.AmountDeposit);
            this.tabPage1.Controls.Add(this.NoteDeposit);
            this.tabPage1.Controls.Add(this.AccountNumberDeposit);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deposit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SubmitDeposit
            // 
            this.SubmitDeposit.Location = new System.Drawing.Point(228, 431);
            this.SubmitDeposit.Name = "SubmitDeposit";
            this.SubmitDeposit.Size = new System.Drawing.Size(112, 34);
            this.SubmitDeposit.TabIndex = 7;
            this.SubmitDeposit.Text = "Submit";
            this.SubmitDeposit.UseVisualStyleBackColor = true;
            this.SubmitDeposit.Click += new System.EventHandler(this.SubmitDeposit_Click);
            // 
            // AccountSelectionDeposit
            // 
            this.AccountSelectionDeposit.Controls.Add(this.CurrentRadioDeposit);
            this.AccountSelectionDeposit.Controls.Add(this.SavingsRadioDeposit);
            this.AccountSelectionDeposit.Location = new System.Drawing.Point(23, 343);
            this.AccountSelectionDeposit.Name = "AccountSelectionDeposit";
            this.AccountSelectionDeposit.Size = new System.Drawing.Size(488, 62);
            this.AccountSelectionDeposit.TabIndex = 6;
            // 
            // CurrentRadioDeposit
            // 
            this.CurrentRadioDeposit.AutoSize = true;
            this.CurrentRadioDeposit.Location = new System.Drawing.Point(296, 23);
            this.CurrentRadioDeposit.Name = "CurrentRadioDeposit";
            this.CurrentRadioDeposit.Size = new System.Drawing.Size(160, 29);
            this.CurrentRadioDeposit.TabIndex = 1;
            this.CurrentRadioDeposit.TabStop = true;
            this.CurrentRadioDeposit.Text = "CurrentAccount";
            this.CurrentRadioDeposit.UseVisualStyleBackColor = true;
            // 
            // SavingsRadioDeposit
            // 
            this.SavingsRadioDeposit.AutoSize = true;
            this.SavingsRadioDeposit.Location = new System.Drawing.Point(73, 23);
            this.SavingsRadioDeposit.Name = "SavingsRadioDeposit";
            this.SavingsRadioDeposit.Size = new System.Drawing.Size(163, 29);
            this.SavingsRadioDeposit.TabIndex = 0;
            this.SavingsRadioDeposit.TabStop = true;
            this.SavingsRadioDeposit.Text = "SavingsAccount";
            this.SavingsRadioDeposit.UseVisualStyleBackColor = true;
            // 
            // AmountDeposit
            // 
            this.AmountDeposit.Location = new System.Drawing.Point(376, 167);
            this.AmountDeposit.Name = "AmountDeposit";
            this.AmountDeposit.Size = new System.Drawing.Size(150, 31);
            this.AmountDeposit.TabIndex = 5;
            this.AmountDeposit.TextChanged += new System.EventHandler(this.AmountDeposit_TextChanged);
            // 
            // NoteDeposit
            // 
            this.NoteDeposit.Location = new System.Drawing.Point(219, 248);
            this.NoteDeposit.Name = "NoteDeposit";
            this.NoteDeposit.Size = new System.Drawing.Size(150, 31);
            this.NoteDeposit.TabIndex = 4;
            // 
            // AccountNumberDeposit
            // 
            this.AccountNumberDeposit.Location = new System.Drawing.Point(376, 99);
            this.AccountNumberDeposit.Name = "AccountNumberDeposit";
            this.AccountNumberDeposit.Size = new System.Drawing.Size(150, 31);
            this.AccountNumberDeposit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.NoteWithdraw);
            this.tabPage2.Controls.Add(this.AmountWithdraw);
            this.tabPage2.Controls.Add(this.AccountNumWithdraw);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Withdraw";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(16, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 41);
            this.panel1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(348, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(165, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Current Account";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(166, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "savings Account";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // NoteWithdraw
            // 
            this.NoteWithdraw.Location = new System.Drawing.Point(219, 248);
            this.NoteWithdraw.Name = "NoteWithdraw";
            this.NoteWithdraw.Size = new System.Drawing.Size(150, 31);
            this.NoteWithdraw.TabIndex = 5;
            // 
            // AmountWithdraw
            // 
            this.AmountWithdraw.Location = new System.Drawing.Point(237, 158);
            this.AmountWithdraw.Name = "AmountWithdraw";
            this.AmountWithdraw.Size = new System.Drawing.Size(150, 31);
            this.AmountWithdraw.TabIndex = 4;
            // 
            // AccountNumWithdraw
            // 
            this.AccountNumWithdraw.Location = new System.Drawing.Point(237, 41);
            this.AccountNumWithdraw.Name = "AccountNumWithdraw";
            this.AccountNumWithdraw.Size = new System.Drawing.Size(150, 31);
            this.AccountNumWithdraw.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "AccountNumber";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transfer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(16, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 65);
            this.panel2.TabIndex = 9;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(307, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(165, 29);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Current Account";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(43, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(168, 29);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Savings Account";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(323, 259);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(175, 31);
            this.textBox7.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(323, 194);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(175, 31);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(323, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(175, 31);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(323, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(175, 31);
            this.textBox4.TabIndex = 4;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Receiver\'s Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sender\'s Account Number";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.AccountNumBalance);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(588, 526);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Balance";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Balance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountNumBalance
            // 
            this.AccountNumBalance.Location = new System.Drawing.Point(318, 100);
            this.AccountNumBalance.Name = "AccountNumBalance";
            this.AccountNumBalance.Size = new System.Drawing.Size(195, 31);
            this.AccountNumBalance.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Number";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(588, 526);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Statement of Account";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.Controls.Add(this.button4);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(588, 526);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "LogOut";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 90);
            this.button4.TabIndex = 0;
            this.button4.Text = "LogOut";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.AccountSelectionDeposit.ResumeLayout(false);
            this.AccountSelectionDeposit.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button SubmitDeposit;
        private System.Windows.Forms.Panel AccountSelectionDeposit;
        private System.Windows.Forms.RadioButton CurrentRadioDeposit;
        private System.Windows.Forms.RadioButton SavingsRadioDeposit;
        private System.Windows.Forms.TextBox AmountDeposit;
        private System.Windows.Forms.TextBox NoteDeposit;
        private System.Windows.Forms.TextBox AccountNumberDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox NoteWithdraw;
        private System.Windows.Forms.TextBox AmountWithdraw;
        private System.Windows.Forms.TextBox AccountNumWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AccountNumBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
    }
}