using System;

namespace Reverse.Infrastructure.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int BillNumber { get; set; }
        public int Amount { get; set; }
        public decimal SalePrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal CashAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal LeftAmount { get; set; }
        public double BoxAmount { get; set; }
        public DateTime SoldDate  { get; set; }

        public int ClientId { get; set; }
        public int ProductId { get; set; }

        public Client Client { get; set; }
        public Product Product { get; set; }
    }
}
