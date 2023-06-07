using KidegaApp.Entities;
using KidegaApp.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _repository.GetUserByUserNameAsync(userName);
        }

        public async Task UpdateAsync(User user)
        {
            await _repository.UpdateAsync(user);
        }

        public Task<User> ValidateUserAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
