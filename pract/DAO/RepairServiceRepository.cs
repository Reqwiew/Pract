using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class RepairServiceRepository
    {
        private readonly PractDbContext db;
        public RepairServiceRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<RepairService> GetAllRepairServices()
        {
            return db.repairServices.Include(rs => rs.Repair)
                                    .Include(rs => rs.Service)
                                    .ToList();
        }

        public async Task<RepairService> AddRepairService(int repairId, int serviceId)
        {
            RepairService repairService = new RepairService()
            {
                RepairID = repairId,
                ServiceID = serviceId
            };
            db.repairServices.Add(repairService);
            await db.SaveChangesAsync();
            return repairService;
        }

        public async Task DeleteRepairService(int id)
        {
            var repairService = await db.repairServices.Where(rs => rs.RepairServiceID == id).FirstOrDefaultAsync();
            if (repairService != null)
            {
                db.repairServices.Remove(repairService);
                await db.SaveChangesAsync();
            }
        }
    }
}
