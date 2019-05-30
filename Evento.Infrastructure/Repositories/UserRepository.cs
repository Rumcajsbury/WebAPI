using System;
using System.Collections.Generic;
using Evento.Core.Repositories;
using System.Text;
using Evento.Core.Domain;
using System.Threading.Tasks;
using System.Linq;

namespace Evento.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static readonly ISet<User> _users = new HashSet<User>();

        public async Task<User> GetAsync(Guid id)
            => await Task.FromResult(_users.SingleOrDefault(user => user.Id == id));

        public async Task<User> GetAsync(string email)
            => await Task.FromResult(_users.SingleOrDefault(user 
                => user.Email.ToLowerInvariant() == email.ToLowerInvariant()));

        public async Task AddAsync(User user)
        {
            _users.Add(user);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(User user)
        {
            _users.Remove(user);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(User user)
        {
            await Task.CompletedTask;
        }
    }
}
