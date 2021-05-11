using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Core
{
    public class Transaction
    {
        public int TransactionId { get; set; }
       // public int AccountNumber { get; set; }

        public int AccountNumber{ get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public string AccType { get; set; }
        public DateTime DateOfTransaction { get; set; }

        public Account Account { get; set; }
    }
}
