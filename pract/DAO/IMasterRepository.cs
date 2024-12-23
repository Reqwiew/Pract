using pract.Models;

namespace pract.DAO
{
    public interface IMasterRepository
    {
        IQueryable<Master> GetAllMaster();
    }
}
