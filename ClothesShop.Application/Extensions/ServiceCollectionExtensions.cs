using ClothesShop.Application.Mappings;
using ClothesShop.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IClothesShopService, ClothesShopService>();
            services.AddAutoMapper(typeof(ClothesShopMappingProfile));
        }
    } 
}
