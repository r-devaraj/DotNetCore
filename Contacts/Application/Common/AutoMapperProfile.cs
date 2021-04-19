using System;
using AutoMapper;
using Contacts.Application.DTO;
using Contacts.Domain.Models;

namespace Contacts.Application.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ContactDto, Contact>().ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<NameDto, Name>().ReverseMap();
            CreateMap<PhoneDto, Phone>().ReverseMap();
            
        }
    }
}
