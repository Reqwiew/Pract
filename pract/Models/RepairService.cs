using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pract.Models
{
    public class RepairService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }


        [ForeignKey("RepairId")]
        public long RepairId { get; set; }
        public Repair? Repair { get; set; }

        [ForeignKey("ServiceId")]
        public long ServiceId { get; set; }
        public Service? Service { get; set; }
    }
}
