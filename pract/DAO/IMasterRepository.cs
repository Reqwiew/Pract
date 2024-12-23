using pract.Models;

namespace pract.DAO
{
    public interface IMasterRepository
    {
        IQueryable<Master> GetMasterOnly();
        Task<Master> AddMaster(Master master);
        Master GetMasterById(long id);
    }
}
