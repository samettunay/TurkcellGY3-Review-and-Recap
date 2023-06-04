using KidegaApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.Infrastructure.Data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(KidegaDbContext dbContext)
        {
            seedCategoryIfNotExists(dbContext);
            seedProductIfNotExists(dbContext);
            seedCampaignIfNotExists(dbContext);
        }

        private static void seedCampaignIfNotExists(KidegaDbContext dbContext)
        {
            if (!dbContext.Campaigns.Any())
            {
                var campaigns = new List<Campaign>()
                {
                    new(){Name="Gece Temalı Kitaplar", Description="%50'ye varan indirim!", ImageUrl = "https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417kanonkitap.png", DiscountRate=50},
                    new(){Name="Korku ve Gerilim Seçkisi", Description="%30'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417asiyahkugu.png", DiscountRate = 30},
                    new(){Name="Kidega Dedektiflerinin Seçtikleri", Description="%40'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417canyayinlariikinci50.png", DiscountRate = 40},

                    new(){Name="Gece Temalı Kitaplar", Description="%50'ye varan indirim!", ImageUrl = "https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417kanonkitap.png", DiscountRate=50},
                    new(){Name="Korku ve Gerilim Seçkisi", Description="%30'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417asiyahkugu.png", DiscountRate = 30},
                    new(){Name="Kidega Dedektiflerinin Seçtikleri", Description="%40'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417canyayinlariikinci50.png", DiscountRate = 40},

                    new(){Name="Gece Temalı Kitaplar", Description="%50'ye varan indirim!", ImageUrl = "https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417kanonkitap.png", DiscountRate=50},
                    new(){Name="Korku ve Gerilim Seçkisi", Description="%30'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417asiyahkugu.png", DiscountRate = 30},
                    new(){Name="Kidega Dedektiflerinin Seçtikleri", Description="%40'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-kampanyalari/750x417canyayinlariikinci50.png", DiscountRate = 40},
                };

                dbContext.Campaigns.AddRange(campaigns);
                dbContext.SaveChanges();
            }
        }

        private static void seedCategoryIfNotExists(KidegaDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new(){Name="Manga", Description="..."},
                    new(){Name="Marvel", Description="..."},
                    new(){Name="DC", Description="..."},
                };

                dbContext.Categories.AddRange(categories);
                dbContext.SaveChanges();
            }
        }

        private static void seedProductIfNotExists(KidegaDbContext dbContext)
        {
            if (!dbContext.Products.Any())
            {
                var products = new List<Product>()
                {
                    new(){CategoryId=1, ImageUrl="https://loremflickr.com/320/240", Name="İblis Keser 9. Cilt", Price=10.75M, Rating=5},
                    new(){CategoryId=2, ImageUrl="https://loremflickr.com/320/240", Name="Bullet Points", Price=50M, Rating=5},
                    new(){CategoryId=2, ImageUrl="https://loremflickr.com/320/240", Name="Joker", Price=50M, Rating=5},
                    new(){CategoryId=3, ImageUrl="https://loremflickr.com/320/240", Name="All-Star Superman", Price=30.75M, Rating=5},
                    new(){CategoryId=3, ImageUrl="https://loremflickr.com/320/240", Name="Spiderman", Price=60.75M, Rating=5},
                 };

                dbContext.Products.AddRange(products);
                dbContext.SaveChanges();
            }
        }
    }
}
