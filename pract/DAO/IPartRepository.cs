using pract.Models;

namespace pract.DAO
{
    public interface IPartRepository
    {
        IQueryable<Part> GetAllPart();
    }
}
