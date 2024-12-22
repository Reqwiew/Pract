using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Receptionist
    {
        [Key]
        public int ReceptionistID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        
        public ICollection<Repair>? Repairs { get; set; }
    }
}
