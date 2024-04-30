using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankUpdate
{
    internal class DepositTransaction
    {
        public Account account;
        public decimal amount;
        public bool executed = false;
        public bool success = false;
        public bool reversed = false;

        public bool Success
        {
            get
            {
                return success;
            }
        }

        public DepositTransaction(Account account, decimal amount)
        {
            this.account = account;
            this.amount = amount;
        }

        public void Execute()
        {
            if (executed)
            {
                throw new Exception("Cannot execute this transaction as it has already been executed.");
            }

            executed = true;
            success = account.Deposit(amount);

            
        }

        public void Rollback()
        {
            if (executed)
            {
                throw new Exception("Cannot rollback this transaction as it has not been executed.");
            }

            if (reversed)
            {
                throw new Exception("Cannot rollback this transaction as it has already been reversed.");
            }

            reversed = true;

            if (!success)
            {
                account.Withdraw(amount);
            }
        }

        public void Print()
        {
            Console.WriteLine($"Deposit Transaction Details:");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Executed: {executed}");
            Console.WriteLine($"Success: {success}");

            if (reversed)
            {
                Console.WriteLine("Note: This transaction has been reversed.");
            }
        }
    }
}
