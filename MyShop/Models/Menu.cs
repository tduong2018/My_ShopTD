using System;
using System.Collections.Generic;

namespace MyShop.Models
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
    }
}
