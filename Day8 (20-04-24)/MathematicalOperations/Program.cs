namespace MathematicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoMethods<int> doMethods = new DoMethods<int>();
           // DoMethods<string> doMethods1 = new DoMethods<string>();

            bool exit = false;

            while (!exit)
            {
                MenuOption userinput = ReadUserOption.ReadUserInputOption();

                switch (userinput)
                {
                    case MenuOption.Add:
                        doMethods.DoAdd();
                        Console.WriteLine();
                        break;
                    
                    case MenuOption.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

            
                
    }
}
