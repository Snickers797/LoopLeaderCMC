using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LoopLeader.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        [Required]

        public string ProductName { get; set; }
        [Required]

        public string Category { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public bool InStock { get; set; }

        //public Decimal Shipping { get; set; }
    }
}
