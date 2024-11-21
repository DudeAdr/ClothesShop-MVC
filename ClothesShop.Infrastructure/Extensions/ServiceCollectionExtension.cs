using ClothesShop.Infrastructure.Persistence;
using ClothesShop.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddConfiguration(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ClothesShopDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("ClothesShop")));

            services.AddScoped<ClothesShopSeeder>();
        }
    }
}
