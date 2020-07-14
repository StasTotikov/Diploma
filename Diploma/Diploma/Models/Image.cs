using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Image
    {
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
