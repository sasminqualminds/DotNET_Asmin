using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRUD.Program;

namespace CRUD
{
    internal class ReadingUserOption
    {
        public MenuOption ReadUserOption()
        {
            int option;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Read");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Quit");

                option = Convert.ToInt32(Console.ReadLine());
            } while (option < 0 || option > 5);

            return (MenuOption)option;
        }
    }
}
