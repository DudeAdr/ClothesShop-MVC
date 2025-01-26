using ClothesShop.Application.ClothesShop;
using ClothesShop.Application.Mappings;
using ClothesShop.Application.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


namespace ClothesShop.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IClothesShopService, ClothesShopService>();

            services.AddAutoMapper(typeof(ClothesShopMappingProfile));

            services.AddValidatorsFromAssemblyContaining<ClothesShopDtoValidator>()
                    .AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters();
            
        }
    } 
}
