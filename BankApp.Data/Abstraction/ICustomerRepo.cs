using BankApp.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSqlite.Data.Abstraction
{
    public interface ICustomerRepo
    {
        public Customer CreateCustomer(string lastname, string firstname, string email, string password);
        public bool FetchByPassword(string password);

        public List<Customer> FetchAll();

        public void DeleteCustomer(string email);

        public void AddCustomer(string lastname, string firstname , string email, string password);

        public bool FetchByEmail(string email);
    }
}
