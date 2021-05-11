using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Core
{
   public  class Account
   {
        public Account()
        {
            AccountNumber = rd.Next(1000000000, 2000000000);
            Transactions = new List<Transaction>();
        }

        public Account(int num)
        {

        }
        public Random rd = new Random();
        [Key]
        public int Id { get; set; }
        public int AccountNumber { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string AccountType { get; set; }

        public decimal WithdrawalLimit { get; set; }

        public decimal Balance { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
