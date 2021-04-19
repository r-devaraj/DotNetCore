using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contacts.Application.DTO;
using Contacts.Application.Services.Interfaces;
using LiteDB;

namespace Contacts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService = null;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        // GET: api/Contacts
        [HttpGet]
        public IEnumerable<ContactDto> Get()
        {
            return _contactService.GetAll();
        }

        // GET: api/Contacts/5
        [HttpGet("{id}", Name = "Get")]
        public ContactDto Get(ObjectId id)
        {
            return _contactService.GetContact(id);
        }

        // POST: api/Contacts
        [HttpPost]
        public void Post([FromBody] ContactDto contact)
        {
            _contactService.Create(contact);

        }

        // PUT: api/Contacts/5
        [HttpPut("{id}")]
        public void Put([FromBody] ContactDto contact)
        {
            
            _contactService.Update(contact);
        }

        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public void Delete(ObjectId id)
        {
            _contactService.Delete(id);
        }
    }
}
