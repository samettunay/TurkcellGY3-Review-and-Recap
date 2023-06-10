using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public interface IBasketRepository : IRepository<Basket>
    {
        Task<Basket> GetBasketByUserNameAsync(string userName);
    }
}
