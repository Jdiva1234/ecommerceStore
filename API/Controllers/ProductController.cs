
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data; // Add this line to include the namespace where StoreContext is defined

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;
        public ProductsController(StoreContext context)
        {
        this.context = context;
        }
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        { 
            var products = context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public ActionResult<Product>GetProduct(int id)
        {
            return context.Products.Find(id);
        }

    }
}