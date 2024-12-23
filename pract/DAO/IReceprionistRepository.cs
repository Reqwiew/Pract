using pract.Models;

namespace pract.DAO
{
    public interface IReceprionistRepository
    {
        IQueryable<Receptionist> GetReceptionistOnly();
        Task<Receptionist> AddReceptionist(Receptionist receptionist);
        Receptionist GetReceptionistById(long id);
    }
}
