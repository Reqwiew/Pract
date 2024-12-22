using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; } 
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public ICollection<RepairService>? RepairServices { get; set; }
    }
}
