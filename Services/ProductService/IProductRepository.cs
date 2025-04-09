using SmartLine.Model;

namespace SmartLine.Services.ProductService;

public interface IProductRepository
{
    Task<bool> AddUpdateProductAsync(Product calendarDay);
    Task<bool> DeleteProductAsync(int calendarId);
    Task<ProductInfo> GetProductAsync(int calendarId);
    Task<IEnumerable<ProductInfo>> GetProductAsync();
}
