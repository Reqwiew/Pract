using Microsoft.EntityFrameworkCore;
using HotChocolate.Authorization;
using pract.Models;
using Microsoft.Graph.Models;
using System.Text.RegularExpressions;

namespace pract.Data
{
    public class Mutation
    {
        [Serial]
        public async Task<Client?> UpdateClient([Service] PractDbContext context, Client model)
        {
            var client = await context.clients.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (client != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    client.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.Address))
                    client.Address = model.Address;
                if (!string.IsNullOrEmpty(model.Email))
                    client.Email = model.Email;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    client.PhoneNumber = model.PhoneNumber;

                context.clients.Update(client);
                await context.SaveChangesAsync();
            }

            return client;
        }

        [Serial]
        public async Task DeleteClient(
            [Service] PractDbContext context, Client model)
        {
            var client = await context.clients.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (client != null)
            {
                context.clients.Remove(client);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Client?> InsertClient(
            [Service] PractDbContext context,
            string FullName,
            string Address,
            string Email,
            string PhoneNumber)
        {
            var client = new Client
            {
                FullName = FullName,
                Address = Address,
                PhoneNumber = PhoneNumber,
                Email = Email
            };
            context.clients.Add(client);
            await context.SaveChangesAsync();
            return client;
        }

        [Serial]
        public async Task<Equipment?> UpdateEquipment([Service] PractDbContext context, Equipment model)
        {
            var equip = await context.equipment.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (equip != null)
            {
                if (!string.IsNullOrEmpty(model.EquipmentType))
                    equip.EquipmentType = model.EquipmentType;
                if (!string.IsNullOrEmpty(model.SerialNumber))
                    equip.SerialNumber = model.SerialNumber;
                if (!string.IsNullOrEmpty(model.Brand))
                    equip.Brand = model.Brand;
                if (!string.IsNullOrEmpty(model.Model))
                    equip.Model = model.Model;
                equip.ClientId = model.ClientId;

                    
                context.equipment.Update(equip);
                await context.SaveChangesAsync();
            }

            return equip;
        }

        [Serial]
        public async Task DeleteEquipment(
            [Service] PractDbContext context, Equipment model)
        {
            var equip = await context.equipment.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (equip != null)
            {
                context.equipment.Remove(equip);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Equipment?> InsertEquipment(
            [Service] PractDbContext context,
            string equipmentType,
            string Brand,
            string Model,
            string SerialNumber
            )
        {
            var equip = new Equipment
            {
                EquipmentType = equipmentType,
                Brand = Brand,
                Model = Model,
                SerialNumber = SerialNumber
            };
            context.equipment.Add(equip);
            await context.SaveChangesAsync();
            return equip;
        }


        [Serial]
        public async Task<Master?> UpdateMaster([Service] PractDbContext context, Master model)
        {
            var master = await context.masters.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (master != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    master.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.Specialization))
                    master.Specialization= model.Specialization;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    master.PhoneNumber = model.PhoneNumber;

                context.masters.Update(master);
                await context.SaveChangesAsync();
            }

            return master;
        }

        [Serial]
        public async Task DeleteMaster(
            [Service] PractDbContext context, Master model)
        {
            var master = await context.masters.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (master != null)
            {
                context.masters.Remove(master);
                await context.SaveChangesAsync();
            }
        }

        [Serial]

        public async Task<Master?> InsertMaster(
            [Service] PractDbContext context,
            string FullName,
            string Specialization,
            string PhoneNumber

            )
        {
            var master = new Master
            {
               FullName = FullName,
               Specialization = Specialization,
               PhoneNumber = PhoneNumber

            };
            context.masters.Add(master);
            await context.SaveChangesAsync();
            return master;
        }


        [Serial]
        public async Task<Part?> UpdatePart([Service] PractDbContext context, Part model)
        {
            var part = await context.parts.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (part != null)
            {
                if (!string.IsNullOrEmpty(model.PartName))
                    part.PartName = model.PartName;
                if (!string.IsNullOrEmpty((model.Price).ToString()))
                    part.Price = model.Price;
               
                context.parts.Update(part);
                await context.SaveChangesAsync();
            }

            return part;
        }

        [Serial]
        public async Task DeletePart(
            [Service] PractDbContext context, Part model)
        {
            var part = await context.parts.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (part != null)
            {
                context.parts.Remove(part);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Part?> InsertPart(
            [Service] PractDbContext context,
            string PartName,
            decimal Price

            )
        {
            var part = new Part
            {
                PartName = PartName,
                Price = Price
            };
            context.parts.Add(part);
            await context.SaveChangesAsync();
            return part;
        }




        [Serial]
        public async Task<Receptionist?> UpdateReceptionist([Service] PractDbContext context, Receptionist model)
        {
            var recep = await context.receptionits.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (recep != null)
            {
                if (!string.IsNullOrEmpty(model.FullName))
                    recep.FullName = model.FullName;
                if (!string.IsNullOrEmpty(model.PhoneNumber))
                    recep.PhoneNumber = model.PhoneNumber;

                context.receptionits.Update(recep);
                await context.SaveChangesAsync();
            }

            return recep;
        }

        [Serial]
        public async Task DeleteReceptionist(
            [Service] PractDbContext context, Receptionist model)
        {
            var recep = await context.receptionits.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (recep != null)
            {
                context.receptionits.Remove(recep);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Receptionist?> InsertReceptionist(
            [Service] PractDbContext context,
            string FullName,
            string PhoneNumber


            )
        {
            var recep = new Receptionist
            {
                FullName = FullName,
                PhoneNumber = PhoneNumber
            };
            context.receptionits.Add(recep);
            await context.SaveChangesAsync();
            return recep;
        }



        [Serial]
        public async Task<Repair?> UpdateRepair([Service] PractDbContext context, Repair model)
        {
            var repair = await context.repairs.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (repair != null)
            {
                if (!string.IsNullOrEmpty((model.TotalCost).ToString()))
                    repair.TotalCost = model.TotalCost;
               repair.StartDate = DateTime.Now;
                repair.EndDate = model.EndDate;
                repair.MasterId = model.MasterId;
                repair.EquipmentId = model.EquipmentId;
                repair.ReceptionistId = model.ReceptionistId;


                context.repairs.Update(repair);
                await context.SaveChangesAsync();
            }

            return repair;
        }

        [Serial]
        public async Task DeleteRepair(
            [Service] PractDbContext context, Repair model)
        {
            var repair = await context.repairs.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (repair != null)
            {
                context.repairs.Remove(repair);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Repair?> InsertRepair(
            [Service] PractDbContext context,
            DateTime StartDate,
            DateTime? EndDate,
            decimal TotalCost,
            long MasterId,
            long EquipmentId,
            long ReceptionistId


            )
        {
            var repair = new Repair
            {
                StartDate = StartDate,
                EndDate= EndDate,
                TotalCost = TotalCost,
                MasterId = MasterId,
                EquipmentId = EquipmentId,
                ReceptionistId = ReceptionistId

            };
            context.repairs.Add(repair);
            await context.SaveChangesAsync();
            return repair;
        }




        [Serial]
        public async Task<RepairService?> UpdateRepairService([Service] PractDbContext context, RepairService model)
        {
            var repairService = await context.repairServices.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (repairService != null)
            {
                repairService.ServiceId = model.ServiceId;
                repairService.RepairId = model.RepairId;

                context.repairServices.Update(repairService);
                await context.SaveChangesAsync();
            }

            return repairService;
        }

        [Serial]
        public async Task DeleteRepairService(
            [Service] PractDbContext context, RepairService model)
        {
            var repairserv = await context.repairServices.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (repairserv != null)
            {
                context.repairServices.Remove(repairserv);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<RepairService?> InsertRepairService(
            [Service] PractDbContext context,
                long RepairId,
                long ServiceId

            )
        {
            var repairServ = new RepairService
            {
               RepairId = RepairId,
               ServiceId = ServiceId
            };
            context.repairServices.Add(repairServ);
            await context.SaveChangesAsync();
            return repairServ;
        }



        [Serial]
        public async Task<Service?> UpdateService([Service] PractDbContext context, Service model)
        {
            var serv = await context.services.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (serv != null)
            {
                if (!string.IsNullOrEmpty(model.ServiceName))
                    serv.ServiceName = model.ServiceName;
                if (!string.IsNullOrEmpty((model.Price).ToString()))
                    serv.Price = model.Price;
                context.services.Update(serv);
                await context.SaveChangesAsync();
            }

            return serv;
        }

        [Serial]
        public async Task DeleteService(
            [Service] PractDbContext context, Service model)
        {
            var serv = await context.services.Where(p => p.Id == model.Id).FirstOrDefaultAsync();
            if (serv != null)
            {
                context.services.Remove(serv);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Service?> InsertServices(
            [Service] PractDbContext context,
            string ServiceName,
            decimal Price


            )
        {
            var serv = new Service
            {
                ServiceName = ServiceName,
                Price = Price

            };
            context.services.Add(serv);
            await context.SaveChangesAsync();
            return serv;
        }



       






















    }
}
