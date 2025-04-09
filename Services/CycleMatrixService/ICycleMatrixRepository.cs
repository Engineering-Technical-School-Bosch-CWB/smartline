using SmartLine.Model;

namespace SmartLine.Services.CycleMatrixService;

public interface ICycleMatrixRepository
{
    Task<double> GetCycleAsync(Product productA, Product productB);
}
