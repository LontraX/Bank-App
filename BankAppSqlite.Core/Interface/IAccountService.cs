using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppSqlite.Core.Interface
{
    public interface IAccountService
    {
        public void Deposit(int accNum, decimal amt, string note, string type);

        

        public void Withdraw(int accNum, decimal amt, string note, string type);

        public void WithdrawFromSavings(int accNum, decimal amt, string note, string type);
        public string DisplayBalance(int accountNumber);
        public void TransferToACustomer(int senderNumber, int receiverNumber, decimal amt, string note, string type);

        public void TransferToNoneCustomer(int senderNumber, decimal amt, string note, string type);

        public void StatementOfAccount();
    }
}
