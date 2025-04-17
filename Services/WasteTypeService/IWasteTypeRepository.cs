using SmartLine.Model;

namespace SmartLine.Services.WasteTypeService;

public interface IWasteTypeRepository
{
    Task<bool> AddUpdateWasteTypeAsync(WasteType wasteType);
    Task<bool> DeleteWasteTypeAsync(int wasteTypeId);
    Task<Product> GetWasteTypeAsync(int wasteTypeId);
    Task<IEnumerable<Product>> GetWasteTypeAsync();
}
