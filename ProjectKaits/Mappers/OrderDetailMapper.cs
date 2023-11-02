using AutoMapper;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Mappers
{
    public class OrderDetailMapper : Profile
    {
        public OrderDetailMapper()
        {
            CreateMap<OrderDetail, OrderDetailDto>();
            CreateMap<SaveOrderDetailDto, OrderDetail>();
        }
    }
}
