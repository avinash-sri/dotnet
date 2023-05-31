using AutoMapper;
using Company.Project.ProductDomain.AppServices.DTOs;
using Company.Project.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Project.Web.Mapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile() : base("WebMappingProfile")
        {
            CreateMap<ProductViewModel, ProductDTO>().ReverseMap();
            CreateMap<BookReadingEventModel, BookReadingEventDTO>().ReverseMap();
            CreateMap<CommentEventModel, CommentEventDTO>().ReverseMap();
            CreateMap<InviteeEventModel, InviteeEventDTO>().ReverseMap();
            CreateMap<LookUpModel, LookUpDTO>().ReverseMap();
            CreateMap<LookUpCategoryModel, LookUpCategoryDTO>().ReverseMap();
            CreateMap<UserRegistrationModel, UserRegistrationDTO>().ReverseMap();
        }
    }
}
