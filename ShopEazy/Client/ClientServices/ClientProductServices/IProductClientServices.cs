using ShopEazy.Shared.Models;
using ShopEazy.Shared;

namespace ShopEazy.Client.ClientServices.ClientProductServices
{
    public interface IProductClientServices
    {
        event Action ProductsSelectionChanged;
        public List<Product> Products { get; set; }
        string Message { get; set; }
        Task GetProducts(string CategoryUrl = null);
        Task<ApplicationResponse<Product>> GetProductById(int Id);

        Task SearchProducts(String SearchText);

        Task<List<String>> GetProductSearchSuggestions(string SearchText);

    }
}
