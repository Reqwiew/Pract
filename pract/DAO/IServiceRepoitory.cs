using pract.Models;

namespace pract.DAO
{
    public interface IServiceRepoitory
    {
        IQueryable<Service> GetServiceOnly();
        Task<Service> AddService(Service service);
        Service GetServiceById(long id);
    }
}
