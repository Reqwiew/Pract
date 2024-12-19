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
        public DbSet<Receptionit> receptionits { get; set; }
        public DbSet<Master> masters { get; set; }
        public DbSet<AcceptTec> acceptTecs { get; set; }
        public DbSet<CompliteWork> compliteWorks { get; set; }
        public DbSet<UseChapters> UseChapters { get; set; }


    }
}
