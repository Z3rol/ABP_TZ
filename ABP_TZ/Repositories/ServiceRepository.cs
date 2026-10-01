using ABP_TZ.Interfaces;
using ABP_TZ.Models;
using Microsoft.EntityFrameworkCore;

namespace ABP_TZ.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _context;
        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Service>> GetServicesByIdsAsync(List<int> ids)
        {
            return await _context.Services
                .Where(s => ids.Contains(s.Id))
                .ToListAsync();
        }
    }
}