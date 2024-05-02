using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankFinal
{
    internal class Account
    {
        public string name;
        public decimal balance;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance=value;
            }
        }
        public bool Deposit(decimal amountToDeposit)
        {
            if(amountToDeposit > 0)
            {
                Balance += amountToDeposit;
                Console.WriteLine("remaining balance in deposit account:" + Balance);

                return true;
            }
            Console.WriteLine("Unable to deposit negative amount");

            return false;
        }

        public bool Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw < Balance && amountToWithdraw>0)
            {
                Balance -= amountToWithdraw;
                Console.WriteLine("remaining balance in withdraw account:"+ Balance);
                return true;
            }
            Console.WriteLine("Unsufficient funds");
            return false;
            
        }

        public void Print(Account account)
        {
            account.Name = Name;
            Console.WriteLine($"Name of the account is : {account.Name}");
            account.Balance = Balance;
            Console.WriteLine($"Balance is : {account.Balance}");
        }
        
    }
}
