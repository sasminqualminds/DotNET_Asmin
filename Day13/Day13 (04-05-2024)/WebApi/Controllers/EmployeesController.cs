using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        List<Employee> employees = new List<Employee>();
        private List<Employee> getAllEmployees()
        {

            Employee employee1 = new Employee() { Id = 1, Name = "Jack", Age = 10 };
            Employee employee2 = new Employee() { Id = 2, Name = "Jim", Age = 20 };
            Employee employee3 = new Employee() { Id = 3, Name = "Alex", Age = 30 };
            Employee employee4 = new Employee() { Id = 4, Name = "Jam", Age = 40 };
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            return employees;
        }

        [HttpGet(Name = "GetEmployeeData")]
        public IEnumerable<Employee> Get()
        {
            return getAllEmployees();
        }

    }
}
