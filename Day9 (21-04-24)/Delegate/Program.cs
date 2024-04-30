using Delegate;

namespace Delegate
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            //Operations operationObj = new Operations();

            //ArithmeticHandler arithObj1, arithObj2, arithObj3;
            DoMethods doMethods = new DoMethods();
            //Console.WriteLine("Enter your first num");
            //int a2 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int b2 = Convert.ToInt16(Console.ReadLine());





            //arithObj3 = arithObj1 + arithObj2;

            //arithObj1(2, 3);

            //arithObj2(3, 2);

            //arithObj3(6, 4);

            //Console.ReadKey();



            bool exit = false;

            while (!exit)
            {
                MenuOption userinput = ReadUserOption.ReadUserInputOption();

                switch (userinput)
                {
                    case MenuOption.Add:
                        doMethods.addition();
                        Console.WriteLine();
                        break;
                    case MenuOption.Subtract:
                        doMethods.subtraction();
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

