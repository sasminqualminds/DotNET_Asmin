using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpdate
{
    internal class Bank
    {
        List<Account> accounts=new List<Account>();

        public void AddAccount(Account account)
        {
            accounts.Add(account);

        }
        public Account GetAccount(string name)
        {
            foreach (Account account in accounts)
            {
                if (account.name == name)
                {
                    return account;
                }
                
            }
            return null;

        }
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }
        public void ExecuteTransaction(DepositTransaction transaction) { 
            transaction.Execute();

        }
        public void ExecuteTransaction(TransferTransaction transaction) {
            transaction.Execute();
        }
       
    }
}
