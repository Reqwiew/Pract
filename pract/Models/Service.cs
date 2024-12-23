using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pract.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; } 
        public string ServiceName { get; set; }
        public decimal Price { get; set; }

        public ICollection<RepairService>? RepairServices { get; set; }
    }
}
