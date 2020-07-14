using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Cart
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public Product Product { get; set; }

        [Required]
        [Range(1,100,ErrorMessage = "Количество товара должно быть больше 0 и меньше 100" )]
        public int Amount { get; set; }

        [Required]
        public double Cost { get; set; }


    }
}
