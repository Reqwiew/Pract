using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class MasterRepository
    {
        private readonly PractDbContext db;
        public MasterRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Master> GetAllMasters()
        {
            return db.masters.ToList();
        }

        public async Task<Master> AddMaster(string fullName, string specialization, string phoneNumber)
        {
            Master master = new Master()
            {
                FullName = fullName,
                Specialization = specialization,
                PhoneNumber = phoneNumber
            };
            db.masters.Add(master);
            await db.SaveChangesAsync();
            return master;
        }

        public async Task<Master> UpdateMaster(Master model)
        {
            var master = await db.masters.Where(m => m.MasterID == model.MasterID).FirstOrDefaultAsync();
            if (master != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    master.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.Specialization))
                    master.Specialization = model.Specialization;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    master.PhoneNumber = model.PhoneNumber;

                db.masters.Update(master);
                await db.SaveChangesAsync();
            }
            return master!;
        }

        public async Task DeleteMaster(int id)
        {
            var master = await db.masters.Where(m => m.MasterID == id).FirstOrDefaultAsync();
            if (master != null)
            {
                db.masters.Remove(master);
                await db.SaveChangesAsync();
            }
        }
    }
}
