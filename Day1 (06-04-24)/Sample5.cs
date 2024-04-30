using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    /// <summary>
    /// Takes input name, id, baseSalary, hra,pf,da,sa,ca,ma from user
    /// and displays Salary details as output
    /// </summary>

    internal class Sample5
    {
        static void Main(string[] args)
        {
            // User is asked to enter  the details

            Console.WriteLine("Enter your employee ID:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your basicSalary:");
            double basicSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter House Rent Allowance (HRA) amount:");
            double hra = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Dearness Allowance (DA):");
            double da = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Provident Fund (PF) amount:");
            double pf = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Medical Allowance(MA) amount:");
            double ma = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Conveyance Allowance (CA) amount:");
            double ca = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Special Allowance (CA) amount:");
            double sa = double.Parse(Console.ReadLine());


            // calculates totalSalary based on baseSalary, allowances
            double totalSalary = basicSalary + hra + ma + ca+ da+sa - pf;

            // display the salary details 
            Console.WriteLine("\nSalary details for employee:\nID: {0}\nName: {1}\nBasic Salary: {2}\nHRA: {3}\nPF: {4}\nMA: {5}\nSA: {6}\nDA: {7}\nTotal Salary: {8}",
                    id, name, basicSalary, hra, pf, ma, sa,da, totalSalary);

        }
    }
}
