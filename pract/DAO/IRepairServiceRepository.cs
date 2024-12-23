using pract.Models;

namespace pract.DAO
{
    public interface IRepairServiceRepository
    {
        IQueryable<RepairService> GetRepairServiceOnly();
        Task<RepairService> AddRepairService(RepairService repairService);
     
    }
}
