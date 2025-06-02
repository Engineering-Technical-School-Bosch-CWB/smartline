using System.Collections.Generic;
using System.Threading.Tasks;
using SmartLine.Model;
using SQLite;

namespace SmartLine.Services.ProductService;

public class ProductService(SQLiteAsyncConnection db) : IProductRepository
{
    private readonly SQLiteAsyncConnection _database = db;

    public async Task<bool> AddUpdateProductAsync(Product productInfo)
    {
        if (productInfo.Id > 0)
        {
            await _database.UpdateAsync(productInfo);
        }
        else
        {
            await _database.InsertAsync(productInfo);
        }
        return await Task.FromResult(true);
    }

    public async Task<bool> DeleteProductAsync(int prodId)
    {
        return await _database.DeleteAsync<Product>(prodId).ContinueWith(_ => true);
    }

    public async Task<Product> GetProductAsync(int prodId)
    {
        return await _database.Table<Product>().Where(p => p.Id == prodId).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Product>> GetProductAsync()
    {
        return await _database.Table<Product>().ToListAsync();
    }
}