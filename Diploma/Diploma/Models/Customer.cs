using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

    }
}
