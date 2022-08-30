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

        public async Task<ApplicationResponse<Product>> GetProductById(int id)
        {
            ApplicationResponse<Product> response = new ApplicationResponse<Product>();
            var Product = await _context.Products.FindAsync(id);
            if(Product == null)
            {
                response.Message = "Sorry, but this product does not exist.";
                response.Success = false;
            }
            else {
                
                response.Data = Product;
                response.Message = "Searched Product";
            }
           

            return response;
        }
    }
}
