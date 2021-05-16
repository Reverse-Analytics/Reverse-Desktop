﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Models
{
    class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName)
        {
            ProductName = productName;
        }
    }
}
