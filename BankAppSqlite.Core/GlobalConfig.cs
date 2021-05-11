using BankAppSqlite.Core.Implementation;
using BankAppSqlite.Core.Interface;
using BankAppSqlite.Data.Abstraction;
using BankAppSqlite.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSqlite.Core
{
    public static class GlobalConfigg
    {
       public static IAccountService accountService { get; private set; }

       public static IAccountRepo accountRepo { get; private set; }

       public static ICustomerRepo customerRepo { get; private set; }

       public static ITransactRepo transactRepo { get; private set; }

        public static void AddInstance()
        {
            accountService = new AccountService();
            accountRepo = new AccountRepo();
            customerRepo = new CustomerRepo();
            transactRepo = new TransactionRepo();
        }


        public static void RemoveInstance()
        {
            accountRepo = null;
            accountService = null;
            customerRepo = null;
            transactRepo = null;
        }
    }
}
