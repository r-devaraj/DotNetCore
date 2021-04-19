using System;
namespace Contacts.Application.DTO
{
    public class CallDetailDto
    {
      
        public string First { get; init; }
        public string Middle { get; init; }
        public string Last { get; init; }
        public string Phone { get; init; }
        public CallDetailDto()
        {

        }
        public CallDetailDto(string first, string middle, string last, string phone)
        {
            First = first;
            Middle = middle;
            Last = last;
            Phone = phone;

        }
    }
}
