using KidegaApp.Entities;
using KidegaApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KidegaApp.Infrastructure.Repositories
{
    public class EFProductRepository : EFBaseRepository<KidegaDbContext, Product>, IProductRepository
    {
        private readonly KidegaDbContext _context;

        public EFProductRepository(KidegaDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProductsByCampaign(int campaignId)
        {
            return _context.Products.AsNoTracking().Where(c => c.CampaignId == campaignId).AsEnumerable();
        }

        public async Task<IEnumerable<Product>> GetProductsByCampaignAsync(int campaignId)
        {
            return await _context.Products.AsNoTracking().Where(c => c.CampaignId == campaignId).ToListAsync();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _context.Products.AsNoTracking().Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.Products.AsNoTracking().Where(c => c.CategoryId == categoryId).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByBrandNameAsync(string brandName)
        {
            return await _context.Products.AsNoTracking().Where(c => c.BrandName.Contains(brandName)).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
        {
            return await _context.Products.AsNoTracking().Where(c => c.Name.Contains(name)).ToListAsync();
        }

        IEnumerable<Product> IProductRepository.GetProductsByBrandName(string brandName)
        {
            return _context.Products.AsNoTracking().Where(c => c.BrandName.Contains(brandName)).ToList();
        }

        IEnumerable<Product> IProductRepository.GetProductsByName(string name)
        {
            return _context.Products.AsNoTracking().Where(c => c.Name.Contains(name)).ToList();
        }
    }
}
