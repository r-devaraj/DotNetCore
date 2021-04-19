using System;
using Contacts.Persistance;
using Contacts.Persistance.Interfaces;
using Contacts.Persistance.Database;
using Contacts.Persistance.Common;
using Contacts.Domain;
using Contacts.Domain.Models;
using System.Collections.Generic;
using LiteDB;
using Microsoft.Extensions.Options;

namespace Contacts.Persistance.Repository
{
    public class ContactRepository: IContactRepository
    {
        private readonly LiteDbContext _liteDbContext = null;
        private readonly ILiteCollection<Contact> _contacts = null;
        private readonly LiteDatabase _liteDatabase = null;
        
     
        public ContactRepository()
        {
            
        }
        public ContactRepository(LiteDbContext liteDbContext)
        {

            _liteDbContext = liteDbContext;
           
            _contacts = _liteDbContext.LiteDatabase.GetCollection<Contact>("Contacts");
             
        }

        public ObjectId Add(Contact contact)
        {
            return _contacts.Insert(contact);

        }

        public bool Delete(ObjectId id)
        {
            return _contacts.Delete(id);
        }

        public IEnumerable<CallDetail> Getcalls()
        {
            throw new NotImplementedException();
        }

        public Contact GetContact(ObjectId id)
        {
            return _contacts.FindById(id);
            
        }
     
        public IEnumerable<Contact> GetList()
        {
            return _contacts.FindAll();
        }

        public bool Update(Contact contact)
        {
            Contact entity = _contacts.FindById(contact.Id);
            entity = contact;
            return _contacts.Update(entity);
         
        }

    }
}
