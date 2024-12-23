using pract.Models;

namespace pract.DAO
{
    public interface IPartRepository
    {
        IQueryable<Part> GetPartOnly();
        Task<Part> AddPart(Part part);
        Part GetPartById(long id);
    }
}
