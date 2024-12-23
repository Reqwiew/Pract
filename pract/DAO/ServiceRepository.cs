using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using pract.Models;

namespace pract.DAO
{
    public class ServiceRepository : IServiceRepoitory
    {
        private readonly PractDbContext db;
        public ServiceRepository(PractDbContext db)
        {
            this.db = db;
        }
        public IQueryable<Service> GetServiceOnly()
        {
            return db.services.AsQueryable();
        }

        public async Task<Service> AddService(Service service)
        {
            db.services.Add(service);
            await db.SaveChangesAsync();
            return service;
        }

        public Service GetServiceById(long id)
        {
            var service = db.services.Include(p => p.RepairServices).FirstOrDefault(p => p.Id == id);
            if (service != null) return service!;
            return null!;
        }
    }
}
