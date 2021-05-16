using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Infrastructure.Models
{
    class ProductLeftover : Product
    {
        public float LeftOver { get; set; }

        public ProductLeftover(string productName, float leftOver) : base(productName)
        {
            LeftOver = leftOver;
        }
    }
}
