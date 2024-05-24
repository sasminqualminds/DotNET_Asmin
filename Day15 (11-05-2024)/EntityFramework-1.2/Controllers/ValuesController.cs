using EntityFramework.Controllers.Data;
using EntityFramework.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        PrjContext context;
        public ValuesController(PrjContext prjContext)
        {
            context = prjContext;
        }

        [HttpGet]
        public List<Employees> Get()
        {
            return context.Employees.ToList<Employees>();
        }

        [HttpPost]
        public string Post([FromBody] Employees employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return "Employee Record Created Successfully";
        }
    }
}
