using pract.Models;

namespace pract.DAO
{
    public interface IEquipmentRepository
    {
        IQueryable<Equipment> GetEquipmentOnly();
        Task<Equipment> AddEquipment(Equipment equipment);
        Equipment GetEquipmentById(long id);

    }
}
