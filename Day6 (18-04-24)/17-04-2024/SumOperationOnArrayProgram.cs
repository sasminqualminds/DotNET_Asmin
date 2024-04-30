using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SumOperationOnArrayProgram
    {
        
        public static void Main(string[] args)
        {
            // asking user to enter the size of array
            Console.WriteLine("Enter the size of an array");
            int sizeOfArray =Convert.ToInt16( Console.ReadLine());

            // specifying the size of the array
            int[] sum=new int[sizeOfArray];

            // asking the user to enter elements and storing the elements in the array
            int j = 1;
            for(int i = 0; i < sizeOfArray; i++)
            {
                Console.WriteLine("Enter element "+j);
                sum[i] =Convert.ToInt32(Console.ReadLine());
                j++;
            }

            // creating the object of the class
            SumOperationOnArrayClass arrayClass = new SumOperationOnArrayClass(sum);

            // calling the method to print that prints the sum of elements in the array
            Console.WriteLine(arrayClass.sumOfArray());


        }
    }
}
