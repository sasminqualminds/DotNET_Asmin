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

        public void DoDeposit(Account account)
        {
            Console.WriteLine("Enter amount to deposit:");
            decimal amountToDeposit = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction depositTransaction = new DepositTransaction(account, amountToDeposit);
            depositTransaction.Execute();
            depositTransaction.Print();
            depositTransaction.Rollback();

            if (depositTransaction.Success)
            {
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Deposit failed. Please enter a valid amount.");
            }
        }

        public void DoWithdraw(Account account)
        {
            Console.WriteLine("Enter amount to withdraw:");
            decimal amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, amountToWithdraw);
            withdrawTransaction.Execute();
            withdrawTransaction.Print();
            withdrawTransaction.Rollback();

            if (withdrawTransaction.Success)
            {
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Withdrawal failed. Insufficient funds or invalid amount.");
            }
        }



        public void DoPrint(Account account)
        {
            account.Print();
        }
        public void DoTransfer(Account account1, Account account2)
        {
            Console.WriteLine($"Account 1 Balance Before Transfer: {account1.balance}");
            Console.WriteLine($"Account 2 Balance Before Transfer: {account2.balance}");

            Console.WriteLine("Enter transfer amount:");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transferTransaction = new TransferTransaction(account1, account2, transferAmount);
            transferTransaction.Execute();
            if (transferTransaction.Success)
            {
                Console.WriteLine("Transfer successful.");
                transferTransaction.Print();
            }
            else
            {
                Console.WriteLine("Transfer failed. Please enter a valid amount.");
                transferTransaction.Rollback();
            }
            transferTransaction.Print();

            

            Console.WriteLine($"Account 1 Balance After Transfer: {account1.balance}");
            Console.WriteLine($"Account 2 Balance After Transfer: {account2.balance}");
        }
    }
}

    


