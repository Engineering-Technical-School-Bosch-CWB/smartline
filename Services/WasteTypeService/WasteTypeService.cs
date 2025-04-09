using SmartLine.Model;

namespace SmartLine.Services.WasteTypeService;

public class WasteTypeService : IWasteTypeRepository
{
    public Task<bool> AddUpdateWasteTypeAsync(WasteType wasteType)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteWasteTypeAsync(int wasteTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<ProductInfo> GetWasteTypeAsync(int wasteTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductInfo>> GetWasteTypeAsync()
    {
        throw new NotImplementedException();
    }
}
