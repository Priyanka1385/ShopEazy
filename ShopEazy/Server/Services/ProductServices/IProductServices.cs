using ShopEazy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Server.Services.ProductServices
{
    public interface IProductServices
    {
        public Task<ApplicationResponse<List<Product>>> GetProduct();
        public Task<ApplicationResponse<Product>> GetProductById(int id);
        public Task<ApplicationResponse<List<Product>>> GetProductsByCategory(string CategoryUrl);
        public Task<ApplicationResponse<List<Product>>> SearchProducts(string SearchText);
        public Task<ApplicationResponse<List<String>>> GetProductSearchSuggestions(string SearchText);
        public Task<ApplicationResponse<List<Product>>> GetFeaturedProducts();
    }
}
