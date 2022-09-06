using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopEazy.Shared.Models;
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

        [HttpGet("category/{CategoryUrl}")]

        public async Task<ActionResult<ApplicationResponse<List<Product>>>> GetProductsByCategory(String CategoryUrl)
        {
            var response = await _productServices.GetProductsByCategory(CategoryUrl);
            return Ok(response);

        }
        [HttpGet("search/{SearchText}")] //https://localhost:44332/api/product/search/{searchtext}
        public async Task<ActionResult<ApplicationResponse<List<Product>>>> SearchProducts(String SearchText)
        {
            var response = await _productServices.SearchProducts(SearchText);
            return Ok(response);

        }

        [HttpGet("searchSuggestions/{SearchText}")] //https://localhost:44332/api/product/searchSuggestions/{searchtext}
        public async Task<ActionResult<ApplicationResponse<List<String>>>> GetProductSearchSuggestions(String SearchText)
        {
            var response = await _productServices.GetProductSearchSuggestions(SearchText);
            return Ok(response);

        }
    }
}
