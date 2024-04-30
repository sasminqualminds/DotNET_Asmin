using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Operations
    {

        public void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Addtion of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber + secondNumber);

        }
        public void Subtraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine("Subtraction of {0} and {1} is {2}", firstNumber, secondNumber, firstNumber - secondNumber);

        }
        
    }
}
