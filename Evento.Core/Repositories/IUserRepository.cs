using Evento.Core.Domain;
using System;
using System.Threading.Tasks;

namespace Evento.Core.Repositories
{
    interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);
    }
}
