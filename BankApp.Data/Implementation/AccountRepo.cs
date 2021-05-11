using BankApp.Core;
using BankApp.Data;
using BankAppSqlite.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAppSqlite.Data.Implementation
{
    public class AccountRepo : IAccountRepo
    {
        public void AddAccount()
        {
            throw new NotImplementedException();
        }

        public Account CreateAccount(int custId,string acctype, decimal withdrawalimit,decimal balance)
        {
            Account account = new Account()
            {
               
                AccountType = acctype,
                WithdrawalLimit = withdrawalimit,
                Balance = balance
            };
            return account;
        }

        public void DeleteAccount(int accountNumber)
        {
            using(var _ctx = new DataContext())
            {
                var acct = from s in _ctx.Accounts
                           where s.AccountNumber == accountNumber
                           select s;
                _ctx.Remove(acct);
                _ctx.SaveChanges();
            }
        }

        public Account GetAccountByAccountNumber(int acctNumber)
        {
            Account account = new Account();
            using(var _ctx = new DataContext())
            {
                var acct = from s in _ctx.Accounts
                           where s.AccountNumber == acctNumber
                           select s;

                foreach (var item in acct)
                {
                    account.AccountNumber = item.AccountNumber;
                    account.AccountType = item.AccountType;
                    account.Balance = item.Balance;

                    account.Id = item.Id;
                    account.WithdrawalLimit = item.WithdrawalLimit;
                };
            }

            return account ;
        }

        public List<Account> GetOwnersAccounts()
        {
            List<Account> acclist = new List<Account>();
            using(var _ctx = new DataContext())
            {
                var list = from a in _ctx.Customers
                           select a.Accounts;
            }

            return acclist;
        }

        public bool NumberExists()
        {
            throw new NotImplementedException();
        }

        public void UpdateAccountBalance(decimal balance)
        {

            using (var _ctx = new DataContext())
            {
                var bal = from o in _ctx.Accounts
                          select o.Balance;

                var m = Convert.ToDecimal(bal);
                m = balance;

                _ctx.Update(m);
                _ctx.SaveChanges();
            }
        }
    }
}
