using System;
using System.Collections.Generic;
using Contacts.Application.DTO;
using Contacts.Persistance.Interfaces;
using Contacts.Persistance.Repository;
using LiteDB;
namespace Contacts.Application.Services.Interfaces
{
    public interface IContactService
    {
        ObjectId Create(ContactDto contact);
        ContactDto GetContact(ObjectId id);
        IEnumerable<ContactDto> GetAll();
        bool Update(ContactDto contact);
        bool Delete(ObjectId id);
        IEnumerable<CallDetailDto> GetCalls();
    }
}