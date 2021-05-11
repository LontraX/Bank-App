using BankAppSqlite.Core.Implementation;
using BankAppSqlite.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankAppTests
{
    
    public class AccountRepoTest: DataContextBase
    {
       
        [Fact]
        public void Create_Account()
        {
            var accountRepo = new AccountRepo();

            var expected = accountRepo.CreateAccount(1, "Savings", 1000, 1000);

            Assert.NotNull(expected);
            

            
        }
        [Fact]
        public void Get_Account_Invalid()
        {
            var accountRepo = new AccountRepo();

            var m = accountRepo.GetAccountByAccountNumber(12345674);

            var Actual = m.Id;

            Assert.Equal(0,Actual);
        }


        [Fact]
        public void Get_Account_valid()
        {
            var accountRepo = new AccountRepo();

            var m = accountRepo.GetAccountByAccountNumber(1339665920);

            var Actual = m.Id;

            Assert.Equal(1,Actual);
        }
    }
}
