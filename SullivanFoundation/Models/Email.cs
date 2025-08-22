using System;

namespace SullivanFoundation.Models
{
    public class Email
    {
        public Email(string address)
        {
            Id = Guid.NewGuid();
            EmailAddress = address;
            Inactive = false;
        }

        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public  bool Inactive { get; set; }
    }
}
