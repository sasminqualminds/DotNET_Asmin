using System.Collections;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DoMethods<int> doMethods = new DoMethods<int>();
            DoMethods<string> doMethods = new DoMethods<string>();
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
                    case MenuOption.Delete:
                        Console.WriteLine();
                        doMethods.DoRemove();
                        break;
                    case MenuOption.Update:
                        doMethods.DoUpdate();
                        Console.WriteLine();

                        break;
                    case MenuOption.ListProduct:
                        doMethods.DoListProduct();
                        Console.WriteLine();
                        break;
                    case MenuOption.ListAllProducts:
                        doMethods.DoListAllProducts();
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







