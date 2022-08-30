using ShopEasy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Client.ClientServices.ClientProductServices
{
    public interface IProductClientServices
    {
        public List<Product> Products { get; set; }
        Task GetProducts();
        Task<ApplicationResponse<Product>> GetProductById(int Id);
    }
}
