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
    public class EFUserRepository : EFBaseRepository<KidegaDbContext, User>, IUserRepository
    {
        private readonly KidegaDbContext _context;
        public EFUserRepository(KidegaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.UserName == userName);
        }
    }
}
