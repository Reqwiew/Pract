using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Master
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? secondName { get; set; }
        public int Phonenumber { get; set; }
        public int age { get; set; }
    }
}
