using System.Collections.Generic;
using System.Threading.Tasks;
using SmartLine.Model;
using SQLite;

namespace SmartLine.Services.ProductService;

public class ProductService(string dbPath) : IProductRepository
{
    public required SQLiteAsyncConnection _database;
    string _dbPath = dbPath;

    private async Task InitAsync()
    {
        if(_database != null)
        {
            return;
        }
        _database=new SQLiteAsyncConnection(_dbPath);
        await _database.CreateTableAsync<Product>();
    }

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
        await _database.DeleteAsync<Product>(prodId);
        return await Task.FromResult(true);
    }

    public async Task<Product> GetProductAsync(int prodId)
    {
        return await _database.Table<Product>().Where(p=>p.Id == prodId).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Product>> GetProductAsync()
    {
        await InitAsync();
        return await Task.FromResult(await _database.Table<Product>().ToListAsync());
    }
}