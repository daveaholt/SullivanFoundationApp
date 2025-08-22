using System;

namespace SullivanFoundation.Models
{
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid();
            Inactive = false;
        }

        public Guid Id { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessTitle { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public bool Inactive { get; set; }
    }
}
