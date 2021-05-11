using BankApp.Core;
using BankApp.Data;
using BankAppSqlite.Core.Implementation;
using BankAppSqlite.Data.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BankAppSqlite.UI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SignUpSubmit_Click(object sender, EventArgs e)
        {
            AccountRepo _acct = new AccountRepo();
            CustomerRepo _cus = new CustomerRepo();
            var fname = Convert.ToString( SignUpFirstName.Text);
            var lname = Convert.ToString( SignUpLastName.Text);
            var email1 = Convert.ToString( SignUpEmail.Text);
            var password1 = Convert.ToString( SignUpPassword.Text);
            var deposit1 = Convert.ToDecimal(Convert.ToString(SignUpInitialDeposit.Text));
            if(radioButton1Savings.Checked == true)
            {

                Account account = new Account();
                var acctype = "Savings";
                var mycus = _cus.CreateCustomer(lname,fname,email1,password1);
                var id = mycus.CustomerId;
                
                var myacct = _acct.CreateAccount(id,acctype,1000,deposit1);
                myacct.AccountNumber = account.AccountNumber;

                myacct.Balance = deposit1;
                myacct.WithdrawalLimit = Convert.ToDecimal(1000);
                myacct.AccountType = acctype;
                
                using (var ctx = new DataContext())
                {
                    
                    var dbcus = new Customer() {LastName = mycus.LastName,FirstName = mycus.FirstName,Email=mycus.Email,Password = mycus.Password };
                    

                    ctx.Add(dbcus);
                    ctx.SaveChanges();

                    var dbact = new Account() { CustomerId = dbcus.CustomerId , AccountNumber = myacct.AccountNumber, AccountType = myacct.AccountType, WithdrawalLimit = myacct.WithdrawalLimit, Balance = myacct.Balance };
                    ctx.Add(dbact);
                    ctx.SaveChanges();


                };

            }else if (radioButton2Current.Checked == true)
            {
                Account account = new Account();
                var acctype = "Current";
                var mycus = _cus.CreateCustomer(lname, fname, email1, password1);
                var id = mycus.CustomerId;

                var myacct = _acct.CreateAccount(id, acctype, 0, deposit1);
                myacct.AccountNumber = account.AccountNumber;

                myacct.Balance = deposit1;
                myacct.WithdrawalLimit = Convert.ToDecimal(0);
                myacct.AccountType = acctype;

                using (var ctx = new DataContext())
                {

                    var dbcus = new Customer() { LastName = mycus.LastName, FirstName = mycus.FirstName, Email = mycus.Email, Password = mycus.Password };


                    ctx.Add(dbcus);
                    ctx.SaveChanges();

                    var dbact = new Account() { CustomerId = dbcus.CustomerId, AccountNumber = myacct.AccountNumber, AccountType = myacct.AccountType, WithdrawalLimit = myacct.WithdrawalLimit, Balance = myacct.Balance };
                    ctx.Add(dbact);
                    ctx.SaveChanges();


                };
            }

            Main main = new Main();
            main.Show();
        }
    }
}
