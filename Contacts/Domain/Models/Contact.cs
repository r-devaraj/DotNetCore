using System;
using System.Collections.Generic;
using LiteDB;

namespace Contacts.Domain.Models
{
    public class Contact
    {
        public ObjectId Id { get; set; }
        public Name Name { get; init; }
        public Address Address { get; init; }
        public IList<Phone> Phones { get; init; } = new List<Phone>();
        public string Email { get; init; }

        public Contact()
        {

        }

        public Contact(Name name, Address address, IList<Phone> phones, string email)
        {
            Id = ObjectId.NewObjectId();
            Name = name;
            Address = address;
            Phones = phones;
            Email = email;

        }
    }
}
