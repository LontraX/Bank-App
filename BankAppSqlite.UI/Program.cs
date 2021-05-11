using BankAppSqlite.Core;
using BankAppSqlite.Core.Interface;
using BankAppSqlite.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppSqlite.UI
{
    static class Program
    {
        public static IAccountRepo accountRepo;
        public static ICustomerRepo customerRepo;
        public static IAccountService accountService;
        public static ITransactRepo transactRepo;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //accountService = new AccountService();
            //accountRepo = new AccountRepo();
            //customerRepo = new CustomerRepo();
            //transactRepo = new TransactRepo();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfigg.AddInstance();

            accountRepo = GlobalConfigg.accountRepo;
            customerRepo = GlobalConfigg.customerRepo;
            accountService = GlobalConfigg.accountService;
            transactRepo = GlobalConfigg.transactRepo;
           
            

            Application.Run(new Login());
        }
    }
}
