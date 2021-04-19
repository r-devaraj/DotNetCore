using System;
using LiteDB;

namespace Contacts.Persistance.Interfaces
{
    public interface ILiteDbContext
    {
        LiteDatabase liteDatabase { get; set; }
    }
}
