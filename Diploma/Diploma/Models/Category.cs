using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Diploma.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]  
        [Range(1, Int32.MaxValue, ErrorMessage = "Значение должно быть больше или равно 1")]
        public int LevelCategory { get; set; }

        public Nullable<int> ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }

        //public virtual List<Category> ChildCategories { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        public List<CategoryProperty> CategoryProperties { get; set; }
        public Category()
        {
            CategoryProperties = new List<CategoryProperty>();
        }
    }
}
