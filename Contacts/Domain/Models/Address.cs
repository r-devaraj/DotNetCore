using System;
namespace Contacts.Domain.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }

        public Address()
        {
        }
        public Address(string street, string city, string state, string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
