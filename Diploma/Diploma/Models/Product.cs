using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]

        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
        [Required]

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [Range(1,Double.MaxValue, ErrorMessage = "Значение должно быть больше или равно 1")]
        public double Price { get; set; }

        [Required]
        [Range(1, Int32.MaxValue, ErrorMessage = "Значение должно быть больше или равно 1")]
        public int Amount { get; set; }

        public List<ProductValue> ProductValues { get; set; }

        public List<Image> Images { get; set; }

    }
}
