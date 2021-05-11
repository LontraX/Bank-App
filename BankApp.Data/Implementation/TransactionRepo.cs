using BankApp.Data;
using BankAppSqlite.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using BankApp.Core;

namespace BankAppSqlite.Data.Implementation
{
    public class TransactionRepo : ITransactRepo
    {
        public void AddTransaction(int accountNumber, decimal amt, string note, string acctype, DateTime date, int acct)
        {
            using (var _ctx = new DataContext())
            {
                var Trans = new BankApp.Core.Transaction()
                {
                    AccountNumber = accountNumber,
                    Amount = amt,
                    Note = note,
                    AccType = acctype,
                    DateOfTransaction = date,
                    
                };

                _ctx.Add(Trans);
                _ctx.SaveChanges();
            }
            
        }
    }
}
