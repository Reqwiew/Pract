using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class ReceptionistRepository
    {
        private readonly PractDbContext db;
        public ReceptionistRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Receptionist> GetAllReceptionists()
        {
            return db.receptionits.ToList();
        }

        public async Task<Receptionist> AddReceptionist(string fullName, string phoneNumber)
        {
            Receptionist receptionist = new Receptionist()
            {
                FullName = fullName,
                PhoneNumber = phoneNumber
            };
            db.receptionits.Add(receptionist);
            await db.SaveChangesAsync();
            return receptionist;
        }

        public async Task<Receptionist> UpdateReceptionist(Receptionist model)
        {
            var receptionist = await db.receptionits.Where(r => r.ReceptionistID == model.ReceptionistID).FirstOrDefaultAsync();
            if (receptionist != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    receptionist.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    receptionist.PhoneNumber = model.PhoneNumber;

                db.receptionits.Update(receptionist);
                await db.SaveChangesAsync();
            }
            return receptionist!;
        }

        public async Task DeleteReceptionist(int id)
        {
            var receptionist = await db.receptionits.Where(r => r.ReceptionistID == id).FirstOrDefaultAsync();
            if (receptionist != null)
            {
                db.receptionits.Remove(receptionist);
                await db.SaveChangesAsync();
            }
        }
    }
}
