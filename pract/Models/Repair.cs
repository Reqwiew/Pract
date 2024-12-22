using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Repair
    {
        [Key]
        public int RepairID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal TotalCost { get; set; }

        
        public int EquipmentID { get; set; }
        public Equipment? Equipment { get; set; }

        public int MasterID { get; set; }
        public Master? Master { get; set; }

        public int ReceptionistID { get; set; }
        public Receptionist? Receptionist { get; set; }

       
        public ICollection<RepairService>? RepairServices { get; set; }
        public ICollection<UsedPart>? UsedParts { get; set; }
    }
}
