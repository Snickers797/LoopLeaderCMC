using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoopLeader.Domain.Entities;

namespace LoopLeader.Models
{
    public class ProductViewModel
    {
        public int ProductID { get; set; }
        public List<Product> ProductList { get; set; }
    }
}