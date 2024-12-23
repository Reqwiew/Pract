using pract.Models;

namespace pract.DAO
{
    public interface IUsedPartRepository
    {
        IQueryable<UsedPart> GetAllUsedPart();

    }
}
