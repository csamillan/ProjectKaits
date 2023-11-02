using AutoMapper;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Mappers
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<SaveOrderDto, Order>();
        }
    }
}
