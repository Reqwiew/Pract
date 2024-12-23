using Faker;
using Microsoft.Graph.Models;
using pract.Models;

namespace pract.Data
{
    public class DataSeeder
    {
        public static void SeedData(PractDbContext db)
        {
            Random random = new Random();

            if (!db.services.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var service = new Service
                    {
                        ServiceName = Lorem.Sentence(2),
                        Price = (decimal)(random.NextDouble() * 100)
                    };
                    db.services.Add(service);
                }
                db.SaveChanges(); 
            }

           
            if (!db.clients.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var client = new Client
                    {
                        FullName = Name.FullName(),
                        PhoneNumber = Faker.Phone.Number(),
                        Email = Internet.Email(),
                        Address = Address.StreetAddress()
                    };
                    db.clients.Add(client);
                }

                db.SaveChanges();
            }

            if (!db.receptionits.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var receptionist = new Receptionist
                    {
                        FullName = Name.FullName(),
                        PhoneNumber = Faker.Phone.Number()
                    };
                    db.receptionits.Add(receptionist);
                }
                db.SaveChanges(); 
            }

            if (!db.masters.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var master = new Master
                    {
                        FullName = Name.FullName(),
                        Specialization = Lorem.Sentence(2),
                        PhoneNumber = Faker.Phone.Number()
                    };
                    db.masters.Add(master);
                }
                db.SaveChanges(); 
            }


            
            if (!db.equipment.Any())
            {
                if (!db.clients.Any())
                {
                    throw new InvalidOperationException("The 'clients' table is empty. Seed it first.");
                }
                var client = db.clients.ToList();
                for (int i = 0; i < 10; i++)
                {
                    var equipment = new Equipment
                    
                    {
                        EquipmentType = Lorem.Sentence(),
                        Brand = Company.Name(),
                        Model = Lorem.Sentence(),
                        SerialNumber = random.Next(100000, 999999).ToString(),
                        ClientId = client[RandomNumber.Next(0, client.Count - 1)].Id,
                    };
                    db.equipment.Add(equipment);
                }
                db.SaveChanges(); 
            }

         
            if (!db.parts.Any())
            {
                for (int i = 0; i < 10; i++)
                {
                    var part = new Part
                    {
                        PartName = Lorem.Sentence(2),
                        Price = (decimal)(random.NextDouble() * 50)
                    };
                    db.parts.Add(part);
                }
            }

           
            if (!db.repairs.Any())
            {
                if (!db.equipment.Any() || !db.masters.Any() || !db.receptionits.Any())
                {
                    throw new InvalidOperationException(
                        "One of the required tables ('equipment', 'masters', 'receptionits') is empty. Seed them first."
                    );
                }

                var equ = db.equipment.ToList();
                var mas = db.masters.ToList();
                var recept = db.receptionits.ToList();

                for (int i = 0; i < 10; i++)
                {
                    var repair = new Repair
                    {
                        StartDate = DateTime.Now.AddDays(-random.Next(1, 30)),
                        EndDate = DateTime.Now.AddDays(random.Next(1, 30)),
                        TotalCost = (decimal)(random.NextDouble() * 200),
                        EquipmentId = equ[RandomNumber.Next(0, equ.Count - 1)].Id,
                        MasterId = mas[RandomNumber.Next(0, mas.Count - 1)].Id,
                        ReceptionistId = recept[RandomNumber.Next(0, recept.Count - 1)].Id,
                    };
                    db.repairs.Add(repair);
                }
                db.SaveChanges(); 
            }

         
            if (!db.repairServices.Any())
            {
                if (!db.repairs.Any() || !db.services.Any())
                {
                    throw new InvalidOperationException(
                        "One of the required tables ('repairs', 'services') is empty. Seed them first."
                    );
                }
                var repair = db.repairs.ToList();
                var serv = db.services.ToList();



                for (int i = 0; i < 10; i++)
                {
                    var repairService = new RepairService
                    {
                        RepairId = repair[RandomNumber.Next(0, repair.Count - 1)].Id,
                        ServiceId = serv[RandomNumber.Next(0, serv.Count - 1)].Id,
                    };
                    db.repairServices.Add(repairService);
                }
            }

            
            if (!db.usedParts.Any())
            {
                if (!db.repairs.Any() || !db.parts.Any())
                {
                    throw new InvalidOperationException(
                        "One of the required tables ('repairs', 'parts') is empty. Seed them first."
                    );
                }
                var repair = db.repairs.ToList();
                var part = db.parts.ToList();

                for (int i = 0; i < 10; i++)
                {
                    var usedPart = new UsedPart
                    {
                        RepairId = repair[RandomNumber.Next(0, repair.Count - 1)].Id,
                        PartId = part[RandomNumber.Next(0, part.Count - 1)].Id,
                        Quantity = random.Next(1, 5)
                    };
                    db.usedParts.Add(usedPart);
                }
            }

            db.SaveChanges();
        }
    }
}
