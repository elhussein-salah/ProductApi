using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductContext _context;

        public ProductsController()
        {
            _context = new ProductContext();
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Edit(int id, [FromBody] Product updatedProduct) {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            _context.SaveChanges();
            return Ok(product);
        }

    }
}
