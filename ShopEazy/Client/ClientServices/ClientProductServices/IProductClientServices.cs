using ShopEasy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Client.ClientServices.ClientProductServices
{
    public interface IProductClientServices
    {
        event Action ProductsSelectionChanged;
        public List<Product> Products { get; set; }
        Task GetProducts(string CategoryUrl=null);
        Task<ApplicationResponse<Product>> GetProductById(int Id);
    }
}
