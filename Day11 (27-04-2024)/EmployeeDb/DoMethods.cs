using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDb
{
    internal class DoMethods
    {
        EmployeeData employee = new EmployeeData();
        EmployeeHelper employeeHelper=new EmployeeHelper();

       
        public void doAdd()
        {
            Console.WriteLine("Enter Id");
            employee.Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            employee.Name=Console.ReadLine();
            Console.WriteLine("Enter salary");
            employee.Salary=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter age");
            employee.Age=Convert.ToInt32(Console.ReadLine());
            employeeHelper.addEmployeeRecord(employee);
        }

        public void doDelete()
        {
            Console.WriteLine(" Enter Id to delete record");
            int id=Convert.ToInt32(Console.ReadLine());
            employeeHelper.deleteEmployeeRecord(id);
        }

        public void doDisplayRecord()
        {
            Console.WriteLine("Enter Id to display record");
            int id= Convert.ToInt32(Console.ReadLine());
            employeeHelper.DisplayEmployeeRecord(id);
        }

        public void doDisplayAllRecords()
        {
            employeeHelper.displayAllRecords();
        }

        public void doUpdateRecord()
        {
            Console.WriteLine("Enter Id to update record");
            int id = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("Enter name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            employee.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter age");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            employeeHelper.updateEmployeeRecord(id,employee);
        }
    }
}
