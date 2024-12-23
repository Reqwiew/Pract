using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class UsedPartRepository: IUsedPartRepository
    {
        private readonly PractDbContext db;
        public UsedPartRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<UsedPart> GetUsedPartOnly()
        {
            return db.usedParts.AsQueryable();
        }

        public async Task<UsedPart> AddUsedPart(UsedPart usedPart)
        {
            db.usedParts.Add(usedPart);
            await db.SaveChangesAsync();
            return usedPart;
        }


    }
}
