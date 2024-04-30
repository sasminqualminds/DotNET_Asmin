using System.Collections;

namespace Employee
{
    public class Program
    {
       
        static void Main(string[] args)
        { 
            
                      
            //operations.defaultValues();
            DoMethods doMethods=new DoMethods();
            bool exit = false;
             
            while (!exit)
            {
                MenuOption userinput = ReadUserOption.ReadUserInputOption();

                switch (userinput)
                {
                    case MenuOption.Add:                        
                        doMethods.doAdd();
                        Console.WriteLine();
                        break;
                    case MenuOption.Delete:
                        Console.WriteLine();                       
                        doMethods.doRemove();
                        break;
                    case MenuOption.Update:                       
                        doMethods.doUpdate();
                        Console.WriteLine();

                        break;
                    case MenuOption.List:                                               
                        doMethods.doListEmployee();                       
                        Console.WriteLine();
                        break;
                    case MenuOption.ListAllEmployees:                       
                        doMethods.doListAllEmployees();
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
