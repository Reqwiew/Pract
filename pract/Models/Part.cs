using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pract.Models
{
    public class Part
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }

        public ICollection<UsedPart>? UsedParts { get; set; }
    }
}
