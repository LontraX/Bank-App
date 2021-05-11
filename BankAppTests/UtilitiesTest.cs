using BankApp.Core;
using BankAppSqlite.Commons;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace BankAppTests
{
    public class UtilitiesTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Customer customer = new Customer
            {
                FirstName = "Jane",
                LastName = "Doe",
            };
            string expected = "Doe Jane";

            string actual = customer.FullName;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void EmailValid()
        {
            Customer customer = new Customer
            {
                Email = "meyou@gmail.com"
            };

            var expected = true;

            var actual = Utilities.IsEmailValid(customer.Email);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void EmailInvalid()
        {
            Customer customer = new Customer
            {
                Email = "me.com"
            };

            var expected = false;

            var actual = Utilities.IsEmailValid(customer.Email);

            Assert.Equal(expected, actual);

        }
    }
}
