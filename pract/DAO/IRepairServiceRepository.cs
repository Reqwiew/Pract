using pract.Models;

namespace pract.DAO
{
    public interface IRepairServiceRepository
    {
        IQueryable<RepairService> GetAllRepairService();
    }
}
