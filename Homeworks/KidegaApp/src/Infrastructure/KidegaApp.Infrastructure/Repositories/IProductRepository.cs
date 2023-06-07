using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsByCategory(int categoryId);
        IEnumerable<Product> GetProductsByCampaign(int campaignId);
        IEnumerable<Product> GetProductsByBrandName(string brandName);
        IEnumerable<Product> GetProductsByName(string name);

        Task<IEnumerable<Product>> GetProductsByCampaignAsync(int campaignId);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
        Task<IEnumerable<Product>> GetProductsByBrandNameAsync(string brandName);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
    }
}
