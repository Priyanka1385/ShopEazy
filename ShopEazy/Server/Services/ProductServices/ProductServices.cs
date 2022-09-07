using Microsoft.EntityFrameworkCore;
using ShopEazy.Shared.Models;
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

        public async Task<ApplicationResponse<List<Product>>> GetFeaturedProducts()
        {
            ApplicationResponse<List<Product>> response = new ApplicationResponse<List<Product>>();
            var FeaturedProducts = await _context.Products
                .Where(p => p.Featured)
                .Include(v => v.Variants)
                .ToListAsync();

            response.Data=FeaturedProducts;
            response.Message = "List of Featured Products";
            return response;
        }

        public async Task<ApplicationResponse<List<Product>>> GetProduct()
        {
            ApplicationResponse<List<Product>> response = new ApplicationResponse<List<Product>>();
            var Products = await _context.Products
                .Include(p => p.Variants)
                .ToListAsync();
            response.Data = Products;
            response.Message = "List of Products";

            return response;
        }

        public async Task<ApplicationResponse<Product>> GetProductById(int id)
        {
            ApplicationResponse<Product> response = new ApplicationResponse<Product>();
            var Product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (Product == null)
            {
                response.Message = "Sorry, but this product does not exist.";
                response.Success = false;
            }
            else
            {

                response.Data = Product;
                response.Message = "Searched Product";
            }


            return response;
        }

        public async Task<ApplicationResponse<List<Product>>> GetProductsByCategory(string CategoryUrl)
        {
            ApplicationResponse<List<Product>> response = new ApplicationResponse<List<Product>>();
            var Product = await _context.Products
                .Where(p => p.Category.Url.ToLower().Equals(CategoryUrl.ToLower()))
                .Include(p => p.Variants)
                .ToListAsync();
            if (Product == null)
            {
                response.Message = "Sorry, but this product does not exist.";
                response.Success = false;
            }
            else
            {

                response.Data = Product;
                response.Message = "Searched Product";
            }


            return response;
        }

        public async Task<ApplicationResponse<List<String>>> GetProductSearchSuggestions(string SearchText)
        {
            var Products = await FindProductsBySearchText(SearchText);

            List<string> result = new List<string>();

            foreach (var product in Products)
            {
                if (product.Title.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }

                if (product.Description.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                {
                    var Panctuation = product.Description.Where(char.IsPunctuation).Distinct().ToArray();
                    var words = product.Description.Split().Select(w => w.Trim(Panctuation));
                    foreach (var word in words)
                    {
                        if (word.Contains(SearchText, StringComparison.OrdinalIgnoreCase) && !result.Contains(word))
                        {
                            result.Add(word);
                        }

                    }
                }
            }
            return new ApplicationResponse<List<String>> { Data = result };
        }

        public async Task<ApplicationResponse<List<Product>>> SearchProducts(string SearchText)
        {
            var response = new ApplicationResponse<List<Product>>
            {
                Data = await FindProductsBySearchText(SearchText)

            };
            return response;
        }

        private async Task<List<Product>> FindProductsBySearchText(string SearchText)
        {
            return await _context.Products
                            .Where(
                                p => p.Title.ToLower().Contains(SearchText.ToLower())
                            || p.Description.ToLower().Contains(SearchText.ToLower()))
                            .Include(p => p.Variants)
                            .ToListAsync();
        }
    }
}
