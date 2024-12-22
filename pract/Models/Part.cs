using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Part
    {
        [Key]
        public int PartID { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }

        public ICollection<UsedPart>? UsedParts { get; set; }
    }
}
