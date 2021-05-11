using BankApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSqlite.Data.Abstraction
{
    public interface ITransactRepo
    {
        public void AddTransaction(int accountNumber, decimal amt, string note, string acctype,DateTime date,int acctId);
    }
}
