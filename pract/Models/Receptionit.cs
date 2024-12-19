using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Receptionit
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? secondName { get; set; }
        public int age { get; set; }
        public int phone { get; set; }
    }
}
