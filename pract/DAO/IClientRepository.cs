﻿using Microsoft.Graph.Models;
using pract.Models;

namespace pract.DAO
{
    public interface IClientRepository
    {
        IQueryable<Client> GetClientsOnly();
        Task<Client> AddClient(Client client);
        Client GetClientById(long id);
    }
}
