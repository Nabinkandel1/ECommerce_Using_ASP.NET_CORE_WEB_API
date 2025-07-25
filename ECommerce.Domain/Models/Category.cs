﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        = string.Empty;
        public string Description { get; set; }
        = string.Empty;
        List <Product> Products { get; set; }
    }
}
