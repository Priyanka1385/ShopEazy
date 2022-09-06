using Microsoft.EntityFrameworkCore;
using ShopEazy.Shared.Models;
using ShopEazy.Server.Data;
using ShopEazy.Shared;

namespace ShopEazy.Server.Services.CategoryServices
{
    public class CategoryServices : ICategoryServices
    {
        private readonly DataContext _context;

        public CategoryServices(DataContext context)
        {
            _context = context;
        }

        public async Task<ApplicationResponse<List<Category>>> GetCategories()
        {
            ApplicationResponse<List<Category>> response = new ApplicationResponse<List<Category>>();
            var categories = await _context.Categories.ToListAsync();
            response.Data = categories;
            response.Message = "List of Categories";

            return response;
        }

        public Task<ApplicationResponse<Category>> GetCategoriesById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
