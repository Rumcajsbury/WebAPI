using AutoMapper;
using Evento.Core.Domain;
using Evento.Infrastructure.DTO;
using System.Linq;

namespace Evento.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(config => {
                config.CreateMap<Event, EventDTO>()
                    .ForMember(x => x.TicketCount, m => m.MapFrom(p => p.Tickets.Count()));
            })
            .CreateMapper();
    }
}
