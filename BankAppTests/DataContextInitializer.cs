using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Core;
using System.Linq;

namespace BankAppTests
{
   public class DataContextInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.Transactions.Any())
            {
                return;
            }
            if (context.Accounts.Any())
            {
                return;
            }
            if (context.Customers.Any())
            {
                return;
            }
            Seed(context);
        }
        private static void Seed(DataContext context)
        {
            
            var accounts = new Account[]
            {
                new Account{Id = 1, AccountType = "", Balance = 1110, CustomerId = 1, },
                new Account{Id = 2, AccountType = "", Balance = 1110, CustomerId = 2, },
                new Account{Id = 3, AccountType = "", Balance = 1110, CustomerId = 3, },
            };
            context.AddRange(accounts);
            context.SaveChanges();

            var transactions = new Transaction[]
            {
             new Transaction{TransactionId = 1, AccountNumber = 0, Amount = 123, DateOfTransaction = DateTime.Now, Note = "", AccType = "Deposit"},
             new Transaction{TransactionId = 2, AccountNumber = 1, Amount = 123, DateOfTransaction = DateTime.Now, Note = "", AccType = "withdrwal"}   ,
             new Transaction{TransactionId = 3, AccountNumber = 2, Amount = 123, DateOfTransaction = DateTime.Now, Note = "", AccType= "Deposit"}   ,
           };
            context.AddRange(transactions);
            context.SaveChanges();
            var customers = new Customer[]
            {
                new Customer{CustomerId = 1, Email = "", FirstName = "", LastName = "", Password = ""},
                new Customer{CustomerId = 2, Email = "", FirstName = "", LastName = "", Password = ""},
                new Customer{CustomerId = 3, Email = "", FirstName = "", LastName = "", Password = ""},
            };
            context.AddRange(customers);
            context.SaveChanges();
        }
    }
}
