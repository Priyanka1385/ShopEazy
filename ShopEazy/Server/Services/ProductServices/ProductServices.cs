using Microsoft.EntityFrameworkCore;
using ShopEasy.Shared.Models;
using ShopEazy.Server.Data;
using ShopEazy.Shared;

namespace ShopEazy.Server.Services.ProductServices
{
    public class ProductServices : IProductServices
    {
        private readonly DataContext _context;

        public ProductServices(DataContext context)
        {
            _context = context;
        }

        public async Task<ApplicationResponse<List<Product>>> GetProduct()
        {
            ApplicationResponse<List<Product>> response = new ApplicationResponse<List<Product>>();
            var Products = await _context.Products.ToListAsync();
            response.Data = Products;
            response.Message = "List of Products";

            return response;
        }
    }
}
