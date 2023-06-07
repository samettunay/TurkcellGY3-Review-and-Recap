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

        public async Task<IList<BasketItem>> GetAllByBasketIdAsync(int basketId)
        {
            return await _context.BasketItems.Where(item => item.BasketId == basketId).ToListAsync();
        }
    }
}
