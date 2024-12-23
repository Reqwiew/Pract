using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class EquipmentRepository: IEquipmentRepository
    {
        private readonly PractDbContext db;

        public EquipmentRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Equipment> GetEquipmentOnly()
        {
            return db.equipment.AsQueryable();
        }

        public async Task<Equipment> AddEquipment(Equipment equipment)
        {
            db.equipment.Add(equipment);
            await db.SaveChangesAsync();
            return equipment;
        }

        public Equipment GetEquipmentById(long id)
        {
            var equip = db.equipment.Include(p => p.Repairs).FirstOrDefault(p => p.Id == id);
            if (equip != null) return equip!;
            return null!;
        }
    }
}
