using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<CategoryProperty> CategoryProperties { get; set; }
        public Property()
        {
            CategoryProperties = new List<CategoryProperty>();
        }
    }
}
