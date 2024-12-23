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
        public IQueryable<Client> GetAllClientsWithEquipment()
        {
            return db.clients.Include(d => d.Equipments);
        }
        public async Task<Client> AddClient(Client client)
        {
            db.clients.Add(client);
            await db.SaveChangesAsync();
            return client ;
        }
        public async Task<Client> UpdatePost(Client model)
        {
            var client = await db.clients.Where(p => p.ClientID == model.ClientID).FirstOrDefaultAsync();
            if (client != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    client.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.Email))
                    client.Email = model.Email;
                if (!string.IsNullOrEmpty(model.Address))
                    client.Address = model.Address;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    client.PhoneNumber = model.PhoneNumber;
                db.clients.Update(client);
                await db.SaveChangesAsync();
            }
            return client!;
        }

        public async Task DeleteClient(long ClientId)
        {
            var client = await db.clients.Where(p => p.ClientID == ClientId).FirstOrDefaultAsync();
            if (client != null)
            {
                db.clients.Remove(client);
                await db.SaveChangesAsync();
            }
        }
        public Task<Client> GetClientById(long ClientId)
        {
            var client= db.clients.Include(p => p.Equipments).
                FirstOrDefaultAsync(p => p.ClientID == ClientId);
            if (client != null) return client!;
            return null!;
        }
        public IQueryable<Client> GetClientOnly()
        {
            return db.clients.AsQueryable();
        }
    }
}
