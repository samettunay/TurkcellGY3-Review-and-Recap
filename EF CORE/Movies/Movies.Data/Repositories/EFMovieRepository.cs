using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Data.Repositories
{
    public class EFMovieRepository : IMovieRepository
    {
        public Task CreateAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Movie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Movie>> SearchMoviesByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
