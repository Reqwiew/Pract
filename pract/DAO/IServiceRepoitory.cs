using pract.Models;

namespace pract.DAO
{
    public interface IServiceRepoitory
    {
        IQueryable<Service> GetAllServiceWithRepairService();
        IQueryable<Service> GetServiceOnly();
        Task<Service> GetServiceById(long ServiceId);
        Task<Service> AddService(Service service);
    }
}
