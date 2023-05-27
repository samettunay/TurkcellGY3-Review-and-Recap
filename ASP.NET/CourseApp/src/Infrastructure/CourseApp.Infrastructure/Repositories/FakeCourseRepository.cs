using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public class FakeCourseRepository : ICourseRepository
    {
        private readonly List<Course> _courses;

        public FakeCourseRepository()
        {
            _courses = new()
            {
                new() { Id = 1, Name="Course X", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 2, Name="Course Y", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 3, Name="Course Z", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 4, Name="Course Q", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},

                new() { Id = 6, Name="Course X2", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 7, Name="Course Y2", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 8, Name="Course Z2", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 9, Name="Course Q2", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},

                new() { Id = 10, Name="Course X3", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 11, Name="Course Y3", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 12, Name="Course Z3", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 13, Name="Course Q3", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},

                new() { Id = 14, Name="Course X4", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 15, Name="Course Y4", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 16, Name="Course Z4", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
                new() { Id = 17, Name="Course Q4", Description = "Description X", Price = 1, Rating = 4, TotalHours = 20},
            };
        }

        public Course? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Course?> GetAll()
        {
            return _courses;
        }

        public Task<IList<Course?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Course> GetAllWithPredicate(Expression<Predicate<Course>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Course?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourses(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
