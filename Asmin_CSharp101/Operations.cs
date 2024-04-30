using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmin_CSharp101
{
    internal class Operations
    {
        Methods methods=new Methods();

        // creating an account
        public IAccount CreateAccount(int userChoice)
        {
            if(userChoice == 1)
            {
                return new SavingsAccount();
            }
            else if(userChoice == 2){
                Console.WriteLine("Enter initial deposit amountfor fixed deposit");
                double initialDeposit=double.Parse(Console.ReadLine());
                return new FixedDeposit(initialDeposit);
            }
            else {
                throw new ArgumentException("Invalid choice");
            }
        }

        // performing operations on the choosen account
        public void PerformOperations(IAccount account)
        {
            while (true)
            {
                Console.WriteLine("Choose operation: 1. Deposit, 2. Withdraw, 3. Exit");
                int operation= int.Parse(Console.ReadLine());

                if(operation == 1)
                {
                    Console.WriteLine("Enter amount to deposit:");
                    double amount= double.Parse(Console.ReadLine());
                    methods.Deposit(account, amount);
                }
                else if(operation == 2)
                {
                    Console.WriteLine("Enter amount to withdraw:");
                    double amount = double.Parse(Console.ReadLine());
                    methods.Withdraw(account, amount);
                }
                else if(operation == 3)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }
    }
}
