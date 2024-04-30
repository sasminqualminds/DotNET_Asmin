using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankUpdate
{
    internal class DoMethods
    {

        public void DoDeposit(Bank toBank)
        {
            Account toAccount = FindAccount(toBank);
            if (toAccount == null)
            {
                return;
            }

            Console.WriteLine("Enter the amount to deposit:");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a valid positive number.");
            }

            DepositTransaction depositTransaction = new DepositTransaction(toAccount, amount);
            toBank.ExecuteTransaction(depositTransaction);
            depositTransaction.Print();

        }


        public void DoWithdraw(Bank fromBank)
        {
            Account fromAccount = FindAccount(fromBank);
            if (fromAccount == null)
            {
                return;
            }

            Console.WriteLine("Enter the amount to withdraw:");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a valid positive number.");
            }

            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(fromAccount, amount);
            fromBank.ExecuteTransaction(withdrawTransaction);
            withdrawTransaction.Print();
        }



        public void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null)
            {
                return;
            }

            Console.WriteLine("Account Details:");
            account.Print();
        }
        public void DoTransfer(Bank bank)
        {

            Account fromAccount = FindAccount(bank);
            if (fromAccount == null)
            {
                return;
            }

            Console.WriteLine("Enter transfer amount:");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
            Account toAccount = FindAccount(bank);

            if (toAccount == null)
            {
                return;

            }

            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, transferAmount);
            transferTransaction.Execute();
            if (transferTransaction.Success)
            {
                Console.WriteLine("Transfer successful.");
                Console.WriteLine("Amount after Transfer:");
                Console.WriteLine("Balance in " + fromAccount.name + " : " + fromAccount.balance);
                Console.WriteLine("Balance in " + toAccount.name + " : " + toAccount.balance);
                transferTransaction.Print();
            }
            else
            {
                Console.WriteLine("Transfer failed. Please enter a valid amount.");
                //transferTransaction.Rollback();
            }

        }
        public void CreateNewAccount(Bank bank)
        {
            Console.WriteLine("Enter the name of the account:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the starting balance:");
            decimal balance;
            while (!decimal.TryParse(Console.ReadLine(), out balance) || balance < 0)
            {
                Console.WriteLine("Invalid balance. Please enter a valid amount.");
            }

            Account newAccount = new Account();
            newAccount.balance = balance;
            newAccount.name = name;
            bank.AddAccount(newAccount);
            Console.WriteLine("New account created successfully.");
        }

        public Account FindAccount(Bank fromBank)
        {
            Console.Write("Enter account name: ");
            string name = Console.ReadLine();
            Account result = fromBank.GetAccount(name);

            if (result == null)
            {
                Console.WriteLine($"No account found with name {name}");
            }

            return result;
        }


    }
}




