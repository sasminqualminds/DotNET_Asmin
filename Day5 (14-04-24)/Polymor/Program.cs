namespace Polymor
{
    internal class Program
    {
        public static void Main()
        {
           
            Bank bank = new Bank();
            Account savingsAccount = new SavingsAccount();
            Account currentAccount = new CurrentAccount();

            
            bank.PerformTransaction(savingsAccount, 100.00);
            bank.PerformTransaction(currentAccount, -50.00);
        }
    }
    
}
