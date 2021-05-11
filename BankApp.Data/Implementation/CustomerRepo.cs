using BankApp.Core;
using BankApp.Data;
using BankAppSqlite.Data.Abstraction;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BankAppSqlite.Data.Implementation
{
    public class CustomerRepo : ICustomerRepo
    {
        public void AddCustomer(string lastname, string firstname, string email, string password)
        {
            using (var ctx = new DataContext())
            {
                Customer cus = new Customer()
                {
                    LastName = lastname,
                    FirstName = firstname,
                    Email = email,
                    Password = password,
                };
                
                ctx.Add(cus);
                ctx.SaveChanges();

            }
        }

        public Customer CreateCustomer(string lastname, string firstname, string email, string password)
        {
            Customer customer = new Customer()
            {
                LastName = lastname,
                FirstName = firstname,
                Email = email,
                Password = password,
            };

            return customer;
                
        }

        public void DeleteCustomer(string email)
        {
            
            using (var ctx = new DataContext())
            {
                var customer = from s in ctx.Customers
                               where s.Email == email
                               select s;
                ctx.Remove(customer);
                ctx.SaveChanges();
            }
        }

        public List<Customer> FetchAll()
        {
            List<Customer> _allCustomers = new List<Customer>();
            using(var _ctx = new DataContext())
            {
                var all = from a in _ctx.Customers
                          select a;
                foreach (var item in all)
                {
                    _allCustomers.Add(item);
                }
                               
            }
            return _allCustomers;
        }

        public bool FetchByEmail(string email)
        {
            bool isit = false;
            Customer customer = new Customer();
            using(var ctx = new DataContext())
            {
                var cus = (from c in ctx.Customers
                          where c.Email == email
                          select c.Email).Any();
                if(cus == true)
                {
                    isit = true;
                }
            }
            return isit;
        }

        public bool FetchByPassword(string password)
        {
            bool isit = true;
           
            using(var _ctx = new DataContext())
            {
                var cus = (from c in _ctx.Customers
                          where c.Password == password
                          select c.Password).Any() ;
                if(cus == true)
                {
                    isit = true;
                }
                else
                {
                    isit = false;
                }
            }
            
            return isit;
        }
    }
}
