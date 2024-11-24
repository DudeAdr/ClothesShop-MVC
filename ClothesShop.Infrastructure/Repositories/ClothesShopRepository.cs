using ClothesShop.Domain.Interfaces;
using ClothesShop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop.Infrastructure.Repositories
{
    internal class ClothesShopRepository : IClothesShopRepository
    {
        private ClothesShopDbContext _dbContext;

        public ClothesShopRepository(ClothesShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.ClothesShop clothesShop)
        {
            _dbContext.Add(clothesShop);
            await _dbContext.SaveChangesAsync();
        }
    }
}
