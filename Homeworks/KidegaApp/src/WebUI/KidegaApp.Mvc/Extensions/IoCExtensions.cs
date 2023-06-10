using KidegaApp.Infrastructure.Data;
using KidegaApp.Infrastructure.Repositories;
using KidegaApp.Services.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace KidegaApp.Mvc.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<ICampaignService, CampaignService>();
            services.AddScoped<ICampaignRepository, EFCampaignRepository>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IBasketRepository, EFBasketRepository>();
            services.AddScoped<IBasketItemRepository, EFBasketItemRepository>();

            services.AddDbContext<KidegaDbContext>(opt => opt.UseSqlServer(connectionString));

            return services;
        }
    }
}
