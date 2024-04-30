using System.Security.Principal;

namespace EmployeeDb
{
    public enum MenuOption
    {
        Add = 1,
        Delete,
        Update,
        DisplayRecord,
        DisplayAllRecords,
        Quit,
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            EmployeeHelper studentHelper = new EmployeeHelper();            
            ReadingUserOption readingUserOption = new ReadingUserOption();  
            DoMethods doMethods = new DoMethods();
            MenuOption userOption;
            do
            {
                userOption = readingUserOption.ReadUserOption();

                switch (userOption)
                {
                    case MenuOption.Add:

                        doMethods.doAdd();
                        break;
                    case MenuOption.Delete:
                        doMethods.doDelete();
                        break;
                    case MenuOption.Update:
                        doMethods.doUpdateRecord();
                        break;
                    case MenuOption.DisplayRecord:
                        doMethods.doDisplayRecord();
                        break;
                    case MenuOption.DisplayAllRecords:
                        doMethods.doDisplayAllRecords();
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program...");
                        break;
                }
            } while (userOption != MenuOption.Quit);            
            Console.ReadKey();
        }
    }
}
