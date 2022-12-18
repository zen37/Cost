using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cost_DataAccess;
using Cost_Models;


namespace Cost_Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Component, ComponentDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();

        }
    }
}
