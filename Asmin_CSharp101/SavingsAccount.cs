using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmin_CSharp101
{
    
    internal class SavingsAccount : IAccount
    {
        public double balance;
        public int CountOfTransaction;

        public SavingsAccount()
        {
            balance = 0;
            CountOfTransaction = 0;
        }

        // Deposit function
        public void Deposit(double amount)
        {
            if(CountOfTransaction < 5 && amount<=50000)
            {
                balance += amount;
                Console.WriteLine($"Deposit Successful. Current balance: {balance}");
                CountOfTransaction++;
            }
            else
            {
                Console.WriteLine("Deposit failed : Maximum transaction limit or amount exceeded");
            }
        }

        // Withdraw function
        public void Withdraw(double amount)
        {
            if (balance - amount >= 1000)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. Current balance:{balance}");
            }
            else
            {
                Console.WriteLine("Withdraw failed: Insufficient balance.");
            }
        }

        // returning balance
        public double GetBalance()
        {
            return balance;
        }
    }
}
