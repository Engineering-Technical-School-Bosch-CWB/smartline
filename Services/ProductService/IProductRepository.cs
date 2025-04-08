using SmartLine.Data;

namespace SmartLine.Services.ProductService;

public interface IProductRepository
{
    Task<bool> AddUpdateProductAsync(ProductInfo productInfo);
    Task<bool> DeleteProductAsync(int prodId);
    Task<ProductInfo> GetProductAsync(int prodId);
    Task<IEnumerable<ProductInfo>> GetProductAsync();
}