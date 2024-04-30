using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    
    internal class EmployeeOperations
    {
        
        private List<Employee> empList = new List<Employee>();


        /*  ------------------- adding an employee  -----------------------*/
        public void add(Employee employee)
        {
            bool idExists = false;
            foreach (Employee emp in empList)
            {
                if (emp.EmpId == employee.EmpId)
                {
                    idExists = true;
                    break; 
                }
            }
            if (idExists)
            {
                Console.WriteLine("ID is already present. Please enter another ID.");
                return; // Exit the method without adding the employee
            }
            empList.Add(employee);
            Console.WriteLine("Employee added successfully.");
        }

        /*  -------------------- removing an employee based on employee id  ---------------------*/
        public void delete(Employee employee)
        {
            Employee empToRemove = empList.Find(emp => emp.EmpId == employee.EmpId);
            if (empToRemove != null)
            {
                empList.Remove(empToRemove);
                Console.WriteLine("Employee removed successfully.");

            }
            else
            {
                Console.WriteLine("Employee with ID " + employee.EmpId + " not found.");
            }
        }

        /*  --------------- Employee details based on id  ------------------*/

        public void listEmployee(Employee employee)
        {
            Employee empToDisplay = empList.Find(emp => emp.EmpId == employee.EmpId);
            if (empToDisplay != null)
            {
                Console.WriteLine("Employee details:");
                Console.WriteLine("Name: " + empToDisplay.EmpName);
                Console.WriteLine("ID: " + empToDisplay.EmpId);
                Console.WriteLine("Address: " + empToDisplay.EmpAddress);
                Console.WriteLine("Salary: " + empToDisplay.EmpSalary);
            }
            else
            {
                Console.WriteLine("Employee with ID " + employee.EmpId + " not found.");
            }

        }

        /*--------------  listing all employee deatils  ------------------*/


        public void listAllEmployee()
        {
            if (empList.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            // Iterate through each employee in the list and display their information
            foreach (Employee emp in empList)
            {
                Console.WriteLine($"Employee ID: {emp.EmpId}, Name: {emp.EmpName}, Address: {emp.EmpAddress}, Salary: {emp.EmpSalary}");
            }
        }


        /*------------- Updating Employee Details based on Id from user  ------------------*/
        public void update(Employee employee)
        {

            Employee empToUpdate = empList.Find(emp => emp.EmpId == employee.EmpId);
            if (empToUpdate != null)
            {
                empToUpdate.EmpName = employee.EmpName;
                empToUpdate.EmpAddress = employee.EmpAddress;
                empToUpdate.EmpSalary = employee.EmpSalary;
                Console.WriteLine("Employee updated successfully.");

            }
            else
            {
                Console.WriteLine("Employee with ID " + employee.EmpId + " not found.");
            }
        }
    }



        
}










