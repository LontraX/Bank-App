using BankApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSqlite.Data.Abstraction
{
    public interface IAccountRepo
    {
        public List<Account> GetOwnersAccounts();
        public Account GetAccountByAccountNumber(int acctNumber);
        public bool NumberExists();

        public Account CreateAccount(int custId, string acctype, decimal withdrawalimit, decimal balance);

        public void DeleteAccount(int accountNumber);

        public void UpdateAccountBalance(decimal balance);

        public void AddAccount();
    }
}
