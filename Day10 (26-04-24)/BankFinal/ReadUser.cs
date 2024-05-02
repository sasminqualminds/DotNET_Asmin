using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankFinal.Program;

namespace BankFinal
{
    internal class ReadUser
    {
        public MenuOption ReadUserOption()
        {
            int selectedOption;
            MenuOption option;
            do
            {
                Console.WriteLine("Select an option below to: \nDeposit - 1 \nWithdraw - 2 \nPrint - 3 \nTransfer - 4\nAdd Account - 5\nTransactionHistory - 6 \nQuit - 7\n");
                selectedOption = Convert.ToInt32(Console.ReadLine());

            } while (selectedOption < 0 || selectedOption > 7);

           option=(MenuOption)selectedOption;
            return option;

        }
    }
}
