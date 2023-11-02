using AutoMapper;
using ProjectKaits.Dtos;
using ProjectKaits.Model;

namespace ProjectKaits.Mappers
{
    public class ClientMapper : Profile
    {
        public ClientMapper()
        {
            CreateMap<Client, ClientDto>();
        }
    }
}
