using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDb
{
    internal class EmployeeData
    {
        int id;
        string name;
        decimal salary;
        int age;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Salary { get {  return salary; } set {  salary = value; } }
        public int Age { get { return age; } set { age = value; } }
        
    }
}
