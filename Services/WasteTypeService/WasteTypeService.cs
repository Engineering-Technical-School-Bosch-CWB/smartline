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

    public Task<Product> GetWasteTypeAsync(int wasteTypeId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetWasteTypeAsync()
    {
        throw new NotImplementedException();
    }
}
