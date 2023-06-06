using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetCoursesByCategory(int categoryId);
        Task<IEnumerable<Course>> GetCoursesByCategoryAsync(int categoryId);
        Task<IEnumerable<Course>> GetCoursesByName(string name);

    }
}
