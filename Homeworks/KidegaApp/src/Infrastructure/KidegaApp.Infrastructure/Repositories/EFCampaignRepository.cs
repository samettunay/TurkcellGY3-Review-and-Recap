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
    public class EFCampaignRepository : ICampaignRepository
    {
        private readonly KidegaDbContext kidegaDbContext;

        public EFCampaignRepository(KidegaDbContext kidegaDbContext)
        {
            this.kidegaDbContext = kidegaDbContext;
        }

        public void Create(Campaign entity)
        {
            kidegaDbContext.Campaigns.Add(entity);
            kidegaDbContext.SaveChanges();
        }

        public async Task CreateAsync(Campaign entity)
        {
            await kidegaDbContext.Campaigns.AddAsync(entity);
            await kidegaDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = kidegaDbContext.Campaigns.Find(id);
            kidegaDbContext.Campaigns.Remove(deleting);
            kidegaDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await kidegaDbContext.Campaigns.FindAsync(id);
            kidegaDbContext.Campaigns.Remove(deleting);
            await kidegaDbContext.SaveChangesAsync();
        }

        public IList<Campaign> GetAll()
        {
            return kidegaDbContext.Campaigns.AsNoTracking().ToList();
        }

        public async Task<IList<Campaign>> GetAllAsync()
        {
            return await kidegaDbContext.Campaigns.AsNoTracking().ToListAsync();
        }

        public Campaign GetById(int id)
        {
            return kidegaDbContext.Campaigns.AsNoTracking().First(p => p.Id == id);
        }

        public async Task<Campaign> GetByIdAsync(int id)
        {
            return await kidegaDbContext.Campaigns.AsNoTracking().FirstAsync(p => p.Id == id);
        }

        public Task<Campaign> GetWithPredicateAsync(Expression<Func<Campaign, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign entity)
        {
            kidegaDbContext.Campaigns.Update(entity);
            kidegaDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Campaign entity)
        {
            kidegaDbContext.Campaigns.Update(entity);
            await kidegaDbContext.SaveChangesAsync();
        }
    }
}
