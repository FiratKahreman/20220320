using _02_HttpMethods.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02_HttpMethods.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(ProductContext.Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product product = ProductContext.Products.Find(a => a.Id == id);
            return Ok(product);
        }


        [HttpPost] // idempotent değildir
        public IActionResult AddProduct(Product product)
        {
            ProductContext.Products.Add(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Product product = ProductContext.Products.Find(a => a.Id == id);
            ProductContext.Products.Remove(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            Product updated = ProductContext.Products.Find(a => a.Id == product.Id);
            updated.Name = product.Name;
            updated.Price = product.Price;
            updated.Stock = product.Stock;
            return Ok();
        }

        [HttpPatch]
        [ActionName("UpdateProduct")]
        public IActionResult PartialUpdateProduct(Product product/*, int id*/)
        {
            Product updated = ProductContext.Products.Find(a => a.Id == product.Id);
            updated.Name = product.Name;
            return Ok();
        }

    }
}
