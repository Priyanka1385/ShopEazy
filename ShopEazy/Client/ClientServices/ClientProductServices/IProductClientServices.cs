using ShopEasy.Shared.Models;

namespace ShopEazy.Client.ClientServices.ClientProductServices
{
    public interface IProductClientServices
    {
        public List<Product> Products { get; set; }
        Task GetProducts();
    }
}
