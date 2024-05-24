using AsyncCPDetails.Data;
using AsyncCPDetails.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsyncCPDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly PrjContext _dbContext;
        public CustomerController(PrjContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("/customer")]
        public string customerDetails(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return "added";

        }

        [HttpGet("/cuustomers")]

        public List<Customer> GetAll()
        {
            return _dbContext.Customers.ToList();
        }

        [HttpDelete("{id}")]

        public void delete(int id)
        {
            foreach (Customer customer in _dbContext.Customers)
            {
                if (customer.Id == id)
                {
                    _dbContext.Remove(customer);
                }

            }
            _dbContext.SaveChanges();
        }
    }
}
