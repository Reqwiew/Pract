using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }
        public string? NameService { get; set; }
        public decimal? Price { get; set; }

    }
}
