using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDb
{
    internal class ReadingUserOption
    {
       
        public MenuOption ReadUserOption()
        {
            int option;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Display employee record");
                Console.WriteLine("5. Display all records");
                Console.WriteLine("6. Quit");

                option = Convert.ToInt32(Console.ReadLine());
            } while (option < 0 || option > 6);

            return (MenuOption)option;
        }

    }
}
