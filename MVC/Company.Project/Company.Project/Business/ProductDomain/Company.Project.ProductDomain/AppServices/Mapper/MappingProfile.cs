using AutoMapper;
using Company.Project.ProductDomain.AppServices.DTOs;
using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.AppServices.Mapper
{
    /// <summary>
    /// Mapping Profile
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile() : base("MappingProfile")
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<BookReadingEventDTO, BookReadingEvent>().ReverseMap();
            CreateMap<CommentEventDTO, CommentEvent>().ReverseMap();
            CreateMap<InviteeEventDTO, InviteeEvent>().ReverseMap();
            CreateMap<LookUpCategoryDTO, LookUpCategory>().ReverseMap();
            CreateMap<LookUpDTO, LookUp>().ReverseMap();
            CreateMap<UserRegistrationDTO, UserRegistration>().ReverseMap();
        }
    }
}
