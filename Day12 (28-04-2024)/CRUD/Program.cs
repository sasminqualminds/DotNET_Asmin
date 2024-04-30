using System.ComponentModel.Design;

namespace CRUD
{
    internal class Program
    {
        public enum MenuOption
        {
            Read = 1,
            Add,
            Update,
            Delete,
            Quit,
        }
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
                    case MenuOption.Read:

                        doMethods.doRead();
                        break;
                    case MenuOption.Add:
                        doMethods.doAdd();
                        break;
                    case MenuOption.Update:
                        doMethods.doUpdate();
                        break;
                    case MenuOption.Delete:
                        doMethods.doDelete();
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
