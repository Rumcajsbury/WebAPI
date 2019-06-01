using Evento.Infrastructure.Commands.Events;
using System.Collections.Generic;

namespace Evento.Infrastructure.DTO
{
    public class EventDetailsDTO : EventDTO
    {
        public IEnumerable<TicketDTO> Ticekts { get; set; }
    }
}
