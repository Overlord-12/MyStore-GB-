﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
