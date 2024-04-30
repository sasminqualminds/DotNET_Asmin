using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    internal class ReadUserOption
    {
        public static MenuOption ReadUserInputOption()
        {
            int selectedOption;
            MenuOption option;
            Console.WriteLine();
            // asking user to choose a option
            Console.WriteLine("Choose option \nAdd - 1\nExit -2");
            // storing the input in a variable 
            selectedOption = Convert.ToInt32(Console.ReadLine());

            if (selectedOption <= 0 || selectedOption > 6)
            {
                Console.WriteLine("Invalid input");
            }


            option = (MenuOption)selectedOption;
            // returning the choosen option
            return option;


        }
    }
}
