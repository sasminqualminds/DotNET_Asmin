using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    // Adding of two numbers and displaying the output
    internal class Sample3
    {
        static void Main(string[] args)
        {
            // Declaring 3 variables
            int firstNumber, secondNumber, result;

            // User is asked to enter first number
            Console.WriteLine("Enter your FirstNumber:");
            // the input entered will be converted into integer datatype and
            // gets stored in the variable firstNumber
            firstNumber = Convert.ToInt32(Console.ReadLine());

            // user is asked to enter second number
            Console.WriteLine("Enter SecondNumber:");
            // the input entered will be converted into integer datatype and
            // gets stored in the variable secondNumber
            secondNumber = Convert.ToInt32(Console.ReadLine());

            // sum of firstNumber and secondNumber will be stored in the variable result
            result = firstNumber + secondNumber;

            // displaying the output on the screen
            //  Console.WriteLine("Addition of first number " + firstNumber + " and second number " + secondNumber + " is " + result);
            Console.WriteLine("Sum of : {0} and {1} is {2}", firstNumber,secondNumber,result);
            Console.ReadKey();
        }
    }
}
