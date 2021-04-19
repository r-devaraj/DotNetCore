using System;
using System.Collections.Generic;
using Contacts.Domain.Models;
using LiteDB;

namespace Contacts.Persistance.Interfaces
{
    public interface IContactRepository
    {
        ObjectId Add(Contact contact);
        Contact GetContact(ObjectId id);
        IEnumerable<Contact> GetList();     
        bool Update(Contact contact);
        bool Delete(ObjectId id);
        IEnumerable<CallDetail> Getcalls();
    }
}
