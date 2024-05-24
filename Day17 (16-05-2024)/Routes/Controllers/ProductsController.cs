using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Routes.Model;

namespace Routes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product1", Price = 10.0m },
            new Product { Id = 2, Name = "Product2", Price = 20.0m }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(products);
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // GET: api/products/search?name={name}
        [HttpGet("search")]
        public ActionResult<IEnumerable<Product>> SearchProducts(string name)
        {
            var matchedProducts = products.Where(p => p.Name.Contains(name, System.StringComparison.OrdinalIgnoreCase)).ToList();
            if (!matchedProducts.Any())
            {
                return NotFound();
            }
            return Ok(matchedProducts);
        }



        // POST: api/products
        [HttpPost]
        public ActionResult<Product> CreateProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            product.Id = products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // POST: api/products/bulk
        [HttpPost("bulk")]
        public ActionResult<IEnumerable<Product>> CreateProducts([FromBody] List<Product> newProducts)
        {
            if (newProducts == null || !newProducts.Any())
            {
                return BadRequest();
            }

            foreach (var product in newProducts)
            {
                product.Id = products.Count > 0 ? products.Max(p => p.Id) + 1 : 1;
                products.Add(product);
            }
            return Ok(newProducts);
        }
    }
}
