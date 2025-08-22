using System;
using System.Collections.Generic;

namespace SullivanFoundation.Models
{
    public class Account
    {
        public Account()
        {
            Id = Guid.NewGuid();
        }

        public Account(string firstName, string middleName, string lastName)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Inactive = false;
        }

        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Address HomeAddress { get; set; } = new();
        public Address BusinessAddress { get; set; } = new();
        public Address OtherAddress { get; set; } = new();
        List<Email> Emails { get; set; } = new();
        public bool Inactive { get; set; }
    }
}
