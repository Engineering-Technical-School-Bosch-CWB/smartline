using SmartLine.Model;

namespace SmartLine.Services.ProductService;

public interface IProductRepository
{
    Task<bool> AddUpdateProductAsync(Product product);
    Task<bool> DeleteProductAsync(int productId);
    Task<Product> GetProductAsync(int productId);
    Task<IEnumerable<Product>> GetProductAsync();
}
