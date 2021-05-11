using BankApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSqlite.UI
{
    public static class GlobalConfig
    {
        public static DataContext DataInstance { get; set; }
        public static void AddInstance()
        {
            DataInstance = new DataContext();
        }

    }
}
