using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class UsedPartRepository
    {
        private readonly PractDbContext db;
        public UsedPartRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<UsedPart> GetAllUsedParts()
        {
            return db.usedParts.Include(up => up.Repair)
                               .Include(up => up.Part)
                               .ToList();
        }

        public async Task<UsedPart> AddUsedPart(int repairId, int partId, int quantity)
        {
            UsedPart usedPart = new UsedPart()
            {
                RepairID = repairId,
                PartID = partId,
                Quantity = quantity
            };
            db.usedParts.Add(usedPart);
            await db.SaveChangesAsync();
            return usedPart;
        }

        public async Task DeleteUsedPart(int id)
        {
            var usedPart = await db.usedParts.Where(up => up.UsedPartID == id).FirstOrDefaultAsync();
            if (usedPart != null)
            {
                db.usedParts.Remove(usedPart);
                await db.SaveChangesAsync();
            }
        }
    }
}
