using System;
namespace Contacts.Domain.Models
{
    public class Name
    {
        public string First { get; init; }
        public string Middle { get; init; }
        public string Last { get; init; }

        public Name()
        {

        }
        public Name(string first, string middle, string last)
        {
            First = first;
            Middle = middle;
            Last = last;
        }
    }

}
