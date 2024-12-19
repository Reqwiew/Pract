using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class AcceptTec
    {
        [Key]
        public Guid Id { get; set; }
        public string? title { get; set; }
        public DateTime DateReg { get; set; }
        public string? Description { get; set; }
    }
}
