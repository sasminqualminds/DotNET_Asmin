using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>();

        static EmployeesController()
        {
            employees.Add(new Employee() { Id = 1, Name = "Jack", Age = 10 });
            employees.Add(new Employee() { Id = 2, Name = "Jim", Age = 20 });
            employees.Add(new Employee() { Id = 3, Name = "Alex", Age = 30 });
            employees.Add(new Employee() { Id = 4, Name = "Jam", Age = 40 });
        }

        // Reading the data using GET request
        [HttpGet(Name = "GetEmployeeData")]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // Reading the data by Id using GET request
        [HttpGet("{id}")]
        public Employee GetEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        // Adding the data using POST request
        [HttpPost]
        public ContentResult AddEmployee()
        {
            Employee employee = new Employee() { Id = 5, Name = "Jenny", Age = 10 };
            // Checking if an employee with the same ID already exists
            foreach(Employee emp in employees)
            {
                if (emp.Id==employee.Id)
                {
                    return Content("Employee with the same ID already exists.");
                }
            }           
            // Adding the new employee to the list
            employees.Add(employee);
            return Content("Employee Added");
        }

        // Deleting the data using DELETE request
        [HttpDelete("{id}")]
        public ContentResult DeleteEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    employees.Remove(emp);
                    return Content("removed Successfully");
                }
            }
            return Content($"Employee with id {id} not found");
        }

        // Updating the data using PUT request
        [HttpPut("{id}")]
        public ContentResult UpdateEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    emp.Name="Updated";
                    emp.Age=20;
                    emp.Salary = 20000000;
                    return Content("Updated successfully");
                }
            }
            return Content($"Employee with id {id} not found");
        }
    }
}
