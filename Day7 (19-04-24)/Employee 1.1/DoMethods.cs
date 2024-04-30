using Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class DoMethods

    {

        EmployeeOperations operations= new EmployeeOperations();
       
        public void doAdd()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter name of the employee:");
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter ID of the employee:");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter address of the employee:");
            employee.EmpAddress = Console.ReadLine();
            Console.WriteLine("Enter salary of the employee:");
            employee.EmpSalary = Convert.ToDecimal(Console.ReadLine());

            operations.add(employee);

        }
        public void doRemove()
        {
            Console.WriteLine("Enter employee ID to delete:");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employeeToRemove = new Employee { EmpId = id };
            operations.delete(employeeToRemove);
        }
        public void doUpdate()
        {
            Console.WriteLine("Enter employee ID to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employeeToUpdate = new Employee { EmpId = id };
            Console.WriteLine("Enter the updated details:");
            Console.Write("Name: ");
            employeeToUpdate.EmpName = Console.ReadLine();
            Console.Write("Address: ");
            employeeToUpdate.EmpAddress = Console.ReadLine();
            Console.Write("Salary: ");
            employeeToUpdate.EmpSalary = Convert.ToDecimal(Console.ReadLine());

            operations.update(employeeToUpdate);
        }
        public void doListEmployee()
        {
            Console.WriteLine("Enter employee ID to view details:");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employeeToDisplay = new Employee { EmpId = id };
            operations.listEmployee(employeeToDisplay);
        }

        public void doListAllEmployees()
        {
            operations.listAllEmployee();
        }

        
    }

}


