using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class RepairService
    {
        [Key]
        public int RepairServiceID { get; set; }

       
        public int RepairID { get; set; }
        public Repair? Repair { get; set; }

        public int ServiceID { get; set; }
        public Service? Service { get; set; }
    }
}
