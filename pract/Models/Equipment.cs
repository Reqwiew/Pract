using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentID { get; set; }
        public string EquipmentType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }

        
        public int ClientID { get; set; }
        public Client? Client { get; set; }

        
        public ICollection<Repair>? Repairs { get; set; }
    }
}
