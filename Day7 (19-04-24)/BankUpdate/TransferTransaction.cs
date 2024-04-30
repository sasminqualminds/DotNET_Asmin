using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpdate
{
    internal class TransferTransaction
    {
        private Account sourceAccount;
        private Account destinationAccount;
        private decimal amount;
        private bool executed = false;
        private bool success = false;
        private bool reversed = false;

        public bool Success
        {
            get { return success; }
        }

        public TransferTransaction(Account sourceAccount, Account destinationAccount, decimal amount)
        {
            this.sourceAccount = sourceAccount;
            this.destinationAccount = destinationAccount;
            this.amount = amount;
        }

        public void Execute()
        {
            if (executed)
            {
                throw new Exception("Cannot execute this transaction as it has already been executed.");
            }

            executed = true;

            // Withdraw from source account
            bool withdrawSuccess = sourceAccount.Withdraw(amount);

            // If withdrawal from source account is successful, deposit to destination account
            if (withdrawSuccess)
            {
                success = destinationAccount.Deposit(amount);
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

            // If transfer was successful, reverse it by withdrawing from destination and depositing to source
            if (success)
            {
                bool withdrawSuccess = destinationAccount.Withdraw(amount);
                if (withdrawSuccess)
                {
                    success = sourceAccount.Deposit(amount);
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"Transfer Transaction Details:");
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
