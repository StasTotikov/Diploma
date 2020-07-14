using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
