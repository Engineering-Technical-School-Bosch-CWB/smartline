using System.Collections.Generic;
using System.Threading.Tasks;
using SmartLine.Model;
using SQLite;

namespace SmartLine.Services.DemandService;

public class DemandService(SQLiteAsyncConnection db) : IDemandRepository
{
    private readonly SQLiteAsyncConnection _database = db;

    public async Task<bool> AddUpdateDemandAsync(Demand demandInfo)
    {
        if (demandInfo.Id > 0)
            await _database.UpdateAsync(demandInfo);
        else
            await _database.InsertAsync(demandInfo);
        return true;
    }

    public async Task<bool> DeleteDemandAsync(int demandId)
    {
        return await _database.DeleteAsync<Demand>(demandId).ContinueWith(_ => true);
    }

    public async Task<Demand> GetDemandAsync(int demandId)
    {
        return await _database.Table<Demand>().Where(p => p.Id == demandId).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Demand>> GetDemandAsync()
    {
        return await _database.Table<Demand>().ToListAsync();
    }
}