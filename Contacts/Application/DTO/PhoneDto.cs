using System;
namespace Contacts.Application.DTO
{
    public class PhoneDto
    {
        public string Number { get; set; }
        public PhoneTypeDto Type { get; set; }

        public PhoneDto()
        {
        }

        public PhoneDto(string number, PhoneTypeDto type)
        {
            Number = number;
            Type = type;
        }
    }

    public enum PhoneTypeDto
    {
        Home,
        Work,
        Mobile
    }

}

