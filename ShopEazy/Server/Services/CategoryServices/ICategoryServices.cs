using ShopEasy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Server.Services.CategoryServices
{
    public interface ICategoryServices
    {
        public Task<ApplicationResponse<List<Category>>> GetCategories();
        public Task<ApplicationResponse<Category>> GetCategoriesById(int id);
    }
}
