using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class ReceptionistRepository:IReceprionistRepository
    {
        private readonly PractDbContext db;
        public ReceptionistRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Receptionist> GetReceptionistOnly()
        {
            return db.receptionits.AsQueryable();
        }

        public async Task<Receptionist> AddReceptionist(Receptionist receptionist)
        {
            db.receptionits.Add(receptionist);
            await db.SaveChangesAsync();
            return receptionist;
        }

        public Receptionist GetReceptionistById(long id)
        {
            var rec = db.receptionits.Include(p => p.Repairs).FirstOrDefault(p => p.Id == id);
            if (rec != null) return rec!;
            return null!;
        }
    }
}
