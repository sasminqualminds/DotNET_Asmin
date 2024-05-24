using AsyncCPDetails.Data;
using AsyncCPDetails.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsyncCPDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly PrjContext _dbContext;
        public ProductController(PrjContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("/product")]
        public string productDetails(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return "added";

        }

        [HttpGet("/products")]
        public List<Product> products()
        {
            return _dbContext.Products.ToList();
        }

        [HttpDelete("{id}")]

        public void delete(int id)
        {
            foreach (Product product in _dbContext.Products)
            {
                if (product.Id == id)
                {
                    _dbContext.Remove(product);
                }
            }
            _dbContext.SaveChanges();
        }
    }
}
