using System.Security.Principal;

namespace BankUpdate
{
    public enum MenuOption
    {
        Withdraw = 1,
        Deposit,
        Print,
        Transfer=4,
        Quit
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.balance = 1000; // Set initial balance for account1

            Account account2 = new Account();
            account2.balance = 2000; // 
            TransferHandler transferHandler = new TransferHandler();
            UserInput userInput=new UserInput();
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
                        doMethods.DoWithdraw(account);

                        break;
                    case MenuOption.Deposit:
                        doMethods.DoDeposit(account);
                        break;
                    case MenuOption.Print:                        
                        doMethods.DoPrint(account);
                        break;
                    case MenuOption.Transfer:
                        doMethods.DoTransfer(account1 , account2);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program...");
                        break;
                }
            } while (userOption != MenuOption.Quit);
        }

        

        
        





        
    }
}
