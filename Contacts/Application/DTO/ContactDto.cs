using System;
using System.Collections.Generic;
using LiteDB;

namespace Contacts.Application.DTO
{
    public class ContactDto
    {
        public ObjectId Id { get; set; }
        public NameDto Name { get; init; }
        public AddressDto Address { get; init; }
        public IList<PhoneDto> Phones { get; init; } = new List<PhoneDto>();
        public string Email { get; init; }

        public ContactDto()
        {

        }

        public ContactDto(NameDto name, AddressDto address, IList<PhoneDto> phones, string email)
        {
            Id = ObjectId.NewObjectId();
            Name = name;
            Address = address;
            Phones = phones;
            Email = email;

        }
    }
}
