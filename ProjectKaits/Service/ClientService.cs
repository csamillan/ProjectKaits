using AutoMapper;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Service
{
    public class ClientService : IClientService
    {
        private readonly KaitsDBContext _dbContext;

        private readonly IMapper _mapper;

        public ClientService(KaitsDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IList<ClientDto> GetClients()
        {
            var list = _dbContext.Clients
                                .ToList();

            return _mapper.Map<IList<ClientDto>>(list);
        }
    }

    public interface IClientService
    {
        IList<ClientDto> GetClients();
    }
}
