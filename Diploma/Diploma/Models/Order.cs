using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diploma.Models
{
    public class Order
    {
        public int Id { get; set; }

        public List<Cart> Cart { get; set; }

        public string Addres { get; set; }

        public double TotalPrice { get; set; }


    }
}
