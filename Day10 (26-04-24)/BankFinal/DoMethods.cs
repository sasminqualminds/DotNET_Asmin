using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal class DoMethods
    {
        Bank bank=new Bank();
        public void DoDeposit(Bank toBank) {
            Account toAccount =FindAccount(toBank);
            if(toAccount==null)
            {
                return ;
            }
            Console.WriteLine("Enter deposit amount");
            decimal amountToDeposit=Convert.ToDecimal(Console.ReadLine());
            DepositTransaction depositTransaction=new DepositTransaction(toAccount,amountToDeposit);
            toBank.ExecuteTransaction(depositTransaction);

            if (depositTransaction.Success())
            {
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Deposit failed.");
            }
            Console.WriteLine();
            //depositTransaction.RollBack();
            //depositTransaction.print();
            // account.Deposit(amountToDeposit);


        }
        public void DoWithdraw(Bank fromBank) {
            Account fromAccount= FindAccount(fromBank);
            if(fromAccount==null) { return ; }
            Console.WriteLine("Enter amount to withdraw");
            decimal amountToWithdraw=Convert.ToDecimal(Console.ReadLine());
            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(fromAccount, amountToWithdraw);
            fromBank.ExecuteTransaction(withdrawTransaction);

            if (withdrawTransaction.Success())
            {
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Withdrawal failed.");
            }
            Console.WriteLine();
            //withdrawTransaction.RollBack();
            //withdrawTransaction.Print();
            //account.Withdraw(amountToWithdraw);
        }
        public void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account == null)
            {
                return;
            }

            Console.WriteLine("Account Details:");
            account.Print(account);
            Console.WriteLine();

        }
        public void DoTransfer(Bank bank)
        {
            Console.WriteLine("Enter account to withdraw from ");
            
            
            Account fromAccount = FindAccount(bank);
            if (fromAccount == null) { return; }
            Console.WriteLine("Enter amount to transfer ");
            decimal amountToTransfer=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter account to transfer to ");
           
            
            Account ToAccount = FindAccount(bank);
            if (ToAccount == null) { return; }

            TransferTransaction transferTransaction=new TransferTransaction(fromAccount,ToAccount,amountToTransfer);
            bank.ExecuteTransaction(transferTransaction);
            //transferTransaction.print();
            Console.WriteLine();

        }

        public void DoAddAccount(Bank bank)
        {
            Console.WriteLine("Enter name of the account");
            string accountName =Console.ReadLine();
            Console.WriteLine("Enter Starting balance");
            int startingBalance=Convert.ToInt32(Console.ReadLine());
            Account account=new Account();
            account.Balance = startingBalance;
            account.name = accountName;
            bank.AddAccount(account);
            Console.WriteLine();
        }

        public Account FindAccount(Bank fromBank)
        {
            Console.WriteLine("enter account name:");
            string name=Console.ReadLine();
            Account result=fromBank.GetAccount(name);
            if(result==null)
            {
                Console.WriteLine($"No account found with name {name}");

            }
            return result;
        }

        public void DoPrintTransactionHistory(Bank bank)
        {
            Console.WriteLine("Transaction History:");

            List<Transaction> transactions = bank.GetTransactions();

            foreach (Transaction transaction in transactions)
            {
                // Print transaction details
                transaction.print();

                // Check if the transaction has been executed
                if (transaction.Executed())
                {
                    Console.WriteLine("Transaction has been executed.");
                }
                else
                {
                    Console.WriteLine("Transaction has not been executed.");
                }

                // Check if the transaction has been reversed
                if (transaction.Reversed())
                {
                    Console.WriteLine("Transaction has been reversed.");
                }
            }
            Console.WriteLine();
        }

    }
}
