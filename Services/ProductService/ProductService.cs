namespace SmartLine.Services.ProductService;

using System.Collections.Generic;
using System.Threading.Tasks;
using SmartLine.Model;
using SQLite;

public class ProductService : IProductRepository
{
    public Task<bool> AddUpdateProductAsync(Product calendarDay)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProductAsync(int calendarId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductInfo> GetProductAsync(int calendarId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductInfo>> GetProductAsync()
    {
        throw new NotImplementedException();
    }
}