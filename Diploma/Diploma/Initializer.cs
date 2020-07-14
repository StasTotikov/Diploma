using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diploma.Models;
namespace Diploma
{
    public class Initializer
    {
        public static void Initialize(ShopContext context)
        {
            if(!context.Categories.Any())
            {
                context.AddRange(
                    new Category
                    {
                        Title = "Смартфоны",
                        LevelCategory = 1
                    },
                    new Category
                    {
                        Title = "Ноутбуки",
                        LevelCategory = 1
                    },
                    new Category
                    {   
                        Title = "Телевизоры",
                        LevelCategory = 1
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
