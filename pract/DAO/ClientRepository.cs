using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using pract.Models;

namespace pract.DAO
{
    public class ClientRepository:IClientRepository
    {
        private readonly PractDbContext db;

        public ClientRepository(PractDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Client> GetClientsOnly()
        {
            return db.clients.AsQueryable();
        }

        public async Task<Client> AddClient(Client client)
        {
            db.clients.Add(client);
            await db.SaveChangesAsync();
            return client;
        }

        public Client GetClientById(long id)
        {
            var client = db.clients.Include(p => p.Equipments).FirstOrDefault(p => p.Id == id);
            if (client != null) return client!;
            return null!;
        }
    }
}
