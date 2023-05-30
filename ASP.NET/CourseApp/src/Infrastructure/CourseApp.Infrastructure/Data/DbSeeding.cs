using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(CourseDbContext dbContext)
        {
            seedCategoryIfNotExists(dbContext);
            seedCourseIfNotExists(dbContext);
        }

        private static void seedCategoryIfNotExists(CourseDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new(){Name="Yabancı Dil Kursları", Description="..."},
                    new(){Name="Kişisel Gelişim Kursları", Description="..."},
                    new(){Name="Yazılım Geliştirme Kursları", Description="..."},
                };

                dbContext.Categories.AddRange(categories);
                dbContext.SaveChanges();
            }
        }

        private static void seedCourseIfNotExists(CourseDbContext dbContext)
        {
            if (!dbContext.Courses.Any())
            {
                var courses = new List<Course>()
                {
                    new(){CategoryId=1, ImageUrl="https://loremflickr.com/320/240", Name="İspanyolca", Price=10.75M, Rating=5, TotalHours = 120 },
                    new(){CategoryId=2, ImageUrl="https://loremflickr.com/320/240", Name="Stres İle Mücadele", Price=50M, Rating=5, TotalHours = 100 },
                    new(){CategoryId=3, ImageUrl="https://loremflickr.com/320/240", Name="İleri C#", Price=10.75M, Rating=5, TotalHours = 120 },
                 };

                dbContext.Courses.AddRange(courses); 
                dbContext.SaveChanges();
            }
        }
    }
}
