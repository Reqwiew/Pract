using Microsoft.EntityFrameworkCore;
using pract.Models;

namespace pract
{
    public class PractDbContext:DbContext
    {
        public PractDbContext(DbContextOptions options): base(options) 
        {
        
        }
        public DbSet<Service> services { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Receptionist> receptionits { get; set; }
        public DbSet<Master> masters { get; set; }
        public DbSet<Equipment> equipment { get; set; }
        public DbSet<Part> parts { get; set; }
        public DbSet<Repair> repairs { get; set; }
        public DbSet<RepairService> repairServices { get; set; }
        public DbSet<UsedPart> usedParts { get; set; }


    }
}
