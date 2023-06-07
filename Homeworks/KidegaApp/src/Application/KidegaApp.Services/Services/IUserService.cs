using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Services.Services
{
    public interface IUserService
    {
        Task<User> GetUserByUserNameAsync(string userName);
        Task<User> ValidateUserAsync(string username, string password);
        Task UpdateAsync(User user);
    }
}
