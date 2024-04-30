using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Sample4
    {
        // storing and displaying the details of a person using different data types
        static void Main(string[] args)
        {
            // declaring datatypes for each variable and assigning the values to it
            string name = "Jackie";           // stores text
            char bloodGroup = 'O';            // stores characters
            bool isEmployed = true;           // either true or false, either 1 or 0


            int employeeId = 714709;          // stores integers - 32 bit
            uint annualIncome = 50000;        // unsigned int - 32bit
            short monthlySalary = 2500;       // signed integer - 16bit
            ushort daysInMonth = 30;          // unsigned integer - 16bit
            long phoneNumber = 1234567890;    // Signed 64-bit integer
            ulong totalSavings = 1000000000;  // Unsigned 64-bit integer

            float height = 5.8F;              // stores floating point value - 4bytes
            double weight = 170.5;            //  8 bytes
            decimal bankBalance = 2500.75M;   // 16 bytes

            byte age = 25;                    // store unsigned byte data (0 to 255)
            sbyte score = -128;               // stores both +ve and -ve (-1288 to 127)


            // displaying the details on the screen
            Console.WriteLine("Employee Information:\nIs Employed: {0}\nAge: {1}\nscore: {2}\nMonthly Salary: {3}\nDays in a Month: {4}\nEmployee ID: {5}\nAnnual Income: {6}\nPhone Number: {7}\nTotal Savings: {8}\nHeight: {9}\nWeight: {10}\nBank Balance: {11}\nBlood Group: {12}\nName: {13}",
    isEmployed, age, score, monthlySalary, daysInMonth, employeeId, annualIncome, phoneNumber, totalSavings, height, weight, bankBalance, bloodGroup, name);


            // Console.WriteLine("Id number is : {0}", id);
            // Console.WriteLine("Name of the person : {0}", name);
            // Console.WriteLine("Age : " + age);
            // Console.WriteLine("Gender : " + gender);
            // Console.ReadKey();
        }
    }
}

