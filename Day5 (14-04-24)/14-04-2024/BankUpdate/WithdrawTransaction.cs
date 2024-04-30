using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpdate
{
    internal class WithdrawTransaction
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

        public WithdrawTransaction(Account account, decimal amount)
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
            success = account.Withdraw(amount);

            if (success)
            {
                account.balance -= amount; // Update the balance
                

            }

        }

        public void Rollback()
        {
            if (!executed)
            {
                throw new Exception("Cannot rollback this transaction as it has not been executed.");
            }

            if (reversed)
            {
                throw new Exception("Cannot rollback this transaction as it has already been reversed.");
            }

            reversed = true;
            

            if (success)
            {
                success = account.Deposit(amount);

            }
            else
            {
                Console.WriteLine("Account Balance after rollback: " + reversed + " " + account.balance);
            }
        }

        public void Print()
        {
            Console.WriteLine($"Withdraw Transaction Details:");
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
