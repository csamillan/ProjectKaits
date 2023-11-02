using Microsoft.AspNetCore.Mvc;
using ProjectKaits.Service;

namespace ProjectKaits.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService service)
        {
            _clientService = service;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Ok(_clientService.GetClients());
        }

    }
}
