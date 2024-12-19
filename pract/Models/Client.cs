using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? secondName { get; set; }
        public string? Mail { get; set; }
        public int phoneNumber { get; set; }
    }
}
