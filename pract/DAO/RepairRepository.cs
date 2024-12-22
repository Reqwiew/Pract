using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class RepairRepository
    {
        private readonly PractDbContext db;
        public RepairRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Repair> GetAllRepairs()
        {
            return db.repairs.Include(r => r.Equipment)
                             .Include(r => r.Master)
                             .Include(r => r.Receptionist)
                             .ToList();
        }

        public async Task<Repair> AddRepair(DateTime startDate, decimal totalCost, int equipmentId, int masterId, int receptionistId)
        {
            Repair repair = new Repair()
            {
                StartDate = startDate,
                TotalCost = totalCost,
                EquipmentID = equipmentId,
                MasterID = masterId,
                ReceptionistID = receptionistId
            };
            db.repairs.Add(repair);
            await db.SaveChangesAsync();
            return repair;
        }

        public async Task<Repair> UpdateRepair(Repair model)
        {
            var repair = await db.repairs.Where(r => r.RepairID == model.RepairID).FirstOrDefaultAsync();
            if (repair != null)
            {
                if (model.StartDate != default)
                    repair.StartDate = model.StartDate;
                if (model.EndDate.HasValue)
                    repair.EndDate = model.EndDate;
                if (model.TotalCost > 0)
                    repair.TotalCost = model.TotalCost;

                db.repairs.Update(repair);
                await db.SaveChangesAsync();
            }
            return repair!;
        }

        public async Task DeleteRepair(int id)
        {
            var repair = await db.repairs.Where(r => r.RepairID == id).FirstOrDefaultAsync();
            if (repair != null)
            {
                db.repairs.Remove(repair);
                await db.SaveChangesAsync();
            }
        }
    }
}
