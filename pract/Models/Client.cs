using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        
        public ICollection<Equipment>? Equipments { get; set; }
    }
}
