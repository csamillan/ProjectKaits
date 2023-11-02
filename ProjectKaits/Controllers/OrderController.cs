using Microsoft.AspNetCore.Mvc;
using ProjectKaits.Dtos;
using ProjectKaits.Service;

namespace ProjectKaits.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(_orderService.GetOrders());
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post([FromBody] SaveOrderDto dto)
        {
            _orderService.SaveOrders(dto);
            return Ok();
        }
    }
}
