using Microsoft.AspNetCore.Mvc;
using MVC1._2.Models;

namespace MVC1._2.Controllers
{
    public class EmployeeController : Controller
    {


        private List<Employee> getEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee() { EmployeeId=1,EmployeeName="Jack", EmployeeAge=20,EmployeeSalary=20000};
            Employee employee2 = new Employee() { EmployeeId = 2, EmployeeName = "Jim", EmployeeAge = 22, EmployeeSalary = 25000 };
            Employee employee3 = new Employee() { EmployeeId = 3, EmployeeName = "Alex", EmployeeAge = 25, EmployeeSalary = 30000 };
            Employee employee4 = new Employee() { EmployeeId = 4, EmployeeName = "Jhonny", EmployeeAge = 30, EmployeeSalary = 35000 };
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            return employees;
        }

        // using viewBag - weak type
        public ViewResult viewDisplay()
        {
            ViewBag.Employees = getEmployees();
            return View();
        }

        // strong type
        public ViewResult viewDisplayList()
        {
            List<Employee> listEmployees = getEmployees();
            return View(listEmployees);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
