namespace Asmin_CSharp101
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            
            //Asking user to choose the type of account
            Console.WriteLine("choose account type: 1. Savings Account, 2. Fixed Deposit");
            int userChoice=int.Parse(Console.ReadLine());
            
            // Creating an account and performing operations on the choosen account type
            IAccount account=operations.CreateAccount(userChoice);
            operations.PerformOperations(account);
         }
    }
}
