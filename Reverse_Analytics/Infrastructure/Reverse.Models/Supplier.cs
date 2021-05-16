using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Infrastructure.Models
{
    public class Supplier
    {
        public int IdSupplier { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Supplier(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
