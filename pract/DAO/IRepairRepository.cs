using pract.Models;

namespace pract.DAO
{
    public interface IRepairRepository
    {
        IQueryable<Repair> GetRepairOnly();
        Task<Repair> AddRepair(Repair repair);
      
    }
}
