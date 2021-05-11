using BankApp.Data;
using BankAppSqlite.Core.Implementation;
using BankAppSqlite.Data.Implementation;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BankApp.Core;



namespace BankAppSqlite.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void SubmitDeposit_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountRepo accountRepo = new AccountRepo();
            TransactionRepo transactionRepo = new TransactionRepo();
            var accnum1 = Convert.ToInt32(AccountNumberDeposit.Text);
            var amt1 = Convert.ToDecimal(Convert.ToString(AmountDeposit.Text));
            var note1 = Convert.ToString(NoteDeposit.Text);
            if(SavingsRadioDeposit.Checked == true)
            {
                accountService.Deposit(accnum1, amt1, note1, "Savings");
                var m = accountService.DisplayBalance(accnum1);
                var z =  accountRepo.GetAccountByAccountNumber(accnum1);
                transactionRepo.AddTransaction(accnum1,amt1,note1,"Savings",DateTime.Now,z.Id);

                MessageBox.Show($"You have successfully deposited ${amt1} you now have ${m}");
            }
            else if(CurrentRadioDeposit.Checked == true)
            {
                accountService.Deposit(accnum1, amt1, note1, "Current");
                var m = accountService.DisplayBalance(accnum1);
                var z = accountRepo.GetAccountByAccountNumber(accnum1);
                transactionRepo.AddTransaction(accnum1, amt1, note1, "Savings", DateTime.Now, z.Id);
                MessageBox.Show($"You have successfully deposited ${amt1} you now have ${m}");
            }
           
        }

        private void AmountDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountRepo accountRepo = new AccountRepo();
            TransactionRepo transactionRepo = new TransactionRepo();
            var accnum1 = Convert.ToInt32(AccountNumWithdraw.Text);

            var amt1 = Convert.ToDecimal(Convert.ToString(AmountWithdraw.Text));

            var note1 = Convert.ToString(NoteWithdraw.Text);
            
            if (radioButton1.Checked == true)
            {
                accountService.Withdraw(accnum1, amt1, note1, "Savings");
                var m = accountService.DisplayBalance(accnum1);
                var z = accountRepo.GetAccountByAccountNumber(accnum1);
                transactionRepo.AddTransaction(accnum1, amt1, note1, "Savings", DateTime.Now, z.Id);

                MessageBox.Show($"You have successfully withdrawn {amt1} you now have {m}");

            }
            else if (radioButton2.Checked == true)
            {
                accountService.Deposit(accnum1, amt1, note1, "Current");
                var m = accountService.DisplayBalance(accnum1);

                var z = accountRepo.GetAccountByAccountNumber(accnum1);
                transactionRepo.AddTransaction(accnum1, amt1, note1, "Savings", DateTime.Now, z.Id);
                MessageBox.Show($"You have successfully withdrawn {amt1} you now have {m}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            var m = Convert.ToInt32(AccountNumBalance.Text);

            var y = accountService.DisplayBalance(m);
            MessageBox.Show($"You currently have ${y}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountService accountService = new AccountService();
            AccountRepo accountRepo = new AccountRepo();
            TransactionRepo transactionRepo = new TransactionRepo();

            var receivernum1 = Convert.ToInt32(textBox5.Text);
            var sendernum1 = Convert.ToInt32(textBox4.Text);
            var amt1 = Convert.ToDecimal(Convert.ToString(textBox6.Text));
            var note1 = Convert.ToString(textBox7.Text);
            
            if (radioButton3.Checked == true)
            {
                accountService.Deposit(receivernum1, amt1, note1, "Savings");

                
                var z = accountRepo.GetAccountByAccountNumber(receivernum1);
                transactionRepo.AddTransaction(receivernum1, amt1, note1, "Savings", DateTime.Now, z.Id);

                accountService.Withdraw(sendernum1, amt1, note1, "Savings");
                var y = accountRepo.GetAccountByAccountNumber(sendernum1);
                transactionRepo.AddTransaction(sendernum1,amt1,note1,"Savings",DateTime.Now, y.Id);

                var m = accountService.DisplayBalance(sendernum1);

                MessageBox.Show($"You have successfully transferred {amt1} you now have ${m}");


            }
            else if (radioButton4.Checked == true)
            {
                accountService.Deposit(receivernum1, amt1, note1, "Current");


                var z = accountRepo.GetAccountByAccountNumber(receivernum1);
                transactionRepo.AddTransaction(receivernum1, amt1, note1, "Current", DateTime.Now, z.Id);

                accountService.Withdraw(sendernum1, amt1, note1, "Current");
                var y = accountRepo.GetAccountByAccountNumber(sendernum1);
                transactionRepo.AddTransaction(sendernum1, amt1, note1, "Current", DateTime.Now, y.Id);

                var m = accountService.DisplayBalance(sendernum1);

                MessageBox.Show($"You have successfully transferred {amt1} you now have ${m}");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
