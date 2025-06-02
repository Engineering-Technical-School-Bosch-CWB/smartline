using SmartLine.Model;
using SQLite;

namespace SmartLine.Services.DatabaseService;

public class DatabaseService
{
    private readonly SQLiteAsyncConnection _database;

    public DatabaseService(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        InitAsync().Wait();
    }

    public SQLiteAsyncConnection GetConnection() => _database;

    private async Task InitAsync()
    {
        await _database.CreateTableAsync<Demand>();
        await _database.CreateTableAsync<Product>();
        // Se tiver mais tabelas:
        // await _database.CreateTableAsync<Product>();
        // await _database.CreateTableAsync<Alert>();
    }
}
