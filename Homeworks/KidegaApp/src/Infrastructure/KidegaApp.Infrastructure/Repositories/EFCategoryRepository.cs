using KidegaApp.Entities;
using KidegaApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public class EFCategoryRepository : EFBaseRepository<KidegaDbContext, Category>, ICategoryRepository
    {
        private readonly KidegaDbContext _context;

        public EFCategoryRepository(KidegaDbContext context) : base(context)
        {
        }
    }
}
