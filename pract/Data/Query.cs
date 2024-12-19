using Microsoft.Graph.Models;
using pract.Models;

namespace pract.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Service> GetServices([Service] PractDbContext context) => context.services;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Client> GetClients(PractDbContext context) => context.clients;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Receptionit> GetReceptionits(PractDbContext context) => context.receptionits;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Master> GetMasters(PractDbContext context) => context.masters;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<CompliteWork> GetComplitework(PractDbContext context) => context.compliteWorks;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<UseChapters> GetUseChap( PractDbContext context) => context.UseChapters;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<AcceptTec> GetAcceptTecs(PractDbContext context) => context.acceptTecs;
    }
}
