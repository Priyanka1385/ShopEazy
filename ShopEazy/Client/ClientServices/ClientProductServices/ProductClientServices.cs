
using ShopEazy.Shared.Models;

using ShopEazy.Shared;
using System.Net.Http.Json;


namespace ShopEazy.Client.ClientServices.ClientProductServices
{
    public class ProductClientServices : IProductClientServices
    {
        private readonly HttpClient _http;

        public ProductClientServices(HttpClient http)
        {
            _http = http;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public string Message { get; set; } = "Loding Products...";

        public event Action ProductsSelectionChanged;

        public async Task<ApplicationResponse<Product>> GetProductById(int Id)
        {
            var result = await _http.GetFromJsonAsync<ApplicationResponse<Product>>($"api/Product/{Id}");
            return result;
        }

        public async Task GetProducts(string CategoryUrl = null)
        {
            var result = CategoryUrl == null ? await _http.GetFromJsonAsync<ApplicationResponse<List<Product>>>("api/Product") :
                await _http.GetFromJsonAsync<ApplicationResponse<List<Product>>>($"api/Product/category/{CategoryUrl}");

            Products = result.Data;
            ProductsSelectionChanged.Invoke();
        }

        public async Task<List<string>> GetProductSearchSuggestions(string SearchText)
        {
            var result = await _http.GetFromJsonAsync<ApplicationResponse<List<String>>>($"api/Product/searchSuggestions/{SearchText}");
            return result.Data;
        }

        public async Task SearchProducts(string SearchText)
        {
            var result = await _http.GetFromJsonAsync<ApplicationResponse<List<Product>>>($"api/Product/search/{SearchText}");
            Products = result.Data;
            if (Products.Count == 0)
            {
                Message = "No products found.";
            }
            ProductsSelectionChanged.Invoke();
        }
    }
}
