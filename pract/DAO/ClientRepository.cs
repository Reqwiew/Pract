using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract.DAO
{
    public class ClientRepository
    {
        private readonly PractDbContext db;
        public ClientRepository(PractDbContext db)
        {
            this.db = db;
        }

        public List<Client> GetAllClients()
        {
            return db.clients.ToList();
        }

        public async Task<Client> AddClient(string fullName, string phoneNumber, string email, string address)
        {
            Client client = new Client()
            {
                FullName = fullName,
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address
            };
            db.clients.Add(client);
            await db.SaveChangesAsync();
            return client;
        }

        public async Task<Client> UpdateClient(Client model)
        {
            var client = await db.clients.Where(c => c.ClientID == model.ClientID).FirstOrDefaultAsync();
            if (client != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    client.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    client.PhoneNumber = model.PhoneNumber;
                if (!string.IsNullOrEmpty(model.Email))
                    client.Email = model.Email;
                if (!string.IsNullOrEmpty(model.Address))
                    client.Address = model.Address;

                db.clients.Update(client);
                await db.SaveChangesAsync();
            }
            return client!;
        }

        public async Task DeleteClient(int id)
        {
            var client = await db.clients.Where(c => c.ClientID == id).FirstOrDefaultAsync();
            if (client != null)
            {
                db.clients.Remove(client);
                await db.SaveChangesAsync();
            }
        }
    }
}
