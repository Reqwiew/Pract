using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class EquipmentRepository
    {
        private readonly PractDbContext db;
        public EquipmentRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Equipment> GetAllEquipment()
        {
            return db.equipment.Include(e => e.Client).ToList();
        }

        public async Task<Equipment> AddEquipment(string type, string brand, string model, string serialNumber, int clientId)
        {
            Equipment equipment = new Equipment()
            {
                EquipmentType = type,
                Brand = brand,
                Model = model,
                SerialNumber = serialNumber,
                ClientID = clientId
            };
            db.equipment.Add(equipment);
            await db.SaveChangesAsync();
            return equipment;
        }

        public async Task<Equipment> UpdateEquipment(Equipment model)
        {
            var equipment = await db.equipment.Where(e => e.EquipmentID == model.EquipmentID).FirstOrDefaultAsync();
            if (equipment != null)
            {
                if (!string.IsNullOrEmpty(model.EquipmentType))
                    equipment.EquipmentType = model.EquipmentType;
                if (!string.IsNullOrEmpty(model.Brand))
                    equipment.Brand = model.Brand;
                if (!string.IsNullOrEmpty(model.Model))
                    equipment.Model = model.Model;
                if (!string.IsNullOrEmpty(model.SerialNumber))
                    equipment.SerialNumber = model.SerialNumber;

                db.equipment.Update(equipment);
                await db.SaveChangesAsync();
            }
            return equipment!;
        }

        public async Task DeleteEquipment(int id)
        {
            var equipment = await db.equipment.Where(e => e.EquipmentID == id).FirstOrDefaultAsync();
            if (equipment != null)
            {
                db.equipment.Remove(equipment);
                await db.SaveChangesAsync();
            }
        }
    }
}
