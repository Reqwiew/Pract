using Microsoft.EntityFrameworkCore;
using HotChocolate.Authorization;
using pract.Models;

namespace pract.Data
{
    public class Mutation
    {
        // CRUD для Client
        [Serial]
        public async Task<Client?> UpdateClient(
            [Service] PractDbContext context, Client model)
        {
            var client = await context.clients.Where(c => c.ClientID == model.ClientID).FirstOrDefaultAsync();
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

                context.clients.Update(client);
                await context.SaveChangesAsync();
            }
            return client;
        }

        [Serial]
        public async Task DeleteClient(
            [Service] PractDbContext context, long clientId)
        {
            var client = await context.clients.Where(c => c.ClientID == clientId).FirstOrDefaultAsync();
            if (client != null)
            {
                context.clients.Remove(client);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Client?> InsertClient(
            [Service] PractDbContext context, Client model)
        {
            context.clients.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        // CRUD для Equipment
        [Serial]
        public async Task<Equipment?> UpdateEquipment(
            [Service] PractDbContext context, Equipment model)
        {
            var equipment = await context.equipment.Where(e => e.EquipmentID == model.EquipmentID).FirstOrDefaultAsync();
            if (equipment != null)
            {
                if (!string.IsNullOrEmpty(model.EquipmentType))
                    equipment.EquipmentType = model.EquipmentType;
                if (!string.IsNullOrEmpty(model.Brand))
                    equipment.Brand = model.Brand;
                if (!string.IsNullOrEmpty(model.Model))
                    equipment.Model = model.Model;
                if (!string.IsNullOrEmpty(model.SerialNumber))
                    equipment.SerialNumber = model.SerialNumber;

                equipment.ClientID = model.ClientID;

                context.equipment.Update(equipment);
                await context.SaveChangesAsync();
            }
            return equipment;
        }

        [Serial]
        public async Task DeleteEquipment(
            [Service] PractDbContext context, long equipmentId)
        {
            var equipment = await context.equipment.Where(e => e.EquipmentID == equipmentId).FirstOrDefaultAsync();
            if (equipment != null)
            {
                context.equipment.Remove(equipment);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Equipment?> InsertEquipment(
            [Service] PractDbContext context, Equipment model)
        {
            context.equipment.Add(model);
            await context.SaveChangesAsync();
            return model;
        }

        // CRUD для Repair
        [Serial]
        public async Task<Repair?> UpdateRepair(
            [Service] PractDbContext context, Repair model)
        {
            var repair = await context.repairs.Where(r => r.RepairID == model.RepairID).FirstOrDefaultAsync();
            if (repair != null)
            {
                repair.StartDate = model.StartDate;
                repair.EndDate = model.EndDate;
                repair.TotalCost = model.TotalCost;
                repair.EquipmentID = model.EquipmentID;
                repair.MasterID = model.MasterID;
                repair.ReceptionistID = model.ReceptionistID;

                context.repairs.Update(repair);
                await context.SaveChangesAsync();
            }
            return repair;
        }

        [Serial]
        public async Task DeleteRepair(
            [Service] PractDbContext context, long repairId)
        {
            var repair = await context.repairs.Where(r => r.RepairID == repairId).FirstOrDefaultAsync();
            if (repair != null)
            {
                context.repairs.Remove(repair);
                await context.SaveChangesAsync();
            }
        }

        [Serial]
        public async Task<Repair?> InsertRepair(
            [Service] PractDbContext context, Repair model)
        {
            context.repairs.Add(model);
            await context.SaveChangesAsync();
            return model;
        }
    }
}
