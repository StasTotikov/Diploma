using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diploma.Models
{
    public class ProductValue
    {
        public int Id { get; set; }

        [Required]
        public CategoryProperty CategoryProperty { get; set; }
        [Required]
        public int CategoryPropertyId { get; set; }

        [Required]
        public string Value { get; set; }


      
      

    }
}
