﻿using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; } 
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
