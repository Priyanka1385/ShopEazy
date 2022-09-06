using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopEazy.Shared.Models;
using ShopEazy.Server.Services.CategoryServices;
using ShopEazy.Shared;

namespace ShopEazy.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        [HttpGet]
        public async Task<ActionResult<ApplicationResponse<List<Category>>>> GetCategories()
        {
            var response = await _categoryServices.GetCategories();
            return Ok(response);
        }
    }
}
