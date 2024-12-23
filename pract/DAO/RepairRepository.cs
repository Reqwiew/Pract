using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class RepairRepository:IRepairRepository
    {
        private readonly PractDbContext db;
        public RepairRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Repair> GetRepairOnly()
        {
            return db.repairs.AsQueryable();
        }

        public async Task<Repair> AddRepair(Repair repair)
        {
            db.repairs.Add(repair);
            await db.SaveChangesAsync();
            return repair;
        }

       
    }
}
