namespace BankFinal
{
    internal class Program
    {
        public enum MenuOption
        {
            Deposit=1,
            Withdraw,
            Print,
            Transfer,
            AddAccount,
            TransactionHistory,
            Exit,
        }
       

        static void Main(string[] args)
        {
            Account account = new Account();
            Account account1 = new Account();
            Bank bank = new Bank();
            
            ReadUser readUser = new ReadUser();
            MenuOption choice;
            DoMethods doMethods = new DoMethods();

            do
            {
                choice=readUser.ReadUserOption();
                switch (choice)
                {
                    case MenuOption.Deposit:
                        Console.WriteLine("Selected Deposit");
                        doMethods.DoDeposit(bank);
                        break;
                    case MenuOption.Withdraw:
                        Console.WriteLine("Selected Withdraw");
                        doMethods.DoWithdraw(bank);
                        break;
                    case MenuOption.Print:
                        Console.WriteLine("Selected to print");
                        doMethods.DoPrint(bank);
                        break;
                    case MenuOption.Transfer:
                        Console.WriteLine("selected to transfer");
                        doMethods.DoTransfer(bank);
                        break;
                    case MenuOption.AddAccount:
                        Console.WriteLine("Selected to Add Account");
                        doMethods.DoAddAccount(bank);
                        break;
                    case MenuOption.TransactionHistory:
                        Console.WriteLine("Selected to print TransactionHistory");
                        doMethods.DoPrintTransactionHistory(bank);
                        break;
                    case MenuOption.Exit:

                        Console.WriteLine("Exiting....");
                        break;
                    
                }
            } while (choice!=MenuOption.Exit);
            
            
        }

    }
}
