using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class UsedPart
    {
        [Key]
        public int UsedPartID { get; set; }
        public int RepairID { get; set; }
        public Repair? Repair { get; set; }

        public int PartID { get; set; }
        public Part? Part { get; set; }

        public int Quantity { get; set; }
    }
}
