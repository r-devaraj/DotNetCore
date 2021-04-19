using System;
namespace Contacts.Domain.Models
{
    public class CallDetail
    {
        public string First { get; init; }
        public string Middle { get; init; }
        public string Last { get; init; }
        public string Phone { get; init; }
        public CallDetail()
        {

        }
        public CallDetail(string first, string middle, string last, string phone)
        {
            First = first;
            Middle = middle;
            Last = last;
            Phone = phone;

        }
    }
}
