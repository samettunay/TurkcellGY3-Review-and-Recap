using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public interface IBasketItemRepository : IRepository<BasketItem>
    {
        Task<IList<BasketItem>> GetBasketItemsByUserNameAsync(string userName);
    }
}
