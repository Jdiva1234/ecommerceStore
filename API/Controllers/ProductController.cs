// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using API.Data;
// using API.Entities;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
 
// namespace API.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class ProductsController:ControllerBase
//     {
//         private readonly StoreContext context;
//         public ProductsController(StoreContext context)
//         {
//             this.context=context;
 
//         }
   
//         [HttpGet]
//         public async Task<ActionResult<List<Product>>> GetProducts()
//         {
//             return await context.Products.ToList();
//         }
 
//         // [HttpGet]
//         // public ActionResult<List<Product>> GetProducts(){
//         //     var products=context.Products.ToList();
//         //     return Ok(products);
//         // }
//         [HttpGet("{id}")]   
//         public ActionResult<Product> GetProduct(int id){
//             return context.Products.Find(id);
//         }
//     }
// } 
