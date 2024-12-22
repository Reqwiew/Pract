using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class PartRepository
    {
        private readonly PractDbContext db;
        public PartRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Part> GetAllParts()
        {
            return db.parts.ToList();
        }

        public async Task<Part> AddPart(string partName, decimal price)
        {
            Part part = new Part()
            {
                PartName = partName,
                Price = price
            };
            db.parts.Add(part);
            await db.SaveChangesAsync();
            return part;
        }

        public async Task<Part> UpdatePart(Part model)
        {
            var part = await db.parts.Where(p => p.PartID == model.PartID).FirstOrDefaultAsync();
            if (part != null)
            {
                if (!string.IsNullOrEmpty(model.PartName))
                    part.PartName = model.PartName;
                if (model.Price > 0)
                    part.Price = model.Price;

                db.parts.Update(part);
                await db.SaveChangesAsync();
            }
            return part!;
        }

        public async Task DeletePart(int id)
        {
            var part = await db.parts.Where(p => p.PartID == id).FirstOrDefaultAsync();
            if (part != null)
            {
                db.parts.Remove(part);
                await db.SaveChangesAsync();
            }
        }
    }
}
