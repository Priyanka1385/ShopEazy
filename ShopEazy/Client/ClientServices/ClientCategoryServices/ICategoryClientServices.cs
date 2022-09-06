using ShopEazy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Client.ClientServices.ClientCategoryServices
{
    public interface ICategoryClientServices
    {
        public List<Category> categories { get; set; }
        Task GetCategories();
        Task<ApplicationResponse<Category>> GetCategoriesById(int Id);
    }
}
