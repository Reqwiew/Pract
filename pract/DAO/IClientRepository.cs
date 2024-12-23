using Microsoft.Graph.Models;
using pract.Models;

namespace pract.DAO
{
    public interface IClientRepository
    {
        IQueryable<Client> GetAllClientsWithEquipment();
        IQueryable<Client> GetClientOnly();
        Task<Client> GetClientById(long ClientId);
        Task<Client> AddClient(Client client);
    }
}
