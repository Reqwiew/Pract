using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class ServiceRepository
    {
        private readonly PractDbContext db;
        public ServiceRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Service> GetAllServices()
        {
            return db.services.ToList();
        }

        public async Task<Service> AddService(string serviceName, decimal price)
        {
            Service service = new Service()
            {
                ServiceName = serviceName,
                Price = price
            };
            db.services.Add(service);
            await db.SaveChangesAsync();
            return service;
        }

        public async Task<Service> UpdateService(Service model)
        {
            var service = await db.services.Where(s => s.ServiceID == model.ServiceID).FirstOrDefaultAsync();
            if (service != null)
            {
                if (!string.IsNullOrEmpty(model.ServiceName))
                    service.ServiceName = model.ServiceName;
                if (model.Price > 0)
                    service.Price = model.Price;

                db.services.Update(service);
                await db.SaveChangesAsync();
            }
            return service!;
        }

        public async Task DeleteService(int id)
        {
            var service = await db.services.Where(s => s.ServiceID == id).FirstOrDefaultAsync();
            if (service != null)
            {
                db.services.Remove(service);
                await db.SaveChangesAsync();
            }
        }
    }
}
