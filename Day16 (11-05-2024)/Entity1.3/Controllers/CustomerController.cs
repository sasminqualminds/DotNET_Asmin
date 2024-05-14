using Entity.Data;
using Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        PrjContext context;
        public CustomerController(PrjContext prjContext)
        {
            context = prjContext;
        }

        [HttpGet]
        public List<Customer> Get()
        {
            return context.Customers.ToList<Customer>();
        }

        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer Record Created Successfully";
        }

        [HttpPut]
        public string Put([FromBody] Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return "Customer record updates succesfully";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            var customerToDelete = context.Customers.Find(id);
            if (customerToDelete != null)
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                return "Customer record deleted successfully";
            }
            else
            {
                return "Customer not found";
            }
        }
    }
}
