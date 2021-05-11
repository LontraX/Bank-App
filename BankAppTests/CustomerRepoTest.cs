using BankAppSqlite.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankAppTests
{
    public class CustomerRepoTest: DataContextBase
    {
        [Fact]
        public void Create_Customer()
        {
            var customerRepo = new CustomerRepo();

            var m = customerRepo.CreateCustomer("Jane", "Doe","JaneDoe@gmail.com","12qwas");
            
            Assert.NotNull(m);
        }

        [Fact]
        public void Should_Fetch_Customer_by_Email_Valid()
        {
            var customerRepo = new CustomerRepo();

            var m = customerRepo.FetchByEmail("JaneDoe@gmail.com");

            Assert.True(m);
        }

        [Fact]
        public void Should_Fetch_Customer_by_Email_Invalid()
        {
            var customerRepo = new CustomerRepo();

            var m = customerRepo.FetchByEmail("JDoe@gmail.com");

            Assert.False(m);
        }

        [Fact]
        public void Should_Fetch_By_Password_Valid()
        {
            var customerRepo = new CustomerRepo();

            var m = customerRepo.FetchByPassword("12qe");

            Assert.True(m);
        }

        [Fact]
        public void Should_Fetch_By_Password_InValid()
        {
            var customerRepo = new CustomerRepo();

            var m = customerRepo.FetchByPassword("random");

            Assert.False(m);
        }
    }
}
