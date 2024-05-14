using CPDetails.Data;
using CPDetails.Modeel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CPDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly PrjContext _dbContext;
        public PurchaseController(PrjContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetCustomerProductInfos()
        {
            var customerProductInfos = new List<Common>();
            var customerProducts = _dbContext.Purchases.ToList();
            var customers = _dbContext.Customers.ToList();
            var products = _dbContext.Products.ToList();
            foreach (var customer in customers)
            {
                var customerProductsForCurrentCustomer = customerProducts.Where(cp => cp.CustomerId == customer.Id);

                var customerProductInfo = new Common
                {
                    CustomerName = customer.CustomerName,
                    CustomerId = customer.Id,

                };
                foreach (var costumerProduct in customerProductsForCurrentCustomer)
                {
                    var product = products.Find(p => p.Id == costumerProduct.ProductId);

                    if (product != null)
                    {
                        customerProductInfo.products.Add(product);
                    }
                }
                customerProductInfos.Add(customerProductInfo);
            }

            return Ok(customerProductInfos);
        }



        [HttpPost("/purchases")]

        public string purchase(Purchase purchase)
        {
            
            
            _dbContext.Purchases.Add(purchase);
            _dbContext.SaveChanges();
            return "added";
        }

        [HttpDelete("{id}")]

        public void delete(int id)
        {
            foreach (Purchase purchase in _dbContext.Purchases)
            {
                if (purchase.Id == id)
                {
                    _dbContext.Remove(purchase);
                    
                }
            }
            _dbContext.SaveChanges();

        }

        [HttpPut("{id}")]
        public string update(Purchase purchase)
        {
            foreach(Purchase purchase1 in _dbContext.Purchases)
            {
                if(purchase1.Id == purchase.Id)
                {
                    _dbContext.Update(purchase1);
                }
            }
            _dbContext.SaveChanges();
            return "updated";
        }
    }
}
