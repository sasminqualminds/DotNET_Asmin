using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankUpdate.Program;

namespace BankUpdate
{
    internal class ReadingUserOption
    {
        public MenuOption ReadUserOption()
        {
            int option;
            do
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. AddAccount");
                Console.WriteLine("6. Quit");

                option = Convert.ToInt32(Console.ReadLine());
            } while (option < 0 || option > 6);

            return (MenuOption)option;
        }
    }
}
