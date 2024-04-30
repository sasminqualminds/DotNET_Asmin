using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmin_CSharp101
{
    internal class FixedDeposit:IAccount
    {
        private double balance;
        public FixedDeposit(double initialDeposit) { 
            balance = initialDeposit;
        }

        // Deposit function
        public void Deposit(double amount)
        {
            Console.WriteLine("Deposit failed: No additional deposits.");
        }

        // withdraw function
        public void Withdraw(double amount)
        {
            if(amount <= balance)
            {
                balance-=amount;
                Console.WriteLine($"Withdraw Successful. Current balance: {balance}");
            }
            else
            {
                Console.WriteLine("Withdrawal failed: Insufficient funds");
            }
        }

        // returning balance
        public double GetBalance()
        {
            return balance;
        }
    }
}
