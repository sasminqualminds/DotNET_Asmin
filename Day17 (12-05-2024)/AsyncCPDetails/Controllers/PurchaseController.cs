using AsyncCPDetails.Data;
using AsyncCPDetails.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AsyncCPDetails.Controllers
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
        public async Task<IActionResult> GetCustomerProductInfos()
        {
            var customerProductInfos = new List<Common>();
            var customerProducts = await _dbContext.Purchases.ToListAsync();
            var customers = await _dbContext.Customers.ToListAsync();
            var products = await _dbContext.Products.ToListAsync();

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


        [HttpGet("{id}")]
        public async Task<ActionResult<Purchase>> GetPurchase(int id)
        {
            if (_dbContext.Purchases == null)
            {
                return NotFound(); // 404 - preferred to return results in HTTP codes
            }
            var purchase = await _dbContext.Purchases.FindAsync(id);

            if (purchase == null)
            {
                return NotFound();
            }

            return purchase;
        }

        [HttpPost]
        public async Task<ActionResult<Purchase>> PostProduct(Purchase purchase)
        {
            _dbContext.Purchases.Add(purchase);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPurchase), new { id = purchase.Id }, purchase); // 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, Purchase purchase)
        {
            if (id != purchase.Id)
            {
                return BadRequest();
            }
            _dbContext.Entry(purchase).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchase(int id)
        {
            if (_dbContext.Purchases == null)
            {
                return NotFound();
            }

            var purchase = await _dbContext.Purchases.FindAsync(id);
            if (purchase == null)
            {
                return NotFound();
            }

            _dbContext.Purchases.Remove(purchase);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseExists(long id)
        {
            return (_dbContext.Purchases?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

