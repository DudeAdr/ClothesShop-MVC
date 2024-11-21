using ClothesShop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Infrastructure.Seeders
{
    public class ClothesShopSeeder
    {
        private readonly ClothesShopDbContext _dbContext;

        public ClothesShopSeeder(ClothesShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.ClothesShop.Any())
                {
                    var nike = new Domain.Entities.ClothesShop()
                    {
                        Brand = "Nike",
                        Description = "Damska bluza z kapturem o kroju oversize",
                        ItemDetails = new()
                        {
                            Name = "Nike Sportswear Phoenix Fleece",
                            Size = "XS, S, M, L, XL, XXL",
                            Colour = "Red, White, Black",
                            Price = 255.99
                        }       
                    };

                    nike.EncodeBrand();

                    _dbContext.ClothesShop.Add(nike);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
