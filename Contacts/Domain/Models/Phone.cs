using System;
namespace Contacts.Domain.Models
{
    public class Phone
    {
        public string Number { get; set; }
        public PhoneType Type { get; set; }

        public Phone()
        {
        }

        public Phone(string number, PhoneType type)
        {
            Number = number;
            Type = type;
        }
    }

    public enum PhoneType
    {
        Home,
        Work,
        Mobile
    }
}
