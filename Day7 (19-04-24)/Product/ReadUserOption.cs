using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class ReadUserOption
    {
        // creating a method whose return type is MenuOption
        public static MenuOption ReadUserInputOption()
        {
            int selectedOption;
            MenuOption option;
            Console.WriteLine();
            // asking user to choose a option
            Console.WriteLine("Choose option \nAdd Product - 1\nDelete Product - 2\nUpdate Product - 3\nList Product - 4\nList All Products - 5\nExit -6");
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
