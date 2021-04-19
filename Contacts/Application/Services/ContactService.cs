using System;
using System.Collections.Generic;
using Contacts.Application.DTO;
using Contacts.Application.Services.Interfaces;
using Contacts.Persistance.Interfaces;
using Contacts.Domain.Models;
using AutoMapper;
using LiteDB;

namespace Contacts.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository = null;
        private IMapper _mapper = null;
        public ContactService(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public ObjectId Create(ContactDto contact)
        {
            Contact entity = _mapper.Map<Contact>(contact);
            return _contactRepository.Add(entity);
        }

        public bool Delete(ObjectId id)
        {
            return _contactRepository.Delete(id); 
        }

        public ContactDto GetContact(ObjectId id)
        {
            Contact contact = _contactRepository.GetContact(id);
            return _mapper.Map<ContactDto>(contact);
        }

        public IEnumerable<ContactDto> GetAll()
        {
            var contacts = _contactRepository.GetList();
            return _mapper.Map<IEnumerable<ContactDto>>(contacts);
        }

        public bool Update(ContactDto contact)
        {
            var entity = _mapper.Map<Contact>(contact);
            return _contactRepository.Update(entity);
        }

        public IEnumerable<CallDetailDto> GetCalls()
        {
            return null;
        }
    }
}
