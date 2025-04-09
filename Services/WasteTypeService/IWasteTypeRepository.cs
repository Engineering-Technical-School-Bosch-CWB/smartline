using SmartLine.Model;

namespace SmartLine.Services.WasteTypeService;

public interface IWasteTypeRepository
{
    Task<bool> AddUpdateWasteTypeAsync(WasteType wasteType);
    Task<bool> DeleteWasteTypeAsync(int wasteTypeId);
    Task<ProductInfo> GetWasteTypeAsync(int wasteTypeId);
    Task<IEnumerable<ProductInfo>> GetWasteTypeAsync();
}
