using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class MasterRepository:IMasterRepository
    {
        private readonly PractDbContext db;

        public MasterRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Master> GetMasterOnly()
        {
            return db.masters.AsQueryable();
        }

        public async Task<Master> AddMaster(Master master)
        {
            db.masters.Add(master);
            await db.SaveChangesAsync();
            return master;
        }

        public Master GetMasterById(long id)
        {
            var mast = db.masters.Include(p => p.Repairs).FirstOrDefault(p => p.Id == id);
            if (mast != null) return mast!;
            return null!;
        }
    }
}
