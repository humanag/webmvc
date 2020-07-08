using AutoMapper;
using BAL.Domain;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC
{
    internal class MappingProfile : Profile
    {
        internal MappingProfile()
        {
            CreateMap<BaseEntity, BaseDto>().ForMember(d => d.Id, m => m.MapFrom(s => s.Id)).ReverseMap();
            CreateMap<Product, ProductDto>().ForMember(d => d.Id, m => m.MapFrom(s => s.Id)).ReverseMap();
            
            CreateMap<Category, CategoryDto>().ForMember(d => d.Id, m => m.MapFrom(s => s.Id)).ReverseMap();
            CreateMap<Category, CategorySmallDto>().ForMember(d => d.Id, m => m.MapFrom(s => s.Id));
            CreateMap<Category, CategoryWithProductContDto>().ForMember(d => d.Id, m => m.MapFrom(s => s.Id))
                .ForMember(d => d.ProductCount, m => m.MapFrom(s => s.Products.Count));

        }
    }
}