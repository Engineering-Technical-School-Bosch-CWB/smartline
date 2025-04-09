using SmartLine.Model;

namespace SmartLine.Services.CycleMatrixService;

public class CycleMatrixService : ICycleMatrixRepository
{
    public Task<double> GetCycleAsync(Product productA, Product productB)
    {
        double cycle1 = (productA.TimeSideA + productB.TimeSideA) / 4;
        double cycle2 = productA.TimeSideB / 4;
        double cycle3 = productB.TimeSideB / 4;

        double maxCycle = Math.Max(cycle1, Math.Max(cycle2, cycle3));
        
        return Task.FromResult(maxCycle);
    }
}
