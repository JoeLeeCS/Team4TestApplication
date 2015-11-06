﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class Product
    {
        public Product(SKU sku, string name, double price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }

        public SKU Sku { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

}
