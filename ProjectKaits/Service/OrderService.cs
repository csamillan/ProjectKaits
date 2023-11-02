using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Service
{
    public class OrderService : IOrderService
    {
        private readonly KaitsDBContext _dbContext;

        private readonly IMapper _mapper;

        public OrderService(KaitsDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IList<OrderDto> GetOrders()
        {
            var list = _dbContext.Orders
                                .Include(p => p.Client)
                                .ToList();

            return _mapper.Map<IList<OrderDto>>(list);
        }

        public void SaveOrders(SaveOrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            _dbContext.Orders.Add(order);

            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var currentOrder = _dbContext.Orders.Find(id);

            if (currentOrder != null)
            {
                _dbContext.Remove(currentOrder);
                _dbContext.SaveChanges();
            }
        }
    }

    public interface IOrderService
    {
        IList<OrderDto> GetOrders();

        void SaveOrders(SaveOrderDto orderDto);

        void Delete(int id);
    }
}
