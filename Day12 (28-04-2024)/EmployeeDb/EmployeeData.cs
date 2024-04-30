using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDb
{
    internal class EmployeeData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        public EmployeeData(int id, string name, decimal salary, int age)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
        }

    }
}
