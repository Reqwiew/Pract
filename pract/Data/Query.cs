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
        public IQueryable<Receptionist> GetReceptionits(PractDbContext context) => context.receptionits;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Master> GetMasters(PractDbContext context) => context.masters;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Equipment> GetEquipment(PractDbContext context) => context.equipment;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Part> GetPart( PractDbContext context) => context.parts;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Repair> GetRepair(PractDbContext context) => context.repairs;
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<RepairService> GetRepairService([Service] PractDbContext context) => context.repairServices;

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<UsedPart> GetUsedPart(PractDbContext context) => context.usedParts;
    }
}
