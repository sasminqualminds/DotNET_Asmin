using System.Security.Principal;

namespace BankUpdate
{
    public enum MenuOption
    {
        Withdraw = 1,
        Deposit,
        Print,
        Transfer=4,
        NewAccount,
        Quit
    }
    internal class Program
    {
        


        static void Main(string[] args)
        {
            Bank bank = new Bank();
            

            Account account = new Account();
            ReadingUserOption readingUserOption = new ReadingUserOption();
            DoMethods doMethods = new DoMethods();
            MenuOption userOption;
            
            do
            {
                userOption = readingUserOption.ReadUserOption();

                switch (userOption)
                {
                    case MenuOption.Withdraw:
                        doMethods.DoWithdraw(bank);

                        break;
                    case MenuOption.Deposit:
                        doMethods.DoDeposit(bank);
                        break;
                    case MenuOption.Print:                        
                        doMethods.DoPrint(bank);
                        break;
                    case MenuOption.Transfer:
                        doMethods.DoTransfer(bank);
                        break;
                    case MenuOption.NewAccount:
                        doMethods.CreateNewAccount(bank);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program...");
                        break;
                }
            } while (userOption != MenuOption.Quit);
            
        }

        

        
        





        
    }
}
