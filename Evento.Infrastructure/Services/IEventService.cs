﻿using Evento.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Evento.Infrastructure.Services
{
    public interface IEventService
    {
        Task<EventDetailsDTO> GetAsync(Guid id);
        Task<EventDetailsDTO> GetAsync(string name);
        Task<IEnumerable<EventDTO>> BrowseSAync(string name = null);
        Task CreateAsync(Guid id, string name, string description,
            DateTime startDate, DateTime endDate);
        Task AddTicketsAsync(Guid eventId, int amount, decimal price);
        Task UpdateAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);
    }
}
