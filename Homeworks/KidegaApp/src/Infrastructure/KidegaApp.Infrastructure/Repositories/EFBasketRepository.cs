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
    public class EFBasketRepository : EFBaseRepository<KidegaDbContext, Basket>, IBasketRepository
    {
        private readonly KidegaDbContext _context;
        public EFBasketRepository(KidegaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Basket> GetByUserIdAsync(int userId)
        {
            return await _context.Baskets.FirstOrDefaultAsync(b => b.UserId == userId);
        }
    }
}
