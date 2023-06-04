﻿using KidegaApp.Entities;
using KidegaApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly KidegaDbContext kidegaDbContext;

        public EFProductRepository(KidegaDbContext kidegaDbContext)
        {
            this.kidegaDbContext = kidegaDbContext;
        }

        public void Create(Product entity)
        {
            kidegaDbContext.Products.Add(entity);
            kidegaDbContext.SaveChanges();
        }

        public async Task CreateAsync(Product entity)
        {
            await kidegaDbContext.Products.AddAsync(entity);
            await kidegaDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deleting = kidegaDbContext.Products.Find(id);
            kidegaDbContext.Products.Remove(deleting);
            kidegaDbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var deleting = await kidegaDbContext.Products.FindAsync(id);
            kidegaDbContext.Products.Remove(deleting);
            await kidegaDbContext.SaveChangesAsync();
        }

        public IList<Product> GetAll()
        {
            return kidegaDbContext.Products.AsNoTracking().ToList();
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            return await kidegaDbContext.Products.AsNoTracking().ToListAsync();
        }

        public Product GetById(int id)
        {
            return kidegaDbContext.Products.AsNoTracking().First(p => p.Id == id);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await kidegaDbContext.Products.AsNoTracking().FirstAsync(p => p.Id == id);
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return kidegaDbContext.Products.AsNoTracking().Where(c => c.CategoryId == categoryId).AsEnumerable();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await kidegaDbContext.Products.AsNoTracking().Where(c => c.CategoryId == categoryId).ToListAsync();
        }

        public void Update(Product entity)
        {
            kidegaDbContext.Products.Update(entity);
            kidegaDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Product entity)
        {
            kidegaDbContext.Products.Update(entity);
            await kidegaDbContext.SaveChangesAsync();
        }
    }
}