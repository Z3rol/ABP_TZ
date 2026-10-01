using ABP_TZ.Models;

namespace ABP_TZ.Interfaces
{
    public interface IServiceRepository
    {
        Task<List<Service>> GetServicesByIdsAsync(List<int> ids);
    }
}