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
        public IQueryable<Service> GetService([Service] IServiceRepoitory service) => service.GetAllServiceWithRepairService();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Client")]
        public IQueryable<Client> GetClient([Service] IClientRepository client) => client.GetAllClientsWithEquipment();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Reseptionist")]
        public IQueryable<Receptionist> GetReseprionist([Service] IReceprionistRepository receprionist) => receprionist.GetAllReceptionist();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Master")]
        public IQueryable<Master> GetMaster([Service] IMasterRepository master) => master.GetAllMaster();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Equipment")]
        public IQueryable<Equipment> GetEquipment([Service] IEquipmentRepository equipment) => equipment.GetAllEquipment();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Part")]
        public IQueryable<Part> GetPart([Service] IPartRepository part) => part.GetAllPart();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all Repair")]
        public IQueryable<Repair> GetRepair([Service] IRepairRepository repair) => repair.GetAllRepair();
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all RepairService")]
        public IQueryable<RepairService> GetRepairService([Service] IRepairServiceRepository repairService) => repairService.GetAllRepairService();

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Method used to get list of all UsedPart")]
        public IQueryable<UsedPart> GetUsedPart([Service] IUsedPartRepository usedPart) => usedPart.GetAllUsedPart();
    }
}
