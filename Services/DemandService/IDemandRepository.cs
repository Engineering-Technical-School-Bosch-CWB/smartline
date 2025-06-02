using SmartLine.Model;

namespace SmartLine.Services.DemandService;

public interface IDemandRepository
{
    Task<bool> AddUpdateDemandAsync(Demand demand);
    Task<bool> DeleteDemandAsync(int demandId);
    Task<Demand> GetDemandAsync(int demandId);
    Task<IEnumerable<Demand>> GetDemandAsync();
}
