using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankUpdate
{
    public class Account
    {
        public decimal balance;
        public string name;

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false; 
            }

            balance += amount; 
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || balance < amount)
            {
                return false; 
            }

            balance -= amount; 
            return true;
        }

        public void Print()
        {
            Console.WriteLine($"Account Balance: {balance}");
        }
    }
}
