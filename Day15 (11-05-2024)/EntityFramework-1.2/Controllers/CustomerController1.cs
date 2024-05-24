using EntityFramework.Controllers.Data;
using EntityFramework.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController1 : ControllerBase
    {
        PrjContext context;
        public CustomerController1(PrjContext prjContext)
        {
            context = prjContext;
        }

        [HttpGet]
        public List<Customers> Get()
        {
            return context.Customers.ToList<Customers>();
        }

        [HttpPost]
        public string Post([FromBody] Customers customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer Record Created Successfully";
        }
    }
}
