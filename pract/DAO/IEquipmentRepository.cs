using pract.Models;

namespace pract.DAO
{
    public interface IEquipmentRepository
    {
        IQueryable<Equipment> GetAllEquipment();

    }
}
