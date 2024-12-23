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
        public IQueryable<Service> GetAllServiceWithRepairService()
        {
            return db.services.Include(d => d.RepairServices);
        }
        public async Task<Service> AddService(Service service)
        {
            db.services.Add(service);
            await db.SaveChangesAsync();
            return service;
        }
        public async Task<Service> UpdateService(Service model)
        {
            var service = await db.services.Where(p => p.ServiceID == model.ServiceID).FirstOrDefaultAsync();
            if (service != null)
            {
                if (!string.IsNullOrEmpty(model.ServiceName))
                    service.ServiceName = model.ServiceName;
                if (!string.IsNullOrEmpty((model.Price).ToString()))
                    service.Price = model.Price;

                db.services.Update(service);
                await db.SaveChangesAsync();
            }
            return service!;
        }

        public async Task DeleteService(long ServiceID)
        {
            var service = await db.services.Where(p => p.ServiceID == ServiceID).FirstOrDefaultAsync();
            if (service != null)
            {
                db.services.Remove(service);
                await db.SaveChangesAsync();
            }
        }
        public Task<Service> GetServiceById(long ServiceID)
        {
            var service = db.services.Include(p => p.RepairServices).
                FirstOrDefaultAsync(p => p.ServiceID == ServiceID);
            if (service != null) return service!;
            return null!;
        }
        public IQueryable<Service> GetServiceOnly()
        {
            return db.services.AsQueryable();
        }
    }
}
