using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Sample2
    {
        // stores and displays the details of a person
        static void Main(string[] args)
        {
            // declaring datatypes for each variable and assigning the values to it
            int id = 714709;
            string name = "Jack";
            byte age = 25;
            char gender = 'M';
            float percent = 60.40F;

            // displaying the details on the screen
            Console.WriteLine("Id number is : {0}", id);
            Console.WriteLine("Name of the person : {0}", name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0:F}", percent);
            Console.ReadKey();
        }
    }
}
