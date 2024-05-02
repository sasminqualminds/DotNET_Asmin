using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal class Bank
    {
        private List<Transaction> transactions=new List<Transaction>();
        List<Account> _accounts=new List<Account>();
        Account account =new Account();

        public List<Transaction> GetTransactions()
        {
            return transactions;
        }
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        public Account GetAccount(string name) 
        {
            foreach(Account account in _accounts)
            {
                if (account.Name==name){
                    return account;
                } 
            }
            return null;
        }

        public void ExecuteTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            transaction.Execute();

        }

    }
}