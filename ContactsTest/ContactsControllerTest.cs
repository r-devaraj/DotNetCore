using NUnit.Framework;
using Contacts;
using Contacts.Controllers;
using Contacts.Application.Services;
using Contacts.Persistance.Database;
using Contacts.Application.Services.Interfaces;
using Contacts.Application.DTO;
using Moq;
using System.Collections.Generic;
using LiteDB;

namespace ContactsTest
{
    [TestFixture]
    public class ContactsControllerTest
    {
        
        [SetUp]
        public void Setup()
        {
       
        }

        [Test]
        public void GetAll_ReturnsList()
        {
            //Arrange
            var mockService = Mock.Of<IContactService>();
            
            //Act
            IEnumerable<ContactDto > contacts = mockService.GetAll();
            
            //Assert
            Assert.IsNotNull(contacts);
        }
        [Test]
        public void GetContact_Succeeds()
        {
            //Arrange
            var mockService = Mock.Of<IContactService>();
            ObjectId id = new ObjectId("607ccb793d1b381221bf3786");
      
            //Assert
           
            Assert.DoesNotThrow(() => { mockService.GetContact(id); });
        }

        [Test]
        public void GetContact_ReturnsNotNull()
        {
            //Arrange
            var mockService = Mock.Of<IContactService>();
            ObjectId id = new ObjectId("607ccb793d1b381221bf3786");

            //Act
            var contact = mockService.GetContact(id);

            //Assert

            Assert.IsNotNull(contact);
        }
        [Test]
        public void CreateContact_Succeeds()
        {
            //Arrange
            var mockService = Mock.Of<IContactService>();

            var contact = new ContactDto
            {
                Id = ObjectId.NewObjectId(),
                Name = new NameDto
                {
                    First = "John",
                    Middle = "",
                    Last = "Doe"
                },
                Address = new AddressDto
                {
                    Street = "123 Sample street",
                    City = "Wilmington",
                    State = "Delaware",
                    Zip = "12345"

                },
                Phones = new List<PhoneDto>
                    {
                        new PhoneDto
                        {
                            Number = "123-456-9897",
                            Type = PhoneTypeDto.Home
                        },
                        new PhoneDto
                        {
                            Number = "124-232-9802",
                            Type = PhoneTypeDto.Mobile
                        }
                    },
                Email = "124@yahoo.com"
            };

            //Act
            var id = mockService.Create(contact);

            //Assert

            Assert.IsNotNull(id);
        }
        [Test]
        public void UpdateContact_Succeeds()
        {
            //Arrange
            var mockservice = Mock.Of<IContactService>();
            var contact = new ContactDto
            {
                Id = new ObjectId("607ccb793d1b381221bf3786"),
                Name = new NameDto
                {
                    First = "Johnson",
                    Middle = "Worthington",
                    Last = "Doe"
                },
                Address = new AddressDto
                {
                    Street = "123 Sample street",
                    City = "Wilmington",
                    State = "Delaware",
                    Zip = "12345"

                },
                Phones = new List<PhoneDto>
                    {
                        new PhoneDto
                        {
                            Number = "123-456-9897",
                            Type = PhoneTypeDto.Home
                        },
                        new PhoneDto
                        {
                            Number = "124-232-9802",
                            Type = PhoneTypeDto.Mobile
                        }
                    },
                Email = "124@yahoo.com"
            };

            //Act
            var result = mockservice.Update(contact);

            //Assert

            Assert.IsTrue(result);
        }
        [Test]
        public void Delete_Succeeds()
        {
            //Arrange
            var mockservice = Mock.Of<IContactService>();
            var id = new ObjectId("607ccb793d1b381221bf3786");

            //Act
            var result = mockservice.Delete(id);

            //Assert
            Assert.IsTrue(result);


        }
    }
}