using Microsoft.Graph.Models;
using pract.DAO;
using pract.Models;

namespace pract.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Service")]
        public IQueryable<Service> GetService([Service] IServiceRepoitory service) => service.GetServiceOnly();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Client")]
        public IQueryable<Client> GetClient([Service] IClientRepository client) => client.GetClientsOnly();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Reseptionist")]
        public IQueryable<Receptionist> GetReseprionist([Service] IReceprionistRepository receprionist) => receprionist.GetReceptionistOnly();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Master")]
        public IQueryable<Master> GetMaster([Service] IMasterRepository master) => master.GetMasterOnly();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Equipment")]
        public IQueryable<Equipment> GetEquipment([Service] IEquipmentRepository equipment) => equipment.GetEquipmentOnly();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Part")]
        public IQueryable<Part> GetPart([Service] IPartRepository part) => part.GetPartOnly();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Repair")]
        public IQueryable<Repair> GetRepair([Service] IRepairRepository repair) => repair.GetRepairOnly();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all RepairService")]
        public IQueryable<RepairService> GetRepairService([Service] IRepairServiceRepository repairService) => repairService.GetRepairServiceOnly();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all UsedPart")]
        public IQueryable<UsedPart> GetUsedPart([Service] IUsedPartRepository usedPart) => usedPart.GetUsedPartOnly();
    }
}
