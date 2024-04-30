using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class ReadUserOption
    {
        // creating a method whose return type is MenuOption
        public static MenuOption ReadUserInputOption()
        {
            int selectedOption;
            MenuOption option;
            Console.WriteLine();
            // asking user to choose a option
            Console.WriteLine("Choose option \nAdd Employee - 1\nDelete Employee - 2\nUpdate Employee - 3\nList Employee - 4\nList All Employees - 5\nExit -6");
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
