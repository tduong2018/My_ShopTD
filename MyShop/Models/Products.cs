using System;
using System.Collections.Generic;

namespace MyShop.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public string Describe { get; set; }
    }
}
