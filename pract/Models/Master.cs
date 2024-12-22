﻿using System.ComponentModel.DataAnnotations;

namespace pract.Models
{
    public class Master
    {
        [Key]
        public int MasterID { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<Repair>? Repairs { get; set; }
    }
}
