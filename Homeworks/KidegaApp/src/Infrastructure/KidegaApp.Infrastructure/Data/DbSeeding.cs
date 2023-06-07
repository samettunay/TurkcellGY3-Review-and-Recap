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
            seedCampaignIfNotExists(dbContext);
            seedProductIfNotExists(dbContext);
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

                    new(){Name="Alfa Yayın Grubu Ciltli Kitaplar", Description="%45'ye varan indirim!", ImageUrl = "https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-altbanner/alfaciltli.png", DiscountRate=45},
                    new(){Name="Yabancı Yayınevi Kampanyalı Kitaplar", Description="%89'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-altbanner/yabanciyayinevi.png", DiscountRate = 89},
                    new(){Name="Çizgi Roman", Description="%50'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-altbanner/cizgiromancoksatan.png", DiscountRate = 50},

                    new(){Name="Can Yayınları Kısa Klasikler", Description="%50'ye varan indirim!", ImageUrl = "https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-altbanner/cankisaklasikler.png", DiscountRate=50},
                    new(){Name="Uzakdoğu Edebiyatı", Description="%30'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-altbanner/uzakdoguedeniyati.png", DiscountRate = 30},
                    new(){Name="İletişim Yayınevi & Metis Yayınları Seçili Kitaplar", Description="%40'a varan indirim!", ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/2023-mayis-altbanner/metisiletisim.png", DiscountRate = 40},
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
                    new(){CategoryId=1, ImageUrl="https://img1-kidega.mncdn.com/UPLOAD/iblis-keser-9-kapak.jpg", Name="İblis Keser 9. Cilt", BrandName = "Koyoharu Gotouge", Price=10.75M, Rating=5, CampaignId=4},
                    new(){CategoryId=2, ImageUrl="https://img1-kidega.mncdn.com/mnresize/260/399/UPLOAD/urunler/9786257543125.jpg", Name="Bullet Points", BrandName = "Michael Straczynski", Price=50M, Rating=5, CampaignId=4},
                    new(){CategoryId=2, ImageUrl="https://img1-kidega.mncdn.com/mnresize/260/399/UPLOAD/urunler/9786057712448.jpg", Name="Joker", BrandName = "DC", Price=50M, Rating=5, CampaignId=4},
                    new(){CategoryId=3, ImageUrl="https://img1-kidega.mncdn.com/mnresize/200/307/UPLOAD/urunler/9789750850677.jpg", Name="All-Star Superman", BrandName = "Marvel", Price=30.75M, Rating=5, CampaignId=4},
                    new(){CategoryId=3, ImageUrl="https://img1-kidega.mncdn.com/mnresize/200/307/UPLOAD/urunler/9786057784551.jpg", Name="Spiderman", BrandName = "Marvel", Price=60.75M, Rating=5, CampaignId=4},
                 };

                dbContext.Products.AddRange(products);
                dbContext.SaveChanges();
            }
        }
    }
}
