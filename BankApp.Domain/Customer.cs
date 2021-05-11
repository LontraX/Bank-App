using BankAppSqlite.Commons;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Core
{
   public  class Customer
    {
        public int CustomerId { get; set; } 


        //public int AccountId { get; set; }
        private string _lname;

        public string LastName
        {
            get { return _lname; }
            set
            {
                _lname = Utilities.RemoveDigitsFromStart(value.Trim());
                _lname = Utilities.FirstCharacterToUpper(_lname);

            }
        }

        private string _firstname;

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                _firstname = Utilities.RemoveDigitsFromStart(value.Trim());
                _firstname = Utilities.FirstCharacterToUpper(_firstname);
            }
        }

        public string FullName
        {
            get
            {
                return LastName + " " + FirstName;
            }
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}

