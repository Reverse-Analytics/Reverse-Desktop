namespace Reverse.Infrastructure.Models
{
    public class Supplier
    {
        public int IdSupplier { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; } = "Address";

        public Supplier(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
