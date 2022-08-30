using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopEasy.Shared.Models;
using ShopEazy.Server.Data;
using ShopEazy.Server.Services.ProductServices;
using ShopEazy.Shared;

namespace ShopEazy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
       
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<ActionResult<ApplicationResponse<List<Product>>>> GetProducts()
        {
            var response = await _productServices.GetProduct();
            return Ok(response);
        }
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<ApplicationResponse<Product>>> GetProductById(int Id)
        {
            var response = await _productServices.GetProductById(Id);
            return Ok(response);
        }
    }
}
