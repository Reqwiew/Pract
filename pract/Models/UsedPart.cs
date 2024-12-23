using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pract.Models
{
    public class UsedPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [ForeignKey("RepairId")]
        public long RepairId { get; set; }
        public Repair? Repair { get; set; }
        [ForeignKey("PartId")]
        public long PartId { get; set; }
        public Part? Part { get; set; }

        public int Quantity { get; set; }
    }
}
