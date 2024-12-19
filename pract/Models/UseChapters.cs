using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class UseChapters
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public decimal Cost { get; set; }
    }
}
