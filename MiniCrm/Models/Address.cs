namespace MiniCrm.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;

        public AddressType Type { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }

    public enum AddressType { Home, Work, Other }
}
