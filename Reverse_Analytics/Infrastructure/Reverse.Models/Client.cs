using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse.Infrastructure.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
