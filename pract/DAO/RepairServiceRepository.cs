using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class RepairServiceRepository:IRepairServiceRepository
    {
        private readonly PractDbContext db;
        public RepairServiceRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<RepairService> GetRepairServiceOnly()
        {
            return db.repairServices.AsQueryable();
        }

        public async Task<RepairService> AddRepairService(RepairService repairService)
        {
            db.repairServices.Add(repairService);
            await db.SaveChangesAsync();
            return repairService;
        }

    }
}
