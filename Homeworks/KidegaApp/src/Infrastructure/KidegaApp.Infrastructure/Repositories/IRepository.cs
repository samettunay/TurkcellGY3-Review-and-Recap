using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

        Task<IList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

        IList<T> GetAll();
        T GetById(int id);
    }
}
