using BankApp.Data;
using BankAppSqlite.Core.Interface;
using BankAppSqlite.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BankApp.Core;

namespace BankAppSqlite.Core.Implementation
{
    public class AccountService : IAccountService
    {
        DataContext _ctx = new DataContext();
        AccountRepo _actRepo = new AccountRepo();
        public void Deposit(int accNum, decimal amt, string note, string type)
        {

            if (amt >= 0)
            {
                var m = _actRepo.GetAccountByAccountNumber(accNum);
                if (m != null)
                {
                    using (_ctx = new DataContext())
                    {
                        var with = from o in _ctx.Accounts
                                   where o.AccountNumber == accNum
                                   select o;
                      
                        foreach (var item in with)
                        {
                            item.Balance += amt;
                            break;
                        }

                        _ctx.SaveChanges();
                        
                    }

                }
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string DisplayBalance(int accountNumber)
        {
            string acct = "";

                var m = _actRepo.GetAccountByAccountNumber(accountNumber);
              if (m != null)
              {
                using (_ctx = new DataContext())
                {
                    var with = from o in _ctx.Accounts
                                where o.AccountNumber == accountNumber
                                select o;

                    foreach (var item in with)
                    {
                        acct =Convert.ToString( item.Balance);
                    }
                    
                }

              }
            
            return acct;
        }

        public void StatementOfAccount()
        {
            throw new NotImplementedException();
        }

        public void TransferToACustomer(int senderNumber, int receiverNumber, decimal amt, string note, string type)
        {
           
            AccountService _act = new AccountService();
            _act.Withdraw(senderNumber,amt,note,type);
            _act.Deposit(receiverNumber, amt,note, type);
        }

        public void TransferToNoneCustomer(int senderNumber, decimal amt, string note, string type)
        {

            AccountService _act = new AccountService();
            _act.Withdraw(senderNumber, amt, note, type);
        }

        public void Withdraw(int accNum, decimal amt, string note, string type)
        {
            if (amt >= 1)
            {
                var m = _actRepo.GetAccountByAccountNumber(accNum);
                if (m != null)
                {
                    using (_ctx = new DataContext())
                    {
                        var with = from o in _ctx.Accounts
                                   where o.AccountNumber == accNum
                                   select o;
                        foreach (var item in with)
                        {
                            item.Balance -= amt;
                            break;
                        }

                        _ctx.SaveChanges();

                    }

                }
            }
        }

        public void WithdrawFromSavings(int accNum, decimal amt, string note, string type)
        {
            if (amt >= 1)
            {
                var m = _actRepo.GetAccountByAccountNumber(accNum);
                if (m != null)
                {
                    using (_ctx = new DataContext())
                    {
                        var with = from o in _ctx.Accounts
                                   where o.AccountNumber == accNum
                                   select o;
                        foreach (var item in with)
                        {
                            item.Balance -= amt;
                            break;
                        }

                        _ctx.SaveChanges();

                    }

                }
            }
        }
    }
}
