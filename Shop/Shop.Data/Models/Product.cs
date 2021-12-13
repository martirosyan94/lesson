﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<ProductOrder> ProductOrders { get; set; } = new HashSet<ProductOrder>();
    }
}
