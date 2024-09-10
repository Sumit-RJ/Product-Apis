using AutoMapper;
using Product_Apis.DTOs;
using Product_Apis.Models;

namespace Product_Apis.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile() {

            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
