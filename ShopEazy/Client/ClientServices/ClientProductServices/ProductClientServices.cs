using ShopEasy.Shared.Models;
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

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ApplicationResponse<List<Product>>>("api/Product");
            Products = result.Data;
        }
    }
}
