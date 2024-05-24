﻿using Entity.Data;
using Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        PrjContext context;
        public EmployeeController(PrjContext prjContext)
        {
            context = prjContext;
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return context.Employees.ToList<Employee>();
        }

        [HttpPost]
        public string Post([FromBody] Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return "Employee Record Created Successfully";
        }

        [HttpPut]
        public string Put([FromBody] Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
            return "Employee record updates succesfully";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            var employeeToDelete = context.Employees.Find(id);
            if (employeeToDelete != null)
            {
                context.Employees.Remove(employeeToDelete);
                context.SaveChanges();
                return "Employee record deleted successfully";
            }
            else
            {
                return "Employee not found";
            }
        }
    }

}
