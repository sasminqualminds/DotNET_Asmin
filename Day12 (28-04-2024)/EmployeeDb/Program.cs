using System.Data;
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
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Employee;Integrated Security=True;Pooling=False";
            EmployeeHelper employeeHelper = new EmployeeHelper(connectionString);
            DoMethods doMethods = new DoMethods(employeeHelper);
            ReadingUserOption readingUserOption = new ReadingUserOption();
            MenuOption userOption;
            do
            {
                userOption = readingUserOption.ReadUserOption();

                switch (userOption)
                {
                    case MenuOption.Add:
                        doMethods.doAdd(ReadEmployeeData());
                        break;
                    case MenuOption.Delete:
                        doMethods.doDelete(ReadId());
                        break;
                    case MenuOption.Update:
                        int idToUpdate = ReadId();
                        doMethods.doUpdateRecord(idToUpdate, ReadEmployeeData());
                        break;
                    case MenuOption.DisplayRecord:
                        doMethods.doDisplayRecord(ReadId());
                        break;
                    case MenuOption.DisplayAllRecords:
                        doMethods.doDisplayAllRecords();
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program...");
                        break;
                }
            } while (userOption != MenuOption.Quit);
        }

        

        static EmployeeData ReadEmployeeData()
        {
            Console.WriteLine("Enter employee details:");
            Console.WriteLine("Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Salary:");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            return new EmployeeData(id, name, salary, age);
        }

        static int ReadId()
        {
            Console.WriteLine("Enter Id:");
            return int.Parse(Console.ReadLine());
        }


    }
    
}
