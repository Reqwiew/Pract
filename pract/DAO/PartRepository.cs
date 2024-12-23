using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class PartRepository:IPartRepository
    {
        private readonly PractDbContext db;

        public PartRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Part> GetPartOnly()
        {
            return db.parts.AsQueryable();
        }

        public async Task<Part> AddPart(Part part)
        {
            db.parts.Add(part);
            await db.SaveChangesAsync();
            return part;
        }

        public Part GetPartById(long id)
        {
            var part = db.parts.Include(p => p.UsedParts).FirstOrDefault(p => p.Id == id);
            if (part != null) return part!;
            return null!;
        }
    }
}
