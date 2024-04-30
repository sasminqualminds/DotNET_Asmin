using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    // creating an Employee class
    internal class Employee
    {
       
        // properties
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public decimal EmpSalary { get; set; }


        //public override string ToString()
        //{
        //    Console.WriteLine();
        //    return $"Employee name:{EmpName} \nEmployee id: {EmpId} \nEmployee address: {EmpAddress} \nEmployee salary:{EmpSalary}";
        //}




    }
}
