using System;
namespace Contacts.Application.DTO
{
    public class NameDto
    {
        public string First { get; init; }
        public string Middle { get; init; }
        public string Last { get; init; }

        public NameDto()
        {

        }
        public NameDto(string first, string middle, string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }
    }
}
