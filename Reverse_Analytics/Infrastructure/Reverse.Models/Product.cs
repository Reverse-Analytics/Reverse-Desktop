using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Infrastructure.Models
{
    public class Product
    {
        public Product(string productName)
        {
            ProductName = productName;
        }

        public int IdProduct { get; set; }
        public int Volume { get; set; }
        public int AmountInStore { get; set; }
        public int AmountSold { get; set; }
        public string ProductName { get; set; }
        public decimal StandardPrice { get; set; }
        public decimal IncomePrice { get; set; }
        public decimal Profit { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
