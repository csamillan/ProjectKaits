using Microsoft.AspNetCore.Mvc;
using ProjectKaits.Dtos;
using ProjectKaits.Service;

namespace ProjectKaits.Controllers
{
    [ApiController]
    [Route("api/produts")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService service)
        {
            _productService = service;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] SaveProductDto dto)
        {
            _productService.SaveProduct(dto);
            return Ok();
        }
    }
}
