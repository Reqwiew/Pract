using pract.Models;

namespace pract.DAO
{
    public interface IUsedPartRepository
    {
        IQueryable<UsedPart> GetUsedPartOnly();
        Task<UsedPart> AddUsedPart(UsedPart usedPart);
        
    }
}
