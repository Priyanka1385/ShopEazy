using ShopEasy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Server.Services.ProductServices
{
    public interface IProductServices
    {
        public Task<ApplicationResponse<List<Product>>> GetProduct();
        public Task<ApplicationResponse<Product>> GetProductById(int id);
    }
}
