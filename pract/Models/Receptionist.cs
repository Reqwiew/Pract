using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pract.Models
{
    public class Receptionist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        
        public ICollection<Repair>? Repairs { get; set; }
    }
}
