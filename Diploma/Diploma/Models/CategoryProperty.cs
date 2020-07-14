using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Diploma.Models
{
    public class CategoryProperty
    {
        //[Required]
        //public int Id { get; set; }

        //[Required]
        [ForeignKey("CategoryId")]
        public   Category Category { get; set; }

        //[Required]
        [ForeignKey("PropertyId")]
        public  Property Property { get; set; }

        public int CategoryId { get; set; }
        public int PropertyId { get; set; }

        public List<ProductValue> ProductValues { get; set; }

        public CategoryProperty()
        {
            ProductValues = new List<ProductValue>();
        }
    }
}
