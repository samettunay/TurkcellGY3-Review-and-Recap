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
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly KidegaDbContext kidegaDbContext;

        public EFCategoryRepository(KidegaDbContext kidegaDbContext)
        {
            this.kidegaDbContext = kidegaDbContext;
        }

        public void Create(Category entity)
        {
            kidegaDbContext.Categories.Add(entity);
            kidegaDbContext.SaveChanges();
        }

        public async Task CreateAsync(Category entity)
        {
            await kidegaDbContext.Categories.AddAsync(entity);
            await kidegaDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = kidegaDbContext.Categories.Find(id);
            kidegaDbContext.Categories.Remove(deleting);
            kidegaDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await kidegaDbContext.Categories.FindAsync(id);
            kidegaDbContext.Categories.Remove(deleting);
            await kidegaDbContext.SaveChangesAsync();
        }

        public IList<Category> GetAll()
        {
            return kidegaDbContext.Categories.AsNoTracking().ToList();
        }

        public async Task<IList<Category>> GetAllAsync()
        {
            return await kidegaDbContext.Categories.AsNoTracking().ToListAsync();
        }

        public Category GetById(int id)
        {
            return kidegaDbContext.Categories.AsNoTracking().First(c => c.Id == id);
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await kidegaDbContext.Categories.AsNoTracking().FirstAsync(c => c.Id == id);
        }

        public void Update(Category entity)
        {
            kidegaDbContext.Categories.Update(entity);
            kidegaDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Category entity)
        {
            kidegaDbContext.Categories.Update(entity);
            await kidegaDbContext.SaveChangesAsync();
        }
    }
}
