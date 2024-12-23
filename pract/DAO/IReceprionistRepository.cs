using pract.Models;

namespace pract.DAO
{
    public interface IReceprionistRepository
    {
        IQueryable<Receptionist> GetAllReceptionist();
    }
}
