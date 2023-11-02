using AutoMapper;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Mappers
{
    public class ProductMapper : Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<SaveProductDto, Product>();
        }
    }
}
