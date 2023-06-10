using KidegaApp.Entities;
using KidegaApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public class EFBasketItemRepository : EFBaseRepository<KidegaDbContext, BasketItem>, IBasketItemRepository
    {
        private KidegaDbContext _context;
        public EFBasketItemRepository(KidegaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IList<BasketItem>> GetBasketItemsByUserNameAsync(string userName)
        {
            Basket? basket = await _context.Baskets.Include(b=>b.BasketItems)
                                                   .ThenInclude(bi=>bi.Product)
                                                   .FirstOrDefaultAsync(b => b.UserName == userName);
            return basket.BasketItems.ToList();
        }
    }
}
