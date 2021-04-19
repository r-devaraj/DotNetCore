using System;
namespace Contacts.Application.DTO
{
    public class AddressDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public AddressDto()
        {
        }

        public AddressDto(string street, string city, string state, string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
