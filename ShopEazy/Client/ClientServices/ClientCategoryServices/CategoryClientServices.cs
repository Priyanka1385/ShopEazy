using ShopEasy.Shared.Models;
using ShopEazy.Shared;
using System.Net.Http.Json;

namespace ShopEazy.Client.ClientServices.ClientCategoryServices
{
    public class CategoryClientServices : ICategoryClientServices
    {
        private readonly HttpClient _http;

        public CategoryClientServices(HttpClient http)
        {
            _http = http;
        }

        public List<Category> categories { get; set ; }= new List<Category>();
        
        public async Task GetCategories()
        {
            var result = await _http.GetFromJsonAsync<ApplicationResponse<List<Category>>>("api/Category");
            categories = result.Data;
        }

        public Task<ApplicationResponse<Category>> GetCategoriesById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
